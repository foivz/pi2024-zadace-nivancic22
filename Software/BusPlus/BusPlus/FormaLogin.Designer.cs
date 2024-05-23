namespace BusPlus
{
    partial class FormaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.korime = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.korimeTextbox = new System.Windows.Forms.TextBox();
            this.lozinkaTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BusPlus";
            // 
            // korime
            // 
            this.korime.AutoSize = true;
            this.korime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korime.Location = new System.Drawing.Point(121, 112);
            this.korime.Name = "korime";
            this.korime.Size = new System.Drawing.Size(118, 20);
            this.korime.TabIndex = 1;
            this.korime.Text = "Korisničko ime: ";
            this.korime.Click += new System.EventHandler(this.label2_Click);
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinka.Location = new System.Drawing.Point(121, 152);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(72, 20);
            this.lozinka.TabIndex = 2;
            this.lozinka.Text = "Lozinka: ";
            this.lozinka.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(289, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // korimeTextbox
            // 
            this.korimeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korimeTextbox.Location = new System.Drawing.Point(245, 112);
            this.korimeTextbox.Name = "korimeTextbox";
            this.korimeTextbox.Size = new System.Drawing.Size(148, 26);
            this.korimeTextbox.TabIndex = 4;
            this.korimeTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lozinkaTextbox
            // 
            this.lozinkaTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinkaTextbox.Location = new System.Drawing.Point(245, 152);
            this.lozinkaTextbox.Name = "lozinkaTextbox";
            this.lozinkaTextbox.Size = new System.Drawing.Size(148, 26);
            this.lozinkaTextbox.TabIndex = 5;
            this.lozinkaTextbox.UseSystemPasswordChar = true;
            this.lozinkaTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 295);
            this.Controls.Add(this.lozinkaTextbox);
            this.Controls.Add(this.korimeTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korime);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label korime;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox korimeTextbox;
        private System.Windows.Forms.TextBox lozinkaTextbox;
    }
}

