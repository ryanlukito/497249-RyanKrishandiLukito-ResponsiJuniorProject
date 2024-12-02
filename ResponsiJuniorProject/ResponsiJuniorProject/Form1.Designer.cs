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
            listBox.Location = new Point(385, 60);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 94);
            listBox.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(41, 173);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 28);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(390, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(219, 173);
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
            dgvData.Location = new Point(43, 207);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(462, 150);
            dgvData.TabIndex = 8;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(390, 363);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(115, 28);
            btnLoadData.TabIndex = 9;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 407);
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
    }
}