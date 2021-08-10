namespace WindowsFormsApp5
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
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSV
            // 
            this.dgvSV.AllowUserToAddRows = false;
            this.dgvSV.AllowUserToDeleteRows = false;
            this.dgvSV.AllowUserToResizeColumns = false;
            this.dgvSV.AllowUserToResizeRows = false;
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(12, 71);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.ReadOnly = true;
            this.dgvSV.RowHeadersWidth = 51;
            this.dgvSV.RowTemplate.Height = 24;
            this.dgvSV.Size = new System.Drawing.Size(1002, 364);
            this.dgvSV.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(163, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 55);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(314, 455);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(145, 55);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(465, 455);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 55);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(680, 455);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 55);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "MSSV up",
            "MSSV down",
            "Name up",
            "Name down"});
            this.cbbSort.Location = new System.Drawing.Point(845, 471);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(169, 24);
            this.cbbSort.TabIndex = 6;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(163, 26);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(169, 24);
            this.cbbLSH.TabIndex = 7;
            this.cbbLSH.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lớp sinh hoạt :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(869, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 55);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(671, 26);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(192, 22);
            this.txbSearch.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 522);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSV);
            this.Name = "Form1";
            this.Text = "TTSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}

