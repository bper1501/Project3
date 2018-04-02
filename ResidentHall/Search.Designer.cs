namespace ResidentHall
{
    partial class Search
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
            this.dataGrid_DB = new System.Windows.Forms.DataGridView();
            this.regIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentDbBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.residentHallDataSet5 = new ResidentHall.ResidentHallDataSet5();
            this.residentDbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.residentDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.residentDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.gridBackbtn = new System.Windows.Forms.Button();
            this.residentDbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.residentDbTableAdapter1 = new ResidentHall.ResidentHallDataSet5TableAdapters.ResidentDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentHallDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_DB
            // 
            this.dataGrid_DB.AllowUserToDeleteRows = false;
            this.dataGrid_DB.AutoGenerateColumns = false;
            this.dataGrid_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dormNumDataGridViewTextBoxColumn,
            this.floorRangeDataGridViewTextBoxColumn,
            this.StudentType,
            this.MonthlyFee});
            this.dataGrid_DB.DataSource = this.residentDbBindingSource4;
            this.dataGrid_DB.Location = new System.Drawing.Point(12, 64);
            this.dataGrid_DB.Name = "dataGrid_DB";
            this.dataGrid_DB.RowTemplate.Height = 24;
            this.dataGrid_DB.Size = new System.Drawing.Size(744, 335);
            this.dataGrid_DB.TabIndex = 0;
            // 
            // regIdDataGridViewTextBoxColumn
            // 
            this.regIdDataGridViewTextBoxColumn.DataPropertyName = "RegId";
            this.regIdDataGridViewTextBoxColumn.HeaderText = "RegId";
            this.regIdDataGridViewTextBoxColumn.Name = "regIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dormNumDataGridViewTextBoxColumn
            // 
            this.dormNumDataGridViewTextBoxColumn.DataPropertyName = "DormNum";
            this.dormNumDataGridViewTextBoxColumn.HeaderText = "DormNum";
            this.dormNumDataGridViewTextBoxColumn.Name = "dormNumDataGridViewTextBoxColumn";
            // 
            // floorRangeDataGridViewTextBoxColumn
            // 
            this.floorRangeDataGridViewTextBoxColumn.DataPropertyName = "FloorRange";
            this.floorRangeDataGridViewTextBoxColumn.HeaderText = "FloorRange";
            this.floorRangeDataGridViewTextBoxColumn.Name = "floorRangeDataGridViewTextBoxColumn";
            // 
            // StudentType
            // 
            this.StudentType.DataPropertyName = "StudentType";
            this.StudentType.HeaderText = "StudentType";
            this.StudentType.Name = "StudentType";
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.DataPropertyName = "MonthlyFee";
            this.MonthlyFee.HeaderText = "MonthlyFee";
            this.MonthlyFee.Name = "MonthlyFee";
            // 
            // residentDbBindingSource4
            // 
            this.residentDbBindingSource4.DataMember = "ResidentDb";
            this.residentDbBindingSource4.DataSource = this.residentHallDataSet5;
            // 
            // residentHallDataSet5
            // 
            this.residentHallDataSet5.DataSetName = "ResidentHallDataSet5";
            this.residentHallDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentDbBindingSource2
            // 
            this.residentDbBindingSource2.DataMember = "ResidentDb";
            // 
            // residentDbBindingSource1
            // 
            this.residentDbBindingSource1.DataMember = "ResidentDb";
            // 
            // residentDbBindingSource
            // 
            this.residentDbBindingSource.DataMember = "ResidentDb";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(41, 35);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(416, 22);
            this.tbSearch.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Location = new System.Drawing.Point(463, 35);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Location = new System.Drawing.Point(179, 405);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(107, 34);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // gridBackbtn
            // 
            this.gridBackbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.gridBackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gridBackbtn.Location = new System.Drawing.Point(350, 405);
            this.gridBackbtn.Name = "gridBackbtn";
            this.gridBackbtn.Size = new System.Drawing.Size(107, 34);
            this.gridBackbtn.TabIndex = 4;
            this.gridBackbtn.Text = "Back";
            this.gridBackbtn.UseVisualStyleBackColor = false;
            this.gridBackbtn.Click += new System.EventHandler(this.gridBackbtn_Click);
            // 
            // residentDbBindingSource3
            // 
            this.residentDbBindingSource3.DataMember = "ResidentDb";
            // 
            // residentDbTableAdapter1
            // 
            this.residentDbTableAdapter1.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(772, 475);
            this.Controls.Add(this.gridBackbtn);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGrid_DB);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentHallDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentDbBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       // private ResidentHallDataSet residentHallDataSet;
        private System.Windows.Forms.BindingSource residentDbBindingSource;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button gridBackbtn;
        public System.Windows.Forms.DataGridView dataGrid_DB;
        private System.Windows.Forms.BindingSource residentDbBindingSource1;
        private System.Windows.Forms.BindingSource residentDbBindingSource2;
        private System.Windows.Forms.BindingSource residentDbBindingSource3;
        private ResidentHallDataSet5 residentHallDataSet5;
        private System.Windows.Forms.BindingSource residentDbBindingSource4;
        private ResidentHallDataSet5TableAdapters.ResidentDbTableAdapter residentDbTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyFee;
    }
}