namespace WindowsFormsAppEFCodeFirst
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvGuides = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbChoseDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuides)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGuides
            // 
            this.dgvGuides.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuides.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvGuides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuides.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuides.Location = new System.Drawing.Point(12, 40);
            this.dgvGuides.Name = "dgvGuides";
            this.dgvGuides.RowHeadersWidth = 51;
            this.dgvGuides.RowTemplate.Height = 24;
            this.dgvGuides.Size = new System.Drawing.Size(799, 308);
            this.dgvGuides.TabIndex = 0;
            this.dgvGuides.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuides_CellClick);
            this.dgvGuides.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuides_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kılavuz Yönetimi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboCategory
            // 
            this.comboCategory.DisplayMember = "CategoryName";
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(132, 82);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(651, 24);
            this.comboCategory.TabIndex = 9;
            this.comboCategory.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departman Seç";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kılavuz Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kılavuz Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(651, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(651, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(212, 112);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 1;
            this.btnUpd.Text = "Güncelle";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(618, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cmbChoseDepartment
            // 
            this.cmbChoseDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChoseDepartment.DisplayMember = "CategoryName";
            this.cmbChoseDepartment.FormattingEnabled = true;
            this.cmbChoseDepartment.Location = new System.Drawing.Point(637, 10);
            this.cmbChoseDepartment.Name = "cmbChoseDepartment";
            this.cmbChoseDepartment.Size = new System.Drawing.Size(174, 24);
            this.cmbChoseDepartment.TabIndex = 3;
            this.cmbChoseDepartment.ValueMember = "Id";
            this.cmbChoseDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbChoseDepartment_SelectedIndexChanged);
            this.cmbChoseDepartment.Click += new System.EventHandler(this.cmbChoseDepartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 585);
            this.Controls.Add(this.cmbChoseDepartment);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGuides);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kılavuz Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuides)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuides;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChoseDepartment;
    }
}

