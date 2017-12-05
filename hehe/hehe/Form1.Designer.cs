namespace hehe
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_mo_hinh_3_tangDataSet = new hehe.DB_mo_hinh_3_tangDataSet();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new hehe.DB_mo_hinh_3_tangDataSetTableAdapters.LopTableAdapter();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_mo_hinh_3_tangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.sosvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_mo_hinh_3_tangDataSet
            // 
            this.dB_mo_hinh_3_tangDataSet.DataSetName = "DB_mo_hinh_3_tangDataSet";
            this.dB_mo_hinh_3_tangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.dB_mo_hinh_3_tangDataSet;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Malop";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // tenlopDataGridViewTextBoxColumn
            // 
            this.tenlopDataGridViewTextBoxColumn.DataPropertyName = "Tenlop";
            this.tenlopDataGridViewTextBoxColumn.HeaderText = "Tenlop";
            this.tenlopDataGridViewTextBoxColumn.Name = "tenlopDataGridViewTextBoxColumn";
            // 
            // sosvDataGridViewTextBoxColumn
            // 
            this.sosvDataGridViewTextBoxColumn.DataPropertyName = "Sosv";
            this.sosvDataGridViewTextBoxColumn.HeaderText = "Sosv";
            this.sosvDataGridViewTextBoxColumn.Name = "sosvDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 294);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_mo_hinh_3_tangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_mo_hinh_3_tangDataSet dB_mo_hinh_3_tangDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private DB_mo_hinh_3_tangDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosvDataGridViewTextBoxColumn;
    }
}

