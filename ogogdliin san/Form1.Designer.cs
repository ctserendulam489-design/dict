namespace ogogdliin_san
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblLang = new Label();
            cmbLang = new ComboBox();
            lblDb1 = new Label();
            dgvWords = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colEn = new DataGridViewTextBoxColumn();
            colMn = new DataGridViewTextBoxColumn();
            colRu = new DataGridViewTextBoxColumn();
            lblDb2 = new Label();
            lblSavedHeader = new Label();
            lstSaved = new ListBox();
            lblEmpty = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(68, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(550, 34);
            txtSearch.TabIndex = 1;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Location = new Point(638, 25);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(48, 28);
            lblLang.TabIndex = 2;
            lblLang.Text = "Хэл:";
            // 
            // cmbLang
            // 
            cmbLang.FormattingEnabled = true;
            cmbLang.Location = new Point(735, 16);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(132, 36);
            cmbLang.TabIndex = 3;
            // 
            // lblDb1
            // 
            lblDb1.AutoSize = true;
            lblDb1.Location = new Point(15, 69);
            lblDb1.Name = "lblDb1";
            lblDb1.Size = new Size(140, 28);
            lblDb1.TabIndex = 4;
            lblDb1.Text = "toli.db - words";
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToAddRows = false;
            dgvWords.AllowUserToDeleteRows = false;
            dgvWords.AllowUserToResizeRows = false;
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.BorderStyle = BorderStyle.None;
            dgvWords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNo, colEn, colMn, colRu });
            dgvWords.EnableHeadersVisualStyles = false;
            dgvWords.Location = new Point(33, 121);
            dgvWords.MultiSelect = false;
            dgvWords.Name = "dgvWords";
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 62;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(457, 370);
            dgvWords.TabIndex = 5;
            // 
            // colNo
            // 
            colNo.FillWeight = 30F;
            colNo.HeaderText = "№";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            // 
            // colEn
            // 
            colEn.HeaderText = "Англи";
            colEn.MinimumWidth = 8;
            colEn.Name = "colEn";
            // 
            // colMn
            // 
            colMn.HeaderText = "Монгол";
            colMn.MinimumWidth = 8;
            colMn.Name = "colMn";
            // 
            // colRu
            // 
            colRu.HeaderText = "Орос";
            colRu.MinimumWidth = 8;
            colRu.Name = "colRu";
            // 
            // lblDb2
            // 
            lblDb2.AutoSize = true;
            lblDb2.Location = new Point(500, 62);
            lblDb2.Name = "lblDb2";
            lblDb2.Size = new Size(219, 28);
            lblDb2.TabIndex = 6;
            lblDb2.Text = "saved.db - saved_words";
            // 
            // lblSavedHeader
            // 
            lblSavedHeader.BackColor = Color.FromArgb(198, 230, 184);
            lblSavedHeader.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavedHeader.Location = new Point(500, 90);
            lblSavedHeader.Name = "lblSavedHeader";
            lblSavedHeader.Size = new Size(236, 30);
            lblSavedHeader.TabIndex = 7;
            lblSavedHeader.Text = "Санасан үгс";
            // 
            // lstSaved
            // 
            lstSaved.BorderStyle = BorderStyle.FixedSingle;
            lstSaved.FormattingEnabled = true;
            lstSaved.ItemHeight = 28;
            lstSaved.Location = new Point(500, 170);
            lstSaved.Name = "lstSaved";
            lstSaved.Size = new Size(259, 310);
            lstSaved.TabIndex = 8;
            // 
            // lblEmpty
            // 
            lblEmpty.BackColor = Color.White;
            lblEmpty.Location = new Point(496, 129);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(236, 28);
            lblEmpty.TabIndex = 9;
            lblEmpty.Text = "Хоосон";
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(782, 403);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 550);
            Controls.Add(button1);
            Controls.Add(lblEmpty);
            Controls.Add(lstSaved);
            Controls.Add(lblSavedHeader);
            Controls.Add(lblDb2);
            Controls.Add(dgvWords);
            Controls.Add(lblDb1);
            Controls.Add(cmbLang);
            Controls.Add(lblLang);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(14, 84);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            Load += Form1_Load;
            ParentChanged += Form1_ParentChanged;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblLang;
        private ComboBox cmbLang;
        private Label lblDb1;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colEn;
        private DataGridViewTextBoxColumn colMn;
        private DataGridViewTextBoxColumn colRu;
        private Label lblDb2;
        private Label lblSavedHeader;
        private ListBox lstSaved;
        private Label lblEmpty;
        private Button button1;
    }
}
