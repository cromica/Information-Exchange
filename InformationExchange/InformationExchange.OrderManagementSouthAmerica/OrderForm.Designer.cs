namespace InformationExchange.OrderManagementSouthAmerica
{
    partial class OrderForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblValue = new System.Windows.Forms.Label();
			this.lblItems = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtItems = new System.Windows.Forms.TextBox();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbCountries = new System.Windows.Forms.ComboBox();
			this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblUser = new System.Windows.Forms.Label();
			this.cbUser = new System.Windows.Forms.ComboBox();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lblCountry, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblValue, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblItems, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtItems, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtValue, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.cbCountries, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.cbUser, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 246);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(3, 120);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(43, 13);
			this.lblCountry.TabIndex = 8;
			this.lblCountry.Text = "Country";
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(3, 80);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(34, 13);
			this.lblValue.TabIndex = 7;
			this.lblValue.Text = "Value";
			// 
			// lblItems
			// 
			this.lblItems.AutoSize = true;
			this.lblItems.Location = new System.Drawing.Point(3, 40);
			this.lblItems.Name = "lblItems";
			this.lblItems.Size = new System.Drawing.Size(32, 13);
			this.lblItems.TabIndex = 6;
			this.lblItems.Text = "Items";
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Location = new System.Drawing.Point(230, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(222, 20);
			this.txtName.TabIndex = 0;
			// 
			// txtItems
			// 
			this.txtItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtItems.Location = new System.Drawing.Point(230, 43);
			this.txtItems.Name = "txtItems";
			this.txtItems.Size = new System.Drawing.Size(222, 20);
			this.txtItems.TabIndex = 1;
			// 
			// txtValue
			// 
			this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtValue.Location = new System.Drawing.Point(230, 83);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(222, 20);
			this.txtValue.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 40);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Name";
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(377, 203);
			this.btnSave.MaximumSize = new System.Drawing.Size(75, 40);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbCountries
			// 
			this.cbCountries.DataSource = this.countryBindingSource;
			this.cbCountries.DisplayMember = "Name";
			this.cbCountries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbCountries.FormattingEnabled = true;
			this.cbCountries.Location = new System.Drawing.Point(230, 123);
			this.cbCountries.Name = "cbCountries";
			this.cbCountries.Size = new System.Drawing.Size(222, 21);
			this.cbCountries.TabIndex = 3;
			this.cbCountries.ValueMember = "Code";
			// 
			// countryBindingSource
			// 
			this.countryBindingSource.AllowNew = false;
			this.countryBindingSource.DataSource = typeof(InformationExchange.OrderManagementSouthAmerica.DataAccess.Country);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(3, 160);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(29, 13);
			this.lblUser.TabIndex = 9;
			this.lblUser.Text = "User";
			// 
			// cbUser
			// 
			this.cbUser.DataSource = this.userBindingSource;
			this.cbUser.DisplayMember = "UserName";
			this.cbUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbUser.FormattingEnabled = true;
			this.cbUser.Location = new System.Drawing.Point(230, 163);
			this.cbUser.Name = "cbUser";
			this.cbUser.Size = new System.Drawing.Size(222, 21);
			this.cbUser.TabIndex = 10;
			this.cbUser.ValueMember = "Id";
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(InformationExchange.OrderManagementSouthAmerica.DataAccess.User);
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 246);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "OrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Order";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.BindingSource countryBindingSource;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ComboBox cbUser;
		private System.Windows.Forms.BindingSource userBindingSource;
    }
}