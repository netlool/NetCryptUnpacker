namespace NetCryptUnpacker
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btoutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboutput = new System.Windows.Forms.TextBox();
            this.btofd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-124, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-124, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input File:";
            // 
            // btnUnpack
            // 
            this.btnUnpack.Location = new System.Drawing.Point(12, 119);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(470, 45);
            this.btnUnpack.TabIndex = 18;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btoutput
            // 
            this.btoutput.Location = new System.Drawing.Point(488, 79);
            this.btoutput.Name = "btoutput";
            this.btoutput.Size = new System.Drawing.Size(58, 23);
            this.btoutput.TabIndex = 17;
            this.btoutput.Text = "...";
            this.btoutput.UseVisualStyleBackColor = true;
            this.btoutput.Click += new System.EventHandler(this.btoutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Output File:";
            // 
            // tboutput
            // 
            this.tboutput.Location = new System.Drawing.Point(12, 81);
            this.tboutput.Multiline = true;
            this.tboutput.Name = "tboutput";
            this.tboutput.Size = new System.Drawing.Size(470, 20);
            this.tboutput.TabIndex = 15;
            // 
            // btofd
            // 
            this.btofd.Location = new System.Drawing.Point(488, 29);
            this.btofd.Name = "btofd";
            this.btofd.Size = new System.Drawing.Size(58, 23);
            this.btofd.TabIndex = 14;
            this.btofd.Text = "...";
            this.btofd.UseVisualStyleBackColor = true;
            this.btofd.Click += new System.EventHandler(this.btofd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Input File:";
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(12, 31);
            this.tbinput.Multiline = true;
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(470, 20);
            this.tbinput.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 176);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.btoutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboutput);
            this.Controls.Add(this.btofd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "NetCrypt Unpacker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btoutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboutput;
        private System.Windows.Forms.Button btofd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbinput;
    }
}

