﻿namespace BusPlus
{
    partial class FormaKreiranjeLinije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaKreiranjeLinije));
            this.prikazLinija = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pocStan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zavrStan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idLin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brBus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pocVr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zavrVr = new System.Windows.Forms.TextBox();
            this.dodaj_gumb = new System.Windows.Forms.Button();
            this.prikazLinija.SuspendLayout();
            this.SuspendLayout();
            // 
            // prikazLinija
            // 
            this.prikazLinija.BackColor = System.Drawing.Color.Maroon;
            this.prikazLinija.Controls.Add(this.label1);
            this.prikazLinija.Location = new System.Drawing.Point(0, 0);
            this.prikazLinija.Name = "prikazLinija";
            this.prikazLinija.Size = new System.Drawing.Size(813, 56);
            this.prikazLinija.TabIndex = 2;
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
            // pocStan
            // 
            this.pocStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocStan.Location = new System.Drawing.Point(246, 127);
            this.pocStan.Name = "pocStan";
            this.pocStan.Size = new System.Drawing.Size(220, 22);
            this.pocStan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Početna stanica: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Završna stanica:";
            // 
            // zavrStan
            // 
            this.zavrStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zavrStan.Location = new System.Drawing.Point(246, 156);
            this.zavrStan.Name = "zavrStan";
            this.zavrStan.Size = new System.Drawing.Size(220, 22);
            this.zavrStan.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(80, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID autobusne linije:";
            // 
            // idLin
            // 
            this.idLin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLin.Location = new System.Drawing.Point(246, 96);
            this.idLin.Name = "idLin";
            this.idLin.Size = new System.Drawing.Size(38, 22);
            this.idLin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(80, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID autobusa:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // brBus
            // 
            this.brBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brBus.Location = new System.Drawing.Point(246, 187);
            this.brBus.Name = "brBus";
            this.brBus.Size = new System.Drawing.Size(38, 22);
            this.brBus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(80, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Početno vrijeme:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pocVr
            // 
            this.pocVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pocVr.Location = new System.Drawing.Point(246, 221);
            this.pocVr.Name = "pocVr";
            this.pocVr.Size = new System.Drawing.Size(124, 22);
            this.pocVr.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(80, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Završno vrijeme:";
            // 
            // zavrVr
            // 
            this.zavrVr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zavrVr.Location = new System.Drawing.Point(246, 257);
            this.zavrVr.Name = "zavrVr";
            this.zavrVr.Size = new System.Drawing.Size(124, 22);
            this.zavrVr.TabIndex = 14;
            // 
            // dodaj_gumb
            // 
            this.dodaj_gumb.Location = new System.Drawing.Point(199, 301);
            this.dodaj_gumb.Name = "dodaj_gumb";
            this.dodaj_gumb.Size = new System.Drawing.Size(125, 33);
            this.dodaj_gumb.TabIndex = 15;
            this.dodaj_gumb.Text = "Dodaj";
            this.dodaj_gumb.UseVisualStyleBackColor = true;
            this.dodaj_gumb.Click += new System.EventHandler(this.dodaj_gumb_Click);
            // 
            // FormaKreiranjeLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 346);
            this.Controls.Add(this.dodaj_gumb);
            this.Controls.Add(this.zavrVr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pocVr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brBus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idLin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zavrStan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pocStan);
            this.Controls.Add(this.prikazLinija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaKreiranjeLinije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaKreiranjeLinije";
            this.prikazLinija.ResumeLayout(false);
            this.prikazLinija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel prikazLinija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pocStan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zavrStan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idLin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pocVr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zavrVr;
        private System.Windows.Forms.Button dodaj_gumb;
    }
}