namespace Webshop_db_modositas
{
    partial class Frmgyh
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
            this.txgyarto = new System.Windows.Forms.TextBox();
            this.btnujgyarto = new System.Windows.Forms.Button();
            this.dggyarto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gyarto_nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dggyarto)).BeginInit();
            this.SuspendLayout();
            // 
            // txgyarto
            // 
            this.txgyarto.Location = new System.Drawing.Point(12, 206);
            this.txgyarto.Name = "txgyarto";
            this.txgyarto.Size = new System.Drawing.Size(214, 20);
            this.txgyarto.TabIndex = 0;
            // 
            // btnujgyarto
            // 
            this.btnujgyarto.Location = new System.Drawing.Point(12, 232);
            this.btnujgyarto.Name = "btnujgyarto";
            this.btnujgyarto.Size = new System.Drawing.Size(175, 29);
            this.btnujgyarto.TabIndex = 1;
            this.btnujgyarto.Text = "Gyártó Hozzáadása";
            this.btnujgyarto.UseVisualStyleBackColor = true;
            this.btnujgyarto.Click += new System.EventHandler(this.btnujgyarto_Click);
            // 
            // dggyarto
            // 
            this.dggyarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggyarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gyarto_nev});
            this.dggyarto.Location = new System.Drawing.Point(12, 12);
            this.dggyarto.Name = "dggyarto";
            this.dggyarto.Size = new System.Drawing.Size(214, 167);
            this.dggyarto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új gyártó hozzáadása";
            // 
            // gyarto_nev
            // 
            this.gyarto_nev.HeaderText = "Gyártó Megnevezése";
            this.gyarto_nev.Name = "gyarto_nev";
            this.gyarto_nev.ReadOnly = true;
            this.gyarto_nev.Width = 150;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(188, 232);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(39, 29);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Frmgyh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dggyarto);
            this.Controls.Add(this.btnujgyarto);
            this.Controls.Add(this.txgyarto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frmgyh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gyártó Hozzáadása";
            this.Load += new System.EventHandler(this.Frmgyh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dggyarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txgyarto;
        private System.Windows.Forms.Button btnujgyarto;
        private System.Windows.Forms.DataGridView dggyarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyarto_nev;
        private System.Windows.Forms.Button btnclose;
    }
}