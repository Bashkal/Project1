namespace WindowsFormsAppAdoNet
{
    partial class Form2
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
            this.dgvCatagories = new System.Windows.Forms.DataGridView();
            this.gbCatagory = new System.Windows.Forms.GroupBox();
            this.txtCatagory = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).BeginInit();
            this.gbCatagory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCatagories
            // 
            this.dgvCatagories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatagories.Location = new System.Drawing.Point(397, 12);
            this.dgvCatagories.Name = "dgvCatagories";
            this.dgvCatagories.RowHeadersWidth = 51;
            this.dgvCatagories.RowTemplate.Height = 24;
            this.dgvCatagories.Size = new System.Drawing.Size(391, 426);
            this.dgvCatagories.TabIndex = 0;
            this.dgvCatagories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatagories_CellClick);
            this.dgvCatagories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatagories_CellContentClick);
            // 
            // gbCatagory
            // 
            this.gbCatagory.Controls.Add(this.btnUpd);
            this.gbCatagory.Controls.Add(this.btnDelete);
            this.gbCatagory.Controls.Add(this.btnAdd);
            this.gbCatagory.Controls.Add(this.txtCatagory);
            this.gbCatagory.Controls.Add(this.lblCatName);
            this.gbCatagory.Controls.Add(this.lblId);
            this.gbCatagory.Location = new System.Drawing.Point(13, 13);
            this.gbCatagory.Name = "gbCatagory";
            this.gbCatagory.Size = new System.Drawing.Size(378, 425);
            this.gbCatagory.TabIndex = 1;
            this.gbCatagory.TabStop = false;
            this.gbCatagory.Text = "Kategori Yönetimi";
            // 
            // txtCatagory
            // 
            this.txtCatagory.Location = new System.Drawing.Point(123, 53);
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.Size = new System.Drawing.Size(100, 22);
            this.txtCatagory.TabIndex = 2;
            this.txtCatagory.TextChanged += new System.EventHandler(this.txtCatagory_TextChanged);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(133, 34);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(80, 16);
            this.lblCatName.TabIndex = 1;
            this.lblCatName.Text = "Kategori Adı";
            this.lblCatName.Click += new System.EventHandler(this.lblCatName_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(164, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(14, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(148, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(267, 92);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 5;
            this.btnUpd.Text = "Güncelle";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCatagory);
            this.Controls.Add(this.dgvCatagories);
            this.Name = "Form2";
            this.Text = "Kategori Yönetimi";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatagories)).EndInit();
            this.gbCatagory.ResumeLayout(false);
            this.gbCatagory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatagories;
        private System.Windows.Forms.GroupBox gbCatagory;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCatagory;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}