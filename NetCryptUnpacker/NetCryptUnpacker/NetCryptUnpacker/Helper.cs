using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetCryptUnpacker
{
    class Helper
    {
        static byte[] rawbyte = null;
        static string key = null;
        static string aesiv = null;
        public static bool FindByteArray(ModuleDefMD md)
        {
            foreach (var type in md.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    CilBody body = method.Body;
                    for (int i = 0; i < body.Instructions.Count; i++)
                    {
                        if (body.Instructions[i].OpCode == OpCodes.Ldstr &&
                            body.Instructions[i + 1].OpCode == OpCodes.Call &&
                            body.Instructions[i + 1].Operand.ToString().Contains("From") &&
                            body.Instructions[i + 2].OpCode == OpCodes.Stloc_3)
                        {
                            rawbyte = Convert.FromBase64String(body.Instructions[i].Operand.ToString());
                            return true;
                        }


                    }
                }

            }
            return false;
        }
        public static bool FindAesKey(ModuleDefMD md)
        {
            foreach (var type in md.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    CilBody body = method.Body;
                    for (int i = 0; i < body.Instructions.Count; i++)
                    {
                        if (body.Instructions[i].OpCode == OpCodes.Ldstr &&
                            body.Instructions[i + 1].OpCode == OpCodes.Call &&
                            body.Instructions[i + 1].Operand.ToString().Contains("From") &&
                            body.Instructions[i + 2].OpCode == OpCodes.Callvirt && body.Instructions[i +2].Operand.ToString().Contains("set_Key"))
                        {
                            key = body.Instructions[i].Operand.ToString();
                            return true;
                        }
                    }
                }
            }
            return false;

        }
        public static bool FindAesIV(ModuleDefMD md)
        {
            foreach (var type in md.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    CilBody body = method.Body;
                    for (int i = 0; i < body.Instructions.Count; i++)
                    {
                        if (body.Instructions[i].OpCode == OpCodes.Ldstr &&
                            body.Instructions[i + 1].OpCode == OpCodes.Call &&
                            body.Instructions[i + 1].Operand.ToString().Contains("From") &&
                            body.Instructions[i + 2].OpCode == OpCodes.Callvirt && body.Instructions[i + 2].Operand.ToString().Contains("set_IV"))
                        {
                            aesiv = body.Instructions[i].Operand.ToString();
                            return true;
                        }
                    }
                }
            }
            return false;

        }
        public static void WriteToFile(string path)
        {
           
            
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.KeySize = 256;
            rijndaelManaged.Key = Convert.FromBase64String(key);
            rijndaelManaged.IV = Convert.FromBase64String(aesiv);
            rijndaelManaged.Padding = PaddingMode.ISO10126;
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(rawbyte, 0, rawbyte.Length);
            cryptoStream.Flush();
            cryptoStream.Close();
            cryptoStream.Dispose();
            byte[] decAssembly = memoryStream.ToArray();
            System.IO.File.WriteAllBytes(path, decAssembly);
        }
    }
}
