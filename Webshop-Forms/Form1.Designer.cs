namespace Webshop_db_modositas
{
    partial class frmadatok
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
            this.txkereses_nev = new System.Windows.Forms.TextBox();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbkereses_kategoria = new System.Windows.Forms.ComboBox();
            this.cbkereses_gyarto = new System.Windows.Forms.ComboBox();
            this.txcikkszam = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.dgtul = new System.Windows.Forms.DataGridView();
            this.tulajdonsag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txkeszlet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txkedvezmeny = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txurl = new System.Windows.Forms.TextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txar = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.colCikkszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kedv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyarto_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtul)).BeginInit();
            this.SuspendLayout();
            // 
            // txkereses_nev
            // 
            this.txkereses_nev.BackColor = System.Drawing.SystemColors.Window;
            this.txkereses_nev.Location = new System.Drawing.Point(190, 12);
            this.txkereses_nev.Name = "txkereses_nev";
            this.txkereses_nev.Size = new System.Drawing.Size(299, 19);
            this.txkereses_nev.TabIndex = 0;
            this.txkereses_nev.TextChanged += new System.EventHandler(this.txkereses_nev_TextChanged);
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCikkszam,
            this.nev,
            this.keszlet,
            this.netto,
            this.kedv,
            this.kat_nev,
            this.gyarto_nev,
            this.kat_id});
            this.dgadatok.Location = new System.Drawing.Point(12, 40);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.RowHeadersWidth = 51;
            this.dgadatok.RowTemplate.Height = 24;
            this.dgadatok.Size = new System.Drawing.Size(1117, 556);
            this.dgadatok.TabIndex = 1;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresések";
            // 
            // cbkereses_kategoria
            // 
            this.cbkereses_kategoria.BackColor = System.Drawing.Color.Wheat;
            this.cbkereses_kategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkereses_kategoria.FormattingEnabled = true;
            this.cbkereses_kategoria.Location = new System.Drawing.Point(843, 10);
            this.cbkereses_kategoria.Name = "cbkereses_kategoria";
            this.cbkereses_kategoria.Size = new System.Drawing.Size(116, 21);
            this.cbkereses_kategoria.TabIndex = 3;
            this.cbkereses_kategoria.SelectedIndexChanged += new System.EventHandler(this.cbkereses_kategoria_SelectedIndexChanged);
            // 
            // cbkereses_gyarto
            // 
            this.cbkereses_gyarto.BackColor = System.Drawing.Color.Wheat;
            this.cbkereses_gyarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkereses_gyarto.FormattingEnabled = true;
            this.cbkereses_gyarto.Location = new System.Drawing.Point(965, 10);
            this.cbkereses_gyarto.Name = "cbkereses_gyarto";
            this.cbkereses_gyarto.Size = new System.Drawing.Size(124, 21);
            this.cbkereses_gyarto.TabIndex = 4;
            this.cbkereses_gyarto.SelectedIndexChanged += new System.EventHandler(this.cbkereses_gyarto_SelectedIndexChanged);
            // 
            // txcikkszam
            // 
            this.txcikkszam.BackColor = System.Drawing.SystemColors.Window;
            this.txcikkszam.Location = new System.Drawing.Point(81, 10);
            this.txcikkszam.MaxLength = 8;
            this.txcikkszam.Name = "txcikkszam";
            this.txcikkszam.Size = new System.Drawing.Size(103, 19);
            this.txcikkszam.TabIndex = 5;
            this.txcikkszam.TextChanged += new System.EventHandler(this.txcikkszam_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(719, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(118, 31);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Új Hozzáadás";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.Red;
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(1095, 3);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(34, 31);
            this.btclose.TabIndex = 8;
            this.btclose.Text = "X";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // dgtul
            // 
            this.dgtul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tulajdonsag,
            this.adatok});
            this.dgtul.Location = new System.Drawing.Point(1173, 40);
            this.dgtul.Name = "dgtul";
            this.dgtul.RowHeadersWidth = 51;
            this.dgtul.Size = new System.Drawing.Size(683, 443);
            this.dgtul.TabIndex = 9;
            // 
            // tulajdonsag
            // 
            this.tulajdonsag.HeaderText = "Tulajdonság";
            this.tulajdonsag.MinimumWidth = 6;
            this.tulajdonsag.Name = "tulajdonsag";
            this.tulajdonsag.ReadOnly = true;
            this.tulajdonsag.Width = 300;
            // 
            // adatok
            // 
            this.adatok.HeaderText = "Adatok";
            this.adatok.MinimumWidth = 6;
            this.adatok.Name = "adatok";
            this.adatok.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1170, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Termék Név:";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(1260, 492);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(380, 19);
            this.txnev.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1170, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Készlet:";
            // 
            // txkeszlet
            // 
            this.txkeszlet.Location = new System.Drawing.Point(1237, 517);
            this.txkeszlet.Name = "txkeszlet";
            this.txkeszlet.Size = new System.Drawing.Size(62, 19);
            this.txkeszlet.TabIndex = 13;
            this.txkeszlet.TextChanged += new System.EventHandler(this.txkeszlet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1301, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kedvezmény:";
            // 
            // txkedvezmeny
            // 
            this.txkedvezmeny.Location = new System.Drawing.Point(1389, 514);
            this.txkedvezmeny.MaxLength = 2;
            this.txkedvezmeny.Name = "txkedvezmeny";
            this.txkedvezmeny.Size = new System.Drawing.Size(62, 19);
            this.txkedvezmeny.TabIndex = 15;
            this.txkedvezmeny.TextChanged += new System.EventHandler(this.txkedvezmeny_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1458, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kép URL:";
            // 
            // txurl
            // 
            this.txurl.Location = new System.Drawing.Point(1527, 513);
            this.txurl.Name = "txurl";
            this.txurl.Size = new System.Drawing.Size(329, 19);
            this.txurl.TabIndex = 17;
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(1176, 540);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(680, 55);
            this.btnmod.TabIndex = 18;
            this.btnmod.Text = "Termék Módosítása";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1636, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Termék Ár:";
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(1721, 489);
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(135, 19);
            this.txar.TabIndex = 20;
            this.txar.TextChanged += new System.EventHandler(this.txar_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(495, 11);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(15, 21);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "X";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // colCikkszam
            // 
            this.colCikkszam.HeaderText = "Cikkszám";
            this.colCikkszam.MinimumWidth = 6;
            this.colCikkszam.Name = "colCikkszam";
            this.colCikkszam.ReadOnly = true;
            this.colCikkszam.Width = 125;
            // 
            // nev
            // 
            this.nev.HeaderText = "Termék neve";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 300;
            // 
            // keszlet
            // 
            this.keszlet.HeaderText = "Készlet";
            this.keszlet.MinimumWidth = 6;
            this.keszlet.Name = "keszlet";
            this.keszlet.ReadOnly = true;
            this.keszlet.Width = 75;
            // 
            // netto
            // 
            this.netto.HeaderText = "Termék Ára";
            this.netto.MinimumWidth = 6;
            this.netto.Name = "netto";
            this.netto.ReadOnly = true;
            this.netto.Width = 150;
            // 
            // kedv
            // 
            this.kedv.HeaderText = "Kedvezmény";
            this.kedv.MinimumWidth = 6;
            this.kedv.Name = "kedv";
            this.kedv.ReadOnly = true;
            this.kedv.Width = 125;
            // 
            // kat_nev
            // 
            this.kat_nev.HeaderText = "Kategória";
            this.kat_nev.MinimumWidth = 6;
            this.kat_nev.Name = "kat_nev";
            this.kat_nev.ReadOnly = true;
            this.kat_nev.Width = 125;
            // 
            // gyarto_nev
            // 
            this.gyarto_nev.HeaderText = "Gyártó";
            this.gyarto_nev.MinimumWidth = 6;
            this.gyarto_nev.Name = "gyarto_nev";
            this.gyarto_nev.ReadOnly = true;
            this.gyarto_nev.Width = 125;
            // 
            // kat_id
            // 
            this.kat_id.HeaderText = "kat_nev";
            this.kat_id.MinimumWidth = 6;
            this.kat_id.Name = "kat_id";
            this.kat_id.ReadOnly = true;
            this.kat_id.Visible = false;
            this.kat_id.Width = 125;
            // 
            // frmadatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1905, 1033);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.txurl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txkedvezmeny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txkeszlet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgtul);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txcikkszam);
            this.Controls.Add(this.cbkereses_gyarto);
            this.Controls.Add(this.cbkereses_kategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.txkereses_nev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmadatok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatok";
            this.Load += new System.EventHandler(this.frmadatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txkereses_nev;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbkereses_kategoria;
        private System.Windows.Forms.ComboBox cbkereses_gyarto;
        private System.Windows.Forms.TextBox txcikkszam;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.DataGridView dgtul;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajdonsag;
        private System.Windows.Forms.DataGridViewTextBoxColumn adatok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txkeszlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txkedvezmeny;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txurl;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCikkszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn kedv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyarto_nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn kat_id;
    }
}

