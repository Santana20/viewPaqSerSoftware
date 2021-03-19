namespace viewPaqSerSoftware.Forms
{
    partial class FormRegisterSale
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
            this.lblSaleDetails = new System.Windows.Forms.Label();
            this.btnUpdateDS = new System.Windows.Forms.Button();
            this.btnDeleteDS = new System.Windows.Forms.Button();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.btnAddDS = new System.Windows.Forms.Button();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            this.lblTotalCart = new System.Windows.Forms.Label();
            this.lblTitleIGV = new System.Windows.Forms.Label();
            this.lblTitleSaleValue = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.saleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddDProductForm = new System.Windows.Forms.Panel();
            this.lblIGVValue = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameClient
            // 
            this.txtNameClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameClient.Location = new System.Drawing.Point(171, 19);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(602, 22);
            this.txtNameClient.TabIndex = 0;
            // 
            // lblnameClient
            // 
            this.lblnameClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnameClient.AutoSize = true;
            this.lblnameClient.Location = new System.Drawing.Point(37, 22);
            this.lblnameClient.Name = "lblnameClient";
            this.lblnameClient.Size = new System.Drawing.Size(128, 17);
            this.lblnameClient.TabIndex = 1;
            this.lblnameClient.Text = "Nombre del Cliente";
            // 
            // lblSaleDetails
            // 
            this.lblSaleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaleDetails.AutoSize = true;
            this.lblSaleDetails.Location = new System.Drawing.Point(37, 137);
            this.lblSaleDetails.Name = "lblSaleDetails";
            this.lblSaleDetails.Size = new System.Drawing.Size(111, 17);
            this.lblSaleDetails.TabIndex = 3;
            this.lblSaleDetails.Text = "Detalle de venta";
            // 
            // btnUpdateDS
            // 
            this.btnUpdateDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDS.Location = new System.Drawing.Point(662, 108);
            this.btnUpdateDS.Name = "btnUpdateDS";
            this.btnUpdateDS.Size = new System.Drawing.Size(111, 46);
            this.btnUpdateDS.TabIndex = 5;
            this.btnUpdateDS.Text = "Modificar Cantidad";
            this.btnUpdateDS.UseVisualStyleBackColor = true;
            this.btnUpdateDS.Click += new System.EventHandler(this.btnUpdateDS_Click);
            // 
            // btnDeleteDS
            // 
            this.btnDeleteDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDS.Location = new System.Drawing.Point(788, 108);
            this.btnDeleteDS.Name = "btnDeleteDS";
            this.btnDeleteDS.Size = new System.Drawing.Size(111, 46);
            this.btnDeleteDS.TabIndex = 6;
            this.btnDeleteDS.Text = "Quitar";
            this.btnDeleteDS.UseVisualStyleBackColor = true;
            this.btnDeleteDS.Click += new System.EventHandler(this.btnDeleteDS_Click);
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSale.Location = new System.Drawing.Point(788, 9);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(111, 42);
            this.btnRegisterSale.TabIndex = 7;
            this.btnRegisterSale.Text = "Realizar Venta";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.btnRegisterSale_Click);
            // 
            // btnAddDS
            // 
            this.btnAddDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDS.Location = new System.Drawing.Point(534, 108);
            this.btnAddDS.Name = "btnAddDS";
            this.btnAddDS.Size = new System.Drawing.Size(111, 46);
            this.btnAddDS.TabIndex = 4;
            this.btnAddDS.Text = "Agregar";
            this.btnAddDS.UseVisualStyleBackColor = true;
            this.btnAddDS.Click += new System.EventHandler(this.btnAddDS_Click);
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTotal.Location = new System.Drawing.Point(696, 591);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(77, 28);
            this.lblTitleTotal.TabIndex = 8;
            this.lblTitleTotal.Text = "Total:";
            // 
            // lblTotalCart
            // 
            this.lblTotalCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCart.AutoSize = true;
            this.lblTotalCart.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCart.Location = new System.Drawing.Point(835, 591);
            this.lblTotalCart.Name = "lblTotalCart";
            this.lblTotalCart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCart.Size = new System.Drawing.Size(56, 28);
            this.lblTotalCart.TabIndex = 9;
            this.lblTotalCart.Text = "0.00";
            // 
            // lblTitleIGV
            // 
            this.lblTitleIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleIGV.AutoSize = true;
            this.lblTitleIGV.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIGV.Location = new System.Drawing.Point(646, 551);
            this.lblTitleIGV.Name = "lblTitleIGV";
            this.lblTitleIGV.Size = new System.Drawing.Size(127, 28);
            this.lblTitleIGV.TabIndex = 10;
            this.lblTitleIGV.Text = "IGV(18%):";
            // 
            // lblTitleSaleValue
            // 
            this.lblTitleSaleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleSaleValue.AutoSize = true;
            this.lblTitleSaleValue.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSaleValue.Location = new System.Drawing.Point(593, 511);
            this.lblTitleSaleValue.Name = "lblTitleSaleValue";
            this.lblTitleSaleValue.Size = new System.Drawing.Size(182, 28);
            this.lblTitleSaleValue.TabIndex = 11;
            this.lblTitleSaleValue.Text = "Valor de venta:";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToOrderColumns = true;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleCount,
            this.saleUnit,
            this.idProduct,
            this.description,
            this.unitPrice,
            this.subTotal});
            this.dgvCart.Location = new System.Drawing.Point(40, 173);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(859, 309);
            this.dgvCart.TabIndex = 12;
            // 
            // saleCount
            // 
            this.saleCount.DataPropertyName = "count";
            this.saleCount.HeaderText = "Cantidad";
            this.saleCount.MinimumWidth = 6;
            this.saleCount.Name = "saleCount";
            // 
            // saleUnit
            // 
            this.saleUnit.DataPropertyName = "saleUnit";
            this.saleUnit.HeaderText = "Unidad de medida";
            this.saleUnit.MinimumWidth = 6;
            this.saleUnit.Name = "saleUnit";
            this.saleUnit.ReadOnly = true;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "codProduct";
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
            // unitPrice
            // 
            this.unitPrice.DataPropertyName = "unitPrice";
            this.unitPrice.HeaderText = "Precio Unitario";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // pnlAddDProductForm
            // 
            this.pnlAddDProductForm.Location = new System.Drawing.Point(50, 511);
            this.pnlAddDProductForm.Name = "pnlAddDProductForm";
            this.pnlAddDProductForm.Size = new System.Drawing.Size(115, 68);
            this.pnlAddDProductForm.TabIndex = 13;
            // 
            // lblIGVValue
            // 
            this.lblIGVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIGVValue.AutoSize = true;
            this.lblIGVValue.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGVValue.Location = new System.Drawing.Point(835, 551);
            this.lblIGVValue.Name = "lblIGVValue";
            this.lblIGVValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIGVValue.Size = new System.Drawing.Size(56, 28);
            this.lblIGVValue.TabIndex = 14;
            this.lblIGVValue.Text = "0.00";
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotalValue.AutoSize = true;
            this.lblSubTotalValue.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValue.Location = new System.Drawing.Point(835, 511);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubTotalValue.Size = new System.Drawing.Size(56, 28);
            this.lblSubTotalValue.TabIndex = 15;
            this.lblSubTotalValue.Text = "0.00";
            // 
            // FormRegisterSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 679);
            this.Controls.Add(this.pnlAddDProductForm);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblTitleSaleValue);
            this.Controls.Add(this.lblTitleIGV);
            this.Controls.Add(this.lblTitleTotal);
            this.Controls.Add(this.btnRegisterSale);
            this.Controls.Add(this.btnDeleteDS);
            this.Controls.Add(this.btnUpdateDS);
            this.Controls.Add(this.btnAddDS);
            this.Controls.Add(this.lblSaleDetails);
            this.Controls.Add(this.lblnameClient);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.lblSubTotalValue);
            this.Controls.Add(this.lblIGVValue);
            this.Controls.Add(this.lblTotalCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterSale";
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lblnameClient;
        private System.Windows.Forms.Label lblSaleDetails;
        private System.Windows.Forms.Button btnUpdateDS;
        private System.Windows.Forms.Button btnDeleteDS;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.Button btnAddDS;
        private System.Windows.Forms.Label lblTitleTotal;
        private System.Windows.Forms.Label lblTotalCart;
        private System.Windows.Forms.Label lblTitleIGV;
        private System.Windows.Forms.Label lblTitleSaleValue;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Panel pnlAddDProductForm;
        private System.Windows.Forms.Label lblIGVValue;
        private System.Windows.Forms.Label lblSubTotalValue;
    }
}