namespace WindowsFormsAppEFCodeFirst
{
    partial class CategoryControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Yönetimi";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 85);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Kategori Adı";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(163, 79);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(65, 149);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 3;
            this.btnUpd.Text = "Güncelle";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(160, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(11, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori No";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(407, 57);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.Size = new System.Drawing.Size(381, 381);
            this.dgvCategories.TabIndex = 2;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(407, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(381, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCategories);
            this.Name = "CategoryControl";
            this.Text = "CategoryControl";
            this.Load += new System.EventHandler(this.CategoryControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtSearch;
    }
}