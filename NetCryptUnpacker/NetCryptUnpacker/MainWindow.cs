using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCryptUnpacker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btofd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbinput.Text = ofd.FileName;
            }
        }

        private void btoutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tboutput.Text = sfd.FileName;
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            if (tbinput.Text.Equals(String.Empty) || tboutput.Text.Equals(String.Empty))
                MessageBox.Show(null, "Please choose a input/output file!", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    ModuleDefMD md = ModuleDefMD.Load(tbinput.Text);

                    if (Helper.FindByteArray(md))
                    {
                        if (Helper.FindAesKey(md))
                        {
                            if (Helper.FindAesIV(md))
                            {
                                Helper.WriteToFile(tboutput.Text);
                                MessageBox.Show(null, "Unpacked! Saved to " + tboutput.Text, "Unpacked!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show(null, "Could not find Aes IV", null, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show(null, "Could not find Aes Key", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(null, "Could not find raw byte array", null, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(null, "An error occured " + ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}