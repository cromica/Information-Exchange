﻿namespace InformationExchange.OrderManagementSouthAmerica
{
    partial class OrderManagement
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
			this.gvOrders = new System.Windows.Forms.DataGridView();
			this.groupBoxOrders = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
			this.groupBoxOrders.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gvOrders
			// 
			this.gvOrders.AllowUserToAddRows = false;
			this.gvOrders.AllowUserToDeleteRows = false;
			this.gvOrders.AutoGenerateColumns = false;
			this.gvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.Country,
            this.User});
			this.gvOrders.DataSource = this.orderBindingSource;
			this.gvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvOrders.Location = new System.Drawing.Point(3, 16);
			this.gvOrders.Name = "gvOrders";
			this.gvOrders.ReadOnly = true;
			this.gvOrders.RowTemplate.ReadOnly = true;
			this.gvOrders.Size = new System.Drawing.Size(923, 423);
			this.gvOrders.TabIndex = 0;
			// 
			// groupBoxOrders
			// 
			this.groupBoxOrders.Controls.Add(this.gvOrders);
			this.groupBoxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOrders.Location = new System.Drawing.Point(0, 0);
			this.groupBoxOrders.Name = "groupBoxOrders";
			this.groupBoxOrders.Size = new System.Drawing.Size(929, 442);
			this.groupBoxOrders.TabIndex = 5;
			this.groupBoxOrders.TabStop = false;
			this.groupBoxOrders.Text = "Orders";
			// 
			// btnAdd
			// 
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAdd.Location = new System.Drawing.Point(779, 0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 29);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnRemove.Location = new System.Drawing.Point(854, 0);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 29);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.btnAdd);
			this.pnlButtons.Controls.Add(this.btnRemove);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtons.Location = new System.Drawing.Point(0, 442);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(929, 29);
			this.pnlButtons.TabIndex = 6;
			// 
			// dataGridViewComboBoxColumn1
			// 
			this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewComboBoxColumn1.DataPropertyName = "Country";
			this.dataGridViewComboBoxColumn1.HeaderText = "Country";
			this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
			this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewComboBoxColumn2
			// 
			this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewComboBoxColumn2.DataPropertyName = "Country";
			this.dataGridViewComboBoxColumn2.HeaderText = "Country";
			this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
			this.dataGridViewComboBoxColumn2.ReadOnly = true;
			this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.AllowNew = false;
			this.orderBindingSource.DataSource = typeof(InformationExchange.OrderManagementSouthAmerica.DataAccess.Order);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// itemsDataGridViewTextBoxColumn
			// 
			this.itemsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
			this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
			this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
			this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// valueDataGridViewTextBoxColumn
			// 
			this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			this.valueDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Country
			// 
			this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Country.DataPropertyName = "Country";
			this.Country.HeaderText = "Country";
			this.Country.Name = "Country";
			this.Country.ReadOnly = true;
			this.Country.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// User
			// 
			this.User.DataPropertyName = "User";
			this.User.HeaderText = "User";
			this.User.Name = "User";
			this.User.ReadOnly = true;
			// 
			// OrderManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 471);
			this.Controls.Add(this.groupBoxOrders);
			this.Controls.Add(this.pnlButtons);
			this.Name = "OrderManagement";
			this.Text = "Order Management South America";
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
			this.groupBoxOrders.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
		private System.Windows.Forms.DataGridViewTextBoxColumn User;
    }
}

