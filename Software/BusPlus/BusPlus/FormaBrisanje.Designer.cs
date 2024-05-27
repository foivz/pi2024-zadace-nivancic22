namespace BusPlus
{
    partial class FormaBrisanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBrisanje));
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrisiGumb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IdLin = new System.Windows.Forms.TextBox();
            this.PovratakGumb = new System.Windows.Forms.Button();
            this.prikazLinija.SuspendLayout();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(0, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 3;
            this.prikazLinija.Paint += new System.Windows.Forms.PaintEventHandler(this.prikazLinija_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BusPlus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(114, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Linije:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BrisiGumb
            // 
            this.BrisiGumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrisiGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrisiGumb.Location = new System.Drawing.Point(143, 214);
            this.BrisiGumb.Name = "BrisiGumb";
            this.BrisiGumb.Size = new System.Drawing.Size(112, 31);
            this.BrisiGumb.TabIndex = 18;
            this.BrisiGumb.Text = "Izbriši";
            this.BrisiGumb.UseVisualStyleBackColor = true;
            this.BrisiGumb.Click += new System.EventHandler(this.BrisiGumb_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(123, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Koju liniju želite izbrisati?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdLin
            // 
            this.IdLin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IdLin.Location = new System.Drawing.Point(191, 126);
            this.IdLin.Name = "IdLin";
            this.IdLin.Size = new System.Drawing.Size(86, 21);
            this.IdLin.TabIndex = 20;
            this.IdLin.TextChanged += new System.EventHandler(this.IdLin_TextChanged);
            // 
            // PovratakGumb
            // 
            this.PovratakGumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PovratakGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PovratakGumb.Location = new System.Drawing.Point(295, 62);
            this.PovratakGumb.Name = "PovratakGumb";
            this.PovratakGumb.Size = new System.Drawing.Size(83, 22);
            this.PovratakGumb.TabIndex = 21;
            this.PovratakGumb.Text = "Povratak";
            this.PovratakGumb.UseVisualStyleBackColor = true;
            this.PovratakGumb.Click += new System.EventHandler(this.PovratakGumb_Click);
            // 
            // FormaBrisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 285);
            this.Controls.Add(this.PovratakGumb);
            this.Controls.Add(this.IdLin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrisiGumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prikazLinija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaBrisanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaBrisanje";
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrisiGumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdLin;
        private System.Windows.Forms.Button PovratakGumb;
    }
}