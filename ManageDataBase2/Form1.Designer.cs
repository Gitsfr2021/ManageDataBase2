
namespace ManageDataBase2
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
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.cmbDB = new System.Windows.Forms.ComboBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.lblDbName = new System.Windows.Forms.Label();
            this.pnlCreateDB = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdTable = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chkAllowNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCreateDB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(337, 25);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(133, 23);
            this.btnCreateDB.TabIndex = 0;
            this.btnCreateDB.Text = "Create";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(338, 28);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(140, 23);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // cmbDB
            // 
            this.cmbDB.FormattingEnabled = true;
            this.cmbDB.Location = new System.Drawing.Point(148, 27);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new System.Drawing.Size(158, 24);
            this.cmbDB.TabIndex = 2;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(148, 25);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(158, 22);
            this.txtDbName.TabIndex = 3;
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Location = new System.Drawing.Point(12, 25);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(101, 17);
            this.lblDbName.TabIndex = 4;
            this.lblDbName.Text = "DataBase Title";
            // 
            // pnlCreateDB
            // 
            this.pnlCreateDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCreateDB.Controls.Add(this.btnCreateDB);
            this.pnlCreateDB.Controls.Add(this.lblDbName);
            this.pnlCreateDB.Controls.Add(this.txtDbName);
            this.pnlCreateDB.Location = new System.Drawing.Point(34, 21);
            this.pnlCreateDB.Name = "pnlCreateDB";
            this.pnlCreateDB.Size = new System.Drawing.Size(804, 130);
            this.pnlCreateDB.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grdTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDB);
            this.panel1.Controls.Add(this.btnCreateTable);
            this.panel1.Location = new System.Drawing.Point(34, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 243);
            this.panel1.TabIndex = 6;
            // 
            // grdTable
            // 
            this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTitle,
            this.cmbType,
            this.chkAllowNull});
            this.grdTable.Location = new System.Drawing.Point(15, 73);
            this.grdTable.Name = "grdTable";
            this.grdTable.RowHeadersWidth = 51;
            this.grdTable.RowTemplate.Height = 24;
            this.grdTable.Size = new System.Drawing.Size(601, 150);
            this.grdTable.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.HeaderText = "Title";
            this.txtTitle.MinimumWidth = 6;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Width = 125;
            // 
            // cmbType
            // 
            this.cmbType.DisplayStyleForCurrentCellOnly = true;
            this.cmbType.HeaderText = "Type";
            this.cmbType.Items.AddRange(new object[] {
            "int",
            "bigint",
            "bit",
            "char(10)",
            "datetime",
            "nvarchar(500)"});
            this.cmbType.MinimumWidth = 6;
            this.cmbType.Name = "cmbType";
            this.cmbType.Width = 125;
            // 
            // chkAllowNull
            // 
            this.chkAllowNull.HeaderText = "Allow Null";
            this.chkAllowNull.MinimumWidth = 6;
            this.chkAllowNull.Name = "chkAllowNull";
            this.chkAllowNull.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose DataBase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCreateDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCreateDB.ResumeLayout(false);
            this.pnlCreateDB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Panel pnlCreateDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAllowNull;
    }
}

