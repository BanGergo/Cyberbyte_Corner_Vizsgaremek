namespace Webshop_db_modositas
{
    partial class frmadd
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
            this.cbkategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txnev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txkesz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txkedv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbgyarto = new System.Windows.Forms.ComboBox();
            this.dghozzaadas = new System.Windows.Forms.DataGridView();
            this.tulajdonsagok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbar = new System.Windows.Forms.Label();
            this.txar = new System.Windows.Forms.TextBox();
            this.btnmentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txurl = new System.Windows.Forms.TextBox();
            this.btngyhozzadas = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dghozzaadas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkategoria
            // 
            this.cbkategoria.BackColor = System.Drawing.Color.Wheat;
            this.cbkategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategoria.FormattingEnabled = true;
            this.cbkategoria.Location = new System.Drawing.Point(138, 91);
            this.cbkategoria.Name = "cbkategoria";
            this.cbkategoria.Size = new System.Drawing.Size(121, 21);
            this.cbkategoria.TabIndex = 0;
            this.cbkategoria.SelectedIndexChanged += new System.EventHandler(this.cbkategoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Név:";
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(85, 13);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(251, 20);
            this.txnev.TabIndex = 6;
            this.txnev.TextChanged += new System.EventHandler(this.txnev_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategória";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Készlet:";
            // 
            // txkesz
            // 
            this.txkesz.Location = new System.Drawing.Point(400, 15);
            this.txkesz.Name = "txkesz";
            this.txkesz.Size = new System.Drawing.Size(77, 20);
            this.txkesz.TabIndex = 9;
            this.txkesz.TextChanged += new System.EventHandler(this.txkesz_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kedvezmény:";
            // 
            // txkedv
            // 
            this.txkedv.Location = new System.Drawing.Point(571, 16);
            this.txkedv.MaxLength = 2;
            this.txkedv.Name = "txkedv";
            this.txkedv.Size = new System.Drawing.Size(67, 20);
            this.txkedv.TabIndex = 11;
            this.txkedv.TextChanged += new System.EventHandler(this.txkedv_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gyártó:";
            // 
            // cbgyarto
            // 
            this.cbgyarto.BackColor = System.Drawing.Color.Wheat;
            this.cbgyarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgyarto.FormattingEnabled = true;
            this.cbgyarto.Location = new System.Drawing.Point(328, 88);
            this.cbgyarto.Name = "cbgyarto";
            this.cbgyarto.Size = new System.Drawing.Size(121, 21);
            this.cbgyarto.TabIndex = 13;
            // 
            // dghozzaadas
            // 
            this.dghozzaadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghozzaadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tulajdonsagok,
            this.adatok});
            this.dghozzaadas.Location = new System.Drawing.Point(12, 124);
            this.dghozzaadas.Name = "dghozzaadas";
            this.dghozzaadas.RowHeadersWidth = 51;
            this.dghozzaadas.RowTemplate.Height = 24;
            this.dghozzaadas.Size = new System.Drawing.Size(684, 488);
            this.dghozzaadas.TabIndex = 14;
            // 
            // tulajdonsagok
            // 
            this.tulajdonsagok.HeaderText = "Tulajdonságok";
            this.tulajdonsagok.MinimumWidth = 6;
            this.tulajdonsagok.Name = "tulajdonsagok";
            this.tulajdonsagok.ReadOnly = true;
            this.tulajdonsagok.Width = 300;
            // 
            // adatok
            // 
            this.adatok.HeaderText = "Adatok";
            this.adatok.MinimumWidth = 6;
            this.adatok.Name = "adatok";
            this.adatok.Width = 300;
            // 
            // lbar
            // 
            this.lbar.AutoSize = true;
            this.lbar.Location = new System.Drawing.Point(45, 56);
            this.lbar.Name = "lbar";
            this.lbar.Size = new System.Drawing.Size(68, 13);
            this.lbar.TabIndex = 15;
            this.lbar.Text = "Termék ár:";
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(138, 56);
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(167, 20);
            this.txar.TabIndex = 16;
            this.txar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(12, 618);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(684, 29);
            this.btnmentes.TabIndex = 17;
            this.btnmentes.Text = "Új termék hozzáadása";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kép URL:";
            // 
            // txurl
            // 
            this.txurl.Location = new System.Drawing.Point(392, 56);
            this.txurl.Name = "txurl";
            this.txurl.Size = new System.Drawing.Size(279, 20);
            this.txurl.TabIndex = 19;
            // 
            // btngyhozzadas
            // 
            this.btngyhozzadas.Location = new System.Drawing.Point(455, 89);
            this.btngyhozzadas.Name = "btngyhozzadas";
            this.btngyhozzadas.Size = new System.Drawing.Size(152, 23);
            this.btngyhozzadas.TabIndex = 20;
            this.btngyhozzadas.Text = "Új Gyártó Hozzáadás";
            this.btngyhozzadas.UseVisualStyleBackColor = true;
            this.btngyhozzadas.Click += new System.EventHandler(this.btngyhozzadas_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(664, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(36, 30);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 653);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btngyhozzadas);
            this.Controls.Add(this.txurl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.txar);
            this.Controls.Add(this.lbar);
            this.Controls.Add(this.dghozzaadas);
            this.Controls.Add(this.cbgyarto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txkedv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txkesz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbkategoria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hozzáadás";
            this.Load += new System.EventHandler(this.frmadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dghozzaadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbkategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txkesz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txkedv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbgyarto;
        private System.Windows.Forms.DataGridView dghozzaadas;
        private System.Windows.Forms.Label lbar;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajdonsagok;
        private System.Windows.Forms.DataGridViewTextBoxColumn adatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txurl;
        private System.Windows.Forms.Button btngyhozzadas;
        private System.Windows.Forms.Button btnclose;
    }
}