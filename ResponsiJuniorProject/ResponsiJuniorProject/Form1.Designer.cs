namespace ResponsiJuniorProject
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
            lblNama = new Label();
            lblDepartemen = new Label();
            tbNama = new TextBox();
            cbDepartemen = new ComboBox();
            listBox = new ListBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgvData = new DataGridView();
            btnLoadData = new Button();
            cbJabatan = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(41, 96);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(96, 15);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Karyawan:";
            // 
            // lblDepartemen
            // 
            lblDepartemen.AutoSize = true;
            lblDepartemen.Location = new Point(41, 134);
            lblDepartemen.Name = "lblDepartemen";
            lblDepartemen.Size = new Size(88, 15);
            lblDepartemen.TabIndex = 1;
            lblDepartemen.Text = "Dep. Karyawan:";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(143, 93);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(140, 23);
            tbNama.TabIndex = 2;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbDepartemen.Location = new Point(143, 131);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(140, 23);
            cbDepartemen.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Items.AddRange(new object[] { "ID Departemen:", "1 : HR", "2 : Engineer", "3 : Developer", "4 : Product M", "5 : Finance" });
            listBox.Location = new Point(385, 98);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 94);
            listBox.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(41, 214);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 28);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(529, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(298, 214);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 28);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(43, 248);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(601, 150);
            dgvData.TabIndex = 8;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(529, 413);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(115, 28);
            btnLoadData.TabIndex = 9;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbJabatan.Location = new Point(143, 169);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(140, 23);
            cbJabatan.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 172);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 10;
            label1.Text = "Jabatan:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Jabatan:", "1 : General Manager", "2 : Manager", "3 : Supervisor", "4 : Karyawan" });
            listBox1.Location = new Point(524, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 525);
            Controls.Add(listBox1);
            Controls.Add(cbJabatan);
            Controls.Add(label1);
            Controls.Add(btnLoadData);
            Controls.Add(dgvData);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(listBox);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNama);
            Controls.Add(lblDepartemen);
            Controls.Add(lblNama);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblDepartemen;
        private TextBox tbNama;
        private ComboBox cbDepartemen;
        private ListBox listBox;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgvData;
        private Button btnLoadData;
        private ComboBox cbJabatan;
        private Label label1;
        private ListBox listBox1;
    }
}