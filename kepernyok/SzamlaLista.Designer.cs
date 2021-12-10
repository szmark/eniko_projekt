namespace szamlazo.kepernyok
{
    partial class SzamlaLista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letrehozva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljesites_datuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cegnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceg_cime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljesitve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMegtekint = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTipKimeno = new System.Windows.Forms.RadioButton();
            this.rbTipBejovo = new System.Windows.Forms.RadioButton();
            this.rbTipOsszes = new System.Windows.Forms.RadioButton();
            this.pnlKeresDatum = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.keresControlPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlKeresDatum.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.keresControlPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipus,
            this.letrehozva,
            this.teljesites_datuma,
            this.cegnev,
            this.ceg_cime,
            this.teljesitve});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(853, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Azonosító";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // tipus
            // 
            this.tipus.DataPropertyName = "tipus";
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // letrehozva
            // 
            this.letrehozva.DataPropertyName = "letrehozas_datuma";
            this.letrehozva.HeaderText = "Létrehozva";
            this.letrehozva.Name = "letrehozva";
            this.letrehozva.ReadOnly = true;
            // 
            // teljesites_datuma
            // 
            this.teljesites_datuma.DataPropertyName = "teljesites_datuma";
            this.teljesites_datuma.HeaderText = "Teljesítés időpontja";
            this.teljesites_datuma.Name = "teljesites_datuma";
            this.teljesites_datuma.ReadOnly = true;
            // 
            // cegnev
            // 
            this.cegnev.DataPropertyName = "ceg_nev";
            this.cegnev.HeaderText = "Cég neve";
            this.cegnev.Name = "cegnev";
            this.cegnev.ReadOnly = true;
            // 
            // ceg_cime
            // 
            this.ceg_cime.HeaderText = "Cég címe";
            this.ceg_cime.Name = "ceg_cime";
            this.ceg_cime.ReadOnly = true;
            // 
            // teljesitve
            // 
            this.teljesitve.HeaderText = "Teljesítve";
            this.teljesitve.Name = "teljesitve";
            this.teljesitve.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.btnMegtekint);
            this.flowLayoutPanel2.Controls.Add(this.btnModosit);
            this.flowLayoutPanel2.Controls.Add(this.btnTorles);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(708, 125);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(145, 396);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMegtekint
            // 
            this.btnMegtekint.Location = new System.Drawing.Point(13, 43);
            this.btnMegtekint.Name = "btnMegtekint";
            this.btnMegtekint.Size = new System.Drawing.Size(120, 23);
            this.btnMegtekint.TabIndex = 1;
            this.btnMegtekint.Text = "Megtekint";
            this.btnMegtekint.UseVisualStyleBackColor = true;
            this.btnMegtekint.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(13, 72);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(120, 23);
            this.btnModosit.TabIndex = 2;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(13, 101);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(120, 23);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.statusText);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(0, 521);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(853, 19);
            this.statusPanel.TabIndex = 3;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(12, 3);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 13);
            this.statusText.TabIndex = 0;
            this.statusText.Text = "label1";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.flowLayoutPanel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(853, 125);
            this.searchPanel.TabIndex = 4;
            this.searchPanel.TabStop = false;
            this.searchPanel.Text = "Keresés";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.pnlKeresDatum);
            this.flowLayoutPanel1.Controls.Add(this.keresControlPnl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTipKimeno);
            this.groupBox1.Controls.Add(this.rbTipBejovo);
            this.groupBox1.Controls.Add(this.rbTipOsszes);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Számla típusa";
            // 
            // rbTipKimeno
            // 
            this.rbTipKimeno.AutoSize = true;
            this.rbTipKimeno.Location = new System.Drawing.Point(6, 58);
            this.rbTipKimeno.Name = "rbTipKimeno";
            this.rbTipKimeno.Size = new System.Drawing.Size(60, 17);
            this.rbTipKimeno.TabIndex = 2;
            this.rbTipKimeno.TabStop = true;
            this.rbTipKimeno.Text = "Kimenő";
            this.rbTipKimeno.UseVisualStyleBackColor = true;
            // 
            // rbTipBejovo
            // 
            this.rbTipBejovo.AutoSize = true;
            this.rbTipBejovo.Location = new System.Drawing.Point(6, 38);
            this.rbTipBejovo.Name = "rbTipBejovo";
            this.rbTipBejovo.Size = new System.Drawing.Size(58, 17);
            this.rbTipBejovo.TabIndex = 1;
            this.rbTipBejovo.TabStop = true;
            this.rbTipBejovo.Text = "Bejövő";
            this.rbTipBejovo.UseVisualStyleBackColor = true;
            // 
            // rbTipOsszes
            // 
            this.rbTipOsszes.AutoSize = true;
            this.rbTipOsszes.Location = new System.Drawing.Point(6, 19);
            this.rbTipOsszes.Name = "rbTipOsszes";
            this.rbTipOsszes.Size = new System.Drawing.Size(59, 17);
            this.rbTipOsszes.TabIndex = 0;
            this.rbTipOsszes.TabStop = true;
            this.rbTipOsszes.Text = "Összes";
            this.rbTipOsszes.UseVisualStyleBackColor = true;
            this.rbTipOsszes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pnlKeresDatum
            // 
            this.pnlKeresDatum.Controls.Add(this.flowLayoutPanel3);
            this.pnlKeresDatum.Location = new System.Drawing.Point(116, 3);
            this.pnlKeresDatum.Name = "pnlKeresDatum";
            this.pnlKeresDatum.Size = new System.Drawing.Size(176, 103);
            this.pnlKeresDatum.TabIndex = 2;
            this.pnlKeresDatum.TabStop = false;
            this.pnlKeresDatum.Text = "Keletkezés dátuma";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.dtStart);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.dtEnd);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(170, 84);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kezdete";
            // 
            // dtStart
            // 
            this.dtStart.Checked = false;
            this.dtStart.Location = new System.Drawing.Point(3, 16);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowCheckBox = true;
            this.dtStart.Size = new System.Drawing.Size(164, 20);
            this.dtStart.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vége";
            // 
            // dtEnd
            // 
            this.dtEnd.Checked = false;
            this.dtEnd.Location = new System.Drawing.Point(3, 55);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowCheckBox = true;
            this.dtEnd.Size = new System.Drawing.Size(161, 20);
            this.dtEnd.TabIndex = 3;
            // 
            // keresControlPnl
            // 
            this.keresControlPnl.Controls.Add(this.btnKeres);
            this.keresControlPnl.Controls.Add(this.btnClear);
            this.keresControlPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.keresControlPnl.Location = new System.Drawing.Point(298, 3);
            this.keresControlPnl.Name = "keresControlPnl";
            this.keresControlPnl.Size = new System.Drawing.Size(118, 100);
            this.keresControlPnl.TabIndex = 0;
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(3, 3);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(110, 23);
            this.btnKeres.TabIndex = 0;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Keresés törlése";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SzamlaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(853, 540);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.statusPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SzamlaLista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlKeresDatum.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.keresControlPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMegtekint;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.GroupBox searchPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTipKimeno;
        private System.Windows.Forms.RadioButton rbTipBejovo;
        private System.Windows.Forms.RadioButton rbTipOsszes;
        private System.Windows.Forms.FlowLayoutPanel keresControlPnl;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox pnlKeresDatum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn letrehozva;
        private System.Windows.Forms.DataGridViewTextBoxColumn teljesites_datuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn cegnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceg_cime;
        private System.Windows.Forms.DataGridViewTextBoxColumn teljesitve;
    }
}