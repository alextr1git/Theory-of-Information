namespace LabWork2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isch = new System.Windows.Forms.RichTextBox();
            this.coded = new System.Windows.Forms.RichTextBox();
            this.key = new System.Windows.Forms.RichTextBox();
            this.initkey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bstart = new System.Windows.Forms.Button();
            this.fafter = new System.Windows.Forms.TextBox();
            this.fbefore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isch
            // 
            this.isch.Location = new System.Drawing.Point(515, 45);
            this.isch.Name = "isch";
            this.isch.Size = new System.Drawing.Size(744, 191);
            this.isch.TabIndex = 0;
            this.isch.Text = "";
            // 
            // coded
            // 
            this.coded.Location = new System.Drawing.Point(515, 301);
            this.coded.Name = "coded";
            this.coded.Size = new System.Drawing.Size(744, 191);
            this.coded.TabIndex = 1;
            this.coded.Text = "";
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(515, 565);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(744, 191);
            this.key.TabIndex = 2;
            this.key.Text = "";
            // 
            // initkey
            // 
            this.initkey.Location = new System.Drawing.Point(37, 301);
            this.initkey.Name = "initkey";
            this.initkey.Size = new System.Drawing.Size(394, 94);
            this.initkey.TabIndex = 3;
            this.initkey.Text = "";
            this.initkey.TextChanged += new System.EventHandler(this.initkey_TextChanged);
            this.initkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initkey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный регистр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исходный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кодированный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ключ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bstart
            // 
            this.bstart.Location = new System.Drawing.Point(37, 577);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(394, 97);
            this.bstart.TabIndex = 10;
            this.bstart.Text = "Начать";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // fafter
            // 
            this.fafter.Location = new System.Drawing.Point(37, 518);
            this.fafter.Name = "fafter";
            this.fafter.Size = new System.Drawing.Size(209, 31);
            this.fafter.TabIndex = 11;
            this.fafter.TextChanged += new System.EventHandler(this.fafter_TextChanged);
            // 
            // fbefore
            // 
            this.fbefore.Location = new System.Drawing.Point(37, 432);
            this.fbefore.Name = "fbefore";
            this.fbefore.Size = new System.Drawing.Size(209, 31);
            this.fbefore.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Файл исходный";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Файл конечный";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 832);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fbefore);
            this.Controls.Add(this.fafter);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initkey);
            this.Controls.Add(this.key);
            this.Controls.Add(this.coded);
            this.Controls.Add(this.isch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox isch;
        private System.Windows.Forms.RichTextBox coded;
        private System.Windows.Forms.RichTextBox key;
        private System.Windows.Forms.RichTextBox initkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.TextBox fafter;
        private System.Windows.Forms.TextBox fbefore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
