namespace BusPlus
{
    partial class frmIzmijenaLinije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzmijenaLinije));
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtIdLin = new System.Windows.Forms.TextBox();
            this.lblIdLin = new System.Windows.Forms.Label();
            this.txtZavrVr = new System.Windows.Forms.TextBox();
            this.lblZavrVr = new System.Windows.Forms.Label();
            this.txtPocVr = new System.Windows.Forms.TextBox();
            this.lblPocVr = new System.Windows.Forms.Label();
            this.txtBrBus = new System.Windows.Forms.TextBox();
            this.lblBus = new System.Windows.Forms.Label();
            this.txtZavrStan = new System.Windows.Forms.TextBox();
            this.lblZavrStan = new System.Windows.Forms.Label();
            this.lvlPocStan = new System.Windows.Forms.Label();
            this.txtPocStan = new System.Windows.Forms.TextBox();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.prikazLinija.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeni.Location = new System.Drawing.Point(198, 296);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(125, 33);
            this.btnIzmijeni.TabIndex = 29;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // prikazLinija
            // 
            this.prikazLinija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.lblNaslov);
            this.prikazLinija.Location = new System.Drawing.Point(0, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 18;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(114, 31);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "BusPlus";
            // 
            // txtIdLin
            // 
            this.txtIdLin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIdLin.Location = new System.Drawing.Point(253, 93);
            this.txtIdLin.Name = "txtIdLin";
            this.txtIdLin.Size = new System.Drawing.Size(38, 22);
            this.txtIdLin.TabIndex = 31;
            // 
            // lblIdLin
            // 
            this.lblIdLin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdLin.AutoSize = true;
            this.lblIdLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdLin.Location = new System.Drawing.Point(87, 93);
            this.lblIdLin.Name = "lblIdLin";
            this.lblIdLin.Size = new System.Drawing.Size(57, 16);
            this.lblIdLin.TabIndex = 30;
            this.lblIdLin.Text = "ID Linije:";
            // 
            // txtZavrVr
            // 
            this.txtZavrVr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZavrVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZavrVr.Location = new System.Drawing.Point(253, 249);
            this.txtZavrVr.Name = "txtZavrVr";
            this.txtZavrVr.Size = new System.Drawing.Size(124, 22);
            this.txtZavrVr.TabIndex = 28;
            // 
            // lblZavrVr
            // 
            this.lblZavrVr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZavrVr.AutoSize = true;
            this.lblZavrVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZavrVr.Location = new System.Drawing.Point(87, 252);
            this.lblZavrVr.Name = "lblZavrVr";
            this.lblZavrVr.Size = new System.Drawing.Size(106, 16);
            this.lblZavrVr.TabIndex = 27;
            this.lblZavrVr.Text = "Završno vrijeme:";
            // 
            // txtPocVr
            // 
            this.txtPocVr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPocVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPocVr.Location = new System.Drawing.Point(253, 213);
            this.txtPocVr.Name = "txtPocVr";
            this.txtPocVr.Size = new System.Drawing.Size(124, 22);
            this.txtPocVr.TabIndex = 26;
            // 
            // lblPocVr
            // 
            this.lblPocVr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPocVr.AutoSize = true;
            this.lblPocVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPocVr.Location = new System.Drawing.Point(87, 216);
            this.lblPocVr.Name = "lblPocVr";
            this.lblPocVr.Size = new System.Drawing.Size(107, 16);
            this.lblPocVr.TabIndex = 25;
            this.lblPocVr.Text = "Početno vrijeme:";
            // 
            // txtBrBus
            // 
            this.txtBrBus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrBus.Location = new System.Drawing.Point(253, 179);
            this.txtBrBus.Name = "txtBrBus";
            this.txtBrBus.Size = new System.Drawing.Size(38, 22);
            this.txtBrBus.TabIndex = 24;
            // 
            // lblBus
            // 
            this.lblBus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBus.Location = new System.Drawing.Point(87, 182);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(82, 16);
            this.lblBus.TabIndex = 23;
            this.lblBus.Text = "ID autobusa:";
            // 
            // txtZavrStan
            // 
            this.txtZavrStan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZavrStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZavrStan.Location = new System.Drawing.Point(253, 148);
            this.txtZavrStan.Name = "txtZavrStan";
            this.txtZavrStan.Size = new System.Drawing.Size(220, 22);
            this.txtZavrStan.TabIndex = 22;
            // 
            // lblZavrStan
            // 
            this.lblZavrStan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZavrStan.AutoSize = true;
            this.lblZavrStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZavrStan.Location = new System.Drawing.Point(87, 151);
            this.lblZavrStan.Name = "lblZavrStan";
            this.lblZavrStan.Size = new System.Drawing.Size(105, 16);
            this.lblZavrStan.TabIndex = 21;
            this.lblZavrStan.Text = "Završna stanica:";
            // 
            // lvlPocStan
            // 
            this.lvlPocStan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlPocStan.AutoSize = true;
            this.lvlPocStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlPocStan.Location = new System.Drawing.Point(87, 122);
            this.lvlPocStan.Name = "lvlPocStan";
            this.lvlPocStan.Size = new System.Drawing.Size(109, 16);
            this.lvlPocStan.TabIndex = 20;
            this.lvlPocStan.Text = "Početna stanica: ";
            // 
            // txtPocStan
            // 
            this.txtPocStan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPocStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPocStan.Location = new System.Drawing.Point(253, 119);
            this.txtPocStan.Name = "txtPocStan";
            this.txtPocStan.Size = new System.Drawing.Size(220, 22);
            this.txtPocStan.TabIndex = 19;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPovratak.Location = new System.Drawing.Point(453, 62);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(83, 22);
            this.btnPovratak.TabIndex = 1;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmIzmijenaLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.prikazLinija);
            this.Controls.Add(this.txtIdLin);
            this.Controls.Add(this.lblIdLin);
            this.Controls.Add(this.txtZavrVr);
            this.Controls.Add(this.lblZavrVr);
            this.Controls.Add(this.txtPocVr);
            this.Controls.Add(this.lblPocVr);
            this.Controls.Add(this.txtBrBus);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.txtZavrStan);
            this.Controls.Add(this.lblZavrStan);
            this.Controls.Add(this.lvlPocStan);
            this.Controls.Add(this.txtPocStan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIzmijenaLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmijena Linije";
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtIdLin;
        private System.Windows.Forms.Label lblIdLin;
        private System.Windows.Forms.TextBox txtZavrVr;
        private System.Windows.Forms.Label lblZavrVr;
        private System.Windows.Forms.TextBox txtPocVr;
        private System.Windows.Forms.Label lblPocVr;
        private System.Windows.Forms.TextBox txtBrBus;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.TextBox txtZavrStan;
        private System.Windows.Forms.Label lblZavrStan;
        private System.Windows.Forms.Label lvlPocStan;
        private System.Windows.Forms.TextBox txtPocStan;
        private System.Windows.Forms.Button btnPovratak;
    }
}