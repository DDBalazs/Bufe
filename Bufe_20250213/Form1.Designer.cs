namespace Bufe_20250213
{
    partial class FoForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txsearch = new System.Windows.Forms.TextBox();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.sorszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizetendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbedit = new System.Windows.Forms.RadioButton();
            this.rbnew = new System.Windows.Forms.RadioButton();
            this.padatok = new System.Windows.Forms.Panel();
            this.txbrutto = new System.Windows.Forms.TextBox();
            this.txmenny = new System.Windows.Forms.TextBox();
            this.txtermek = new System.Windows.Forms.TextBox();
            this.dtdatum = new System.Windows.Forms.DateTimePicker();
            this.txvevo = new System.Windows.Forms.TextBox();
            this.txsorszam = new System.Windows.Forms.TextBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.lbfizetendo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.padatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés: ";
            // 
            // txsearch
            // 
            this.txsearch.Location = new System.Drawing.Point(72, 6);
            this.txsearch.MaxLength = 20;
            this.txsearch.Name = "txsearch";
            this.txsearch.Size = new System.Drawing.Size(100, 20);
            this.txsearch.TabIndex = 1;
            this.txsearch.TextChanged += new System.EventHandler(this.txsearch_TextChanged);
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorszam,
            this.vevo,
            this.datum,
            this.termek,
            this.menny,
            this.brutto,
            this.fizetendo});
            this.dgadatok.Location = new System.Drawing.Point(12, 32);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(755, 436);
            this.dgadatok.TabIndex = 2;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // sorszam
            // 
            this.sorszam.HeaderText = "Sorszám";
            this.sorszam.Name = "sorszam";
            this.sorszam.ReadOnly = true;
            // 
            // vevo
            // 
            this.vevo.HeaderText = "Vevő neve";
            this.vevo.Name = "vevo";
            this.vevo.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // termek
            // 
            this.termek.HeaderText = "Termék";
            this.termek.Name = "termek";
            this.termek.ReadOnly = true;
            // 
            // menny
            // 
            this.menny.HeaderText = "Mennyiség";
            this.menny.Name = "menny";
            this.menny.ReadOnly = true;
            // 
            // brutto
            // 
            this.brutto.HeaderText = "Bruttó egységár";
            this.brutto.Name = "brutto";
            this.brutto.ReadOnly = true;
            // 
            // fizetendo
            // 
            this.fizetendo.HeaderText = "Fizetendő ár";
            this.fizetendo.Name = "fizetendo";
            this.fizetendo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbedit);
            this.groupBox1.Controls.Add(this.rbnew);
            this.groupBox1.Location = new System.Drawing.Point(773, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Művészet";
            // 
            // rbedit
            // 
            this.rbedit.AutoSize = true;
            this.rbedit.Location = new System.Drawing.Point(6, 56);
            this.rbedit.Name = "rbedit";
            this.rbedit.Size = new System.Drawing.Size(84, 17);
            this.rbedit.TabIndex = 1;
            this.rbedit.TabStop = true;
            this.rbedit.Text = "Módosítás";
            this.rbedit.UseVisualStyleBackColor = true;
            this.rbedit.CheckedChanged += new System.EventHandler(this.rbedit_CheckedChanged);
            // 
            // rbnew
            // 
            this.rbnew.AutoSize = true;
            this.rbnew.Location = new System.Drawing.Point(6, 19);
            this.rbnew.Name = "rbnew";
            this.rbnew.Size = new System.Drawing.Size(90, 17);
            this.rbnew.TabIndex = 0;
            this.rbnew.TabStop = true;
            this.rbnew.Text = "Új felvétele";
            this.rbnew.UseVisualStyleBackColor = true;
            this.rbnew.CheckedChanged += new System.EventHandler(this.rbnew_CheckedChanged);
            // 
            // padatok
            // 
            this.padatok.Controls.Add(this.txbrutto);
            this.padatok.Controls.Add(this.txmenny);
            this.padatok.Controls.Add(this.txtermek);
            this.padatok.Controls.Add(this.dtdatum);
            this.padatok.Controls.Add(this.txvevo);
            this.padatok.Controls.Add(this.txsorszam);
            this.padatok.Controls.Add(this.btexit);
            this.padatok.Controls.Add(this.btsave);
            this.padatok.Controls.Add(this.lbfizetendo);
            this.padatok.Controls.Add(this.label7);
            this.padatok.Controls.Add(this.label6);
            this.padatok.Controls.Add(this.label5);
            this.padatok.Controls.Add(this.label4);
            this.padatok.Controls.Add(this.label3);
            this.padatok.Controls.Add(this.label2);
            this.padatok.Location = new System.Drawing.Point(773, 138);
            this.padatok.Name = "padatok";
            this.padatok.Size = new System.Drawing.Size(281, 330);
            this.padatok.TabIndex = 4;
            // 
            // txbrutto
            // 
            this.txbrutto.Location = new System.Drawing.Point(109, 181);
            this.txbrutto.MaxLength = 11;
            this.txbrutto.Name = "txbrutto";
            this.txbrutto.Size = new System.Drawing.Size(91, 20);
            this.txbrutto.TabIndex = 15;
            this.txbrutto.TextChanged += new System.EventHandler(this.txbrutto_TextChanged);
            // 
            // txmenny
            // 
            this.txmenny.Location = new System.Drawing.Point(80, 148);
            this.txmenny.MaxLength = 11;
            this.txmenny.Name = "txmenny";
            this.txmenny.Size = new System.Drawing.Size(86, 20);
            this.txmenny.TabIndex = 14;
            this.txmenny.TextChanged += new System.EventHandler(this.txmenny_TextChanged);
            // 
            // txtermek
            // 
            this.txtermek.Location = new System.Drawing.Point(56, 115);
            this.txtermek.MaxLength = 20;
            this.txtermek.Name = "txtermek";
            this.txtermek.Size = new System.Drawing.Size(184, 20);
            this.txtermek.TabIndex = 13;
            // 
            // dtdatum
            // 
            this.dtdatum.CustomFormat = "yyyy-MM-dd";
            this.dtdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdatum.Location = new System.Drawing.Point(56, 80);
            this.dtdatum.Name = "dtdatum";
            this.dtdatum.Size = new System.Drawing.Size(200, 20);
            this.dtdatum.TabIndex = 12;
            // 
            // txvevo
            // 
            this.txvevo.Location = new System.Drawing.Point(81, 43);
            this.txvevo.MaxLength = 20;
            this.txvevo.Name = "txvevo";
            this.txvevo.Size = new System.Drawing.Size(197, 20);
            this.txvevo.TabIndex = 11;
            // 
            // txsorszam
            // 
            this.txsorszam.Location = new System.Drawing.Point(67, 12);
            this.txsorszam.MaxLength = 4;
            this.txsorszam.Name = "txsorszam";
            this.txsorszam.Size = new System.Drawing.Size(71, 20);
            this.txsorszam.TabIndex = 10;
            this.txsorszam.TextChanged += new System.EventHandler(this.txsorszam_TextChanged);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(156, 275);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(122, 52);
            this.btexit.TabIndex = 9;
            this.btexit.Text = "Elvet";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(6, 275);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(122, 52);
            this.btsave.TabIndex = 8;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbfizetendo
            // 
            this.lbfizetendo.AutoSize = true;
            this.lbfizetendo.ForeColor = System.Drawing.Color.Red;
            this.lbfizetendo.Location = new System.Drawing.Point(3, 237);
            this.lbfizetendo.Name = "lbfizetendo";
            this.lbfizetendo.Size = new System.Drawing.Size(135, 13);
            this.lbfizetendo.TabIndex = 6;
            this.lbfizetendo.Text = "Fizetendő összeg: 0 Ft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bruttó egységár:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mennyiség:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Termék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vevő neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorszám:";
            // 
            // FoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 480);
            this.Controls.Add(this.padatok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.txsearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katica büfé";
            this.Load += new System.EventHandler(this.FoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.padatok.ResumeLayout(false);
            this.padatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txsearch;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn vevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn menny;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizetendo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbedit;
        private System.Windows.Forms.RadioButton rbnew;
        private System.Windows.Forms.Panel padatok;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbfizetendo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbrutto;
        private System.Windows.Forms.TextBox txmenny;
        private System.Windows.Forms.TextBox txtermek;
        private System.Windows.Forms.DateTimePicker dtdatum;
        private System.Windows.Forms.TextBox txvevo;
        private System.Windows.Forms.TextBox txsorszam;
    }
}

