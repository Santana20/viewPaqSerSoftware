namespace viewPaqSerSoftware.Forms
{
    partial class FormSales
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
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.lblnameClient = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaleDetails = new System.Windows.Forms.Label();
            this.btnUpdateDS = new System.Windows.Forms.Button();
            this.btnDeleteDS = new System.Windows.Forms.Button();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.btnAddDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(171, 19);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(520, 22);
            this.txtNameClient.TabIndex = 0;
            // 
            // lblnameClient
            // 
            this.lblnameClient.AutoSize = true;
            this.lblnameClient.Location = new System.Drawing.Point(37, 22);
            this.lblnameClient.Name = "lblnameClient";
            this.lblnameClient.Size = new System.Drawing.Size(128, 17);
            this.lblnameClient.TabIndex = 1;
            this.lblnameClient.Text = "Nombre del Cliente";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToOrderColumns = true;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.description,
            this.priceUnit,
            this.saleCount,
            this.subTotal});
            this.dgvCart.Location = new System.Drawing.Point(40, 172);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(777, 336);
            this.dgvCart.TabIndex = 2;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "idProduct";
            this.idProduct.HeaderText = "Codigo";
            this.idProduct.MinimumWidth = 6;
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Descripcion";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // priceUnit
            // 
            this.priceUnit.DataPropertyName = "priceUnit";
            this.priceUnit.HeaderText = "Precio Unitario";
            this.priceUnit.MinimumWidth = 6;
            this.priceUnit.Name = "priceUnit";
            this.priceUnit.ReadOnly = true;
            // 
            // saleCount
            // 
            this.saleCount.DataPropertyName = "saleCount";
            this.saleCount.HeaderText = "Cantidad";
            this.saleCount.MinimumWidth = 6;
            this.saleCount.Name = "saleCount";
            this.saleCount.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // lblSaleDetails
            // 
            this.lblSaleDetails.AutoSize = true;
            this.lblSaleDetails.Location = new System.Drawing.Point(37, 137);
            this.lblSaleDetails.Name = "lblSaleDetails";
            this.lblSaleDetails.Size = new System.Drawing.Size(111, 17);
            this.lblSaleDetails.TabIndex = 3;
            this.lblSaleDetails.Text = "Detalle de venta";
            // 
            // btnUpdateDS
            // 
            this.btnUpdateDS.Location = new System.Drawing.Point(580, 108);
            this.btnUpdateDS.Name = "btnUpdateDS";
            this.btnUpdateDS.Size = new System.Drawing.Size(111, 46);
            this.btnUpdateDS.TabIndex = 5;
            this.btnUpdateDS.Text = "Modificar Cantidad";
            this.btnUpdateDS.UseVisualStyleBackColor = true;
            this.btnUpdateDS.Click += new System.EventHandler(this.btnUpdateDS_Click);
            // 
            // btnDeleteDS
            // 
            this.btnDeleteDS.Location = new System.Drawing.Point(706, 108);
            this.btnDeleteDS.Name = "btnDeleteDS";
            this.btnDeleteDS.Size = new System.Drawing.Size(111, 46);
            this.btnDeleteDS.TabIndex = 6;
            this.btnDeleteDS.Text = "Quitar";
            this.btnDeleteDS.UseVisualStyleBackColor = true;
            this.btnDeleteDS.Click += new System.EventHandler(this.btnDeleteDS_Click);
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Location = new System.Drawing.Point(706, 9);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(111, 42);
            this.btnRegisterSale.TabIndex = 7;
            this.btnRegisterSale.Text = "Realizar Venta";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.btnRegisterSale_Click);
            // 
            // btnAddDS
            // 
            this.btnAddDS.Location = new System.Drawing.Point(452, 108);
            this.btnAddDS.Name = "btnAddDS";
            this.btnAddDS.Size = new System.Drawing.Size(111, 46);
            this.btnAddDS.TabIndex = 4;
            this.btnAddDS.Text = "Agregar";
            this.btnAddDS.UseVisualStyleBackColor = true;
            this.btnAddDS.Click += new System.EventHandler(this.btnAddDS_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 520);
            this.Controls.Add(this.btnRegisterSale);
            this.Controls.Add(this.btnDeleteDS);
            this.Controls.Add(this.btnUpdateDS);
            this.Controls.Add(this.btnAddDS);
            this.Controls.Add(this.lblSaleDetails);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblnameClient);
            this.Controls.Add(this.txtNameClient);
            this.Name = "FormSales";
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lblnameClient;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblSaleDetails;
        private System.Windows.Forms.Button btnUpdateDS;
        private System.Windows.Forms.Button btnDeleteDS;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Button btnAddDS;
    }
}