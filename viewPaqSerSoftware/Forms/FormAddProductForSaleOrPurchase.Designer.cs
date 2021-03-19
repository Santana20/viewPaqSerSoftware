namespace viewPaqSerSoftware.Forms
{
    partial class FormAddProductForSaleOrPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProductForSaleOrPurchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbIdBrand = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lbl_idProductType = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_nameProduct = new System.Windows.Forms.Label();
            this.lbl_idProduct = new System.Windows.Forms.Label();
            this.btnAddTo = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // saleUnit
            // 
            this.saleUnit.DataPropertyName = "saleUnit";
            this.saleUnit.HeaderText = "Unidad de Venta";
            this.saleUnit.MinimumWidth = 6;
            this.saleUnit.Name = "saleUnit";
            this.saleUnit.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // netContent
            // 
            this.netContent.DataPropertyName = "netContent";
            this.netContent.HeaderText = "Contenido Neto";
            this.netContent.MinimumWidth = 6;
            this.netContent.Name = "netContent";
            this.netContent.ReadOnly = true;
            // 
            // codProduct
            // 
            this.codProduct.DataPropertyName = "idProduct";
            this.codProduct.HeaderText = "Codigo";
            this.codProduct.MinimumWidth = 6;
            this.codProduct.Name = "codProduct";
            this.codProduct.ReadOnly = true;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToOrderColumns = true;
            this.dgvProductDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProduct,
            this.netContent,
            this.stock,
            this.salePrice,
            this.saleUnit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.NullValue = "(nulo)";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductDetails.EnableHeadersVisualStyles = false;
            this.dgvProductDetails.Location = new System.Drawing.Point(33, 395);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.RowHeadersWidth = 51;
            this.dgvProductDetails.RowTemplate.Height = 24;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(843, 225);
            this.dgvProductDetails.TabIndex = 20;
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "salePrice";
            this.salePrice.HeaderText = "Precio de Venta";
            this.salePrice.MinimumWidth = 6;
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // DetailProduct
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.DetailProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.DetailProduct.Description = "Presentaciones del producto";
            this.DetailProduct.HeaderText = "Ver Presentaciones";
            this.DetailProduct.Image = ((System.Drawing.Image)(resources.GetObject("DetailProduct.Image")));
            this.DetailProduct.MinimumWidth = 6;
            this.DetailProduct.Name = "DetailProduct";
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "nameProductType";
            this.ProductType.HeaderText = "Tipo de Producto";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "nameBrand";
            this.Brand.HeaderText = "Marca";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // nameProduct
            // 
            this.nameProduct.DataPropertyName = "nameProduct";
            this.nameProduct.HeaderText = "Nombre";
            this.nameProduct.MinimumWidth = 6;
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codProduct";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nameProduct,
            this.Brand,
            this.ProductType,
            this.DetailProduct});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.NullValue = "(nulo)";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.Location = new System.Drawing.Point(33, 149);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(841, 234);
            this.dgvProducts.TabIndex = 19;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(35, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 44);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbIdBrand
            // 
            this.cmbIdBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdBrand.FormattingEnabled = true;
            this.cmbIdBrand.Location = new System.Drawing.Point(558, 13);
            this.cmbIdBrand.Name = "cmbIdBrand";
            this.cmbIdBrand.Size = new System.Drawing.Size(168, 24);
            this.cmbIdBrand.TabIndex = 13;
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(558, 52);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(168, 24);
            this.cmbProductType.TabIndex = 15;
            // 
            // lbl_idProductType
            // 
            this.lbl_idProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idProductType.AutoSize = true;
            this.lbl_idProductType.Location = new System.Drawing.Point(410, 54);
            this.lbl_idProductType.Name = "lbl_idProductType";
            this.lbl_idProductType.Size = new System.Drawing.Size(116, 17);
            this.lbl_idProductType.TabIndex = 18;
            this.lbl_idProductType.Text = "Tipo de producto";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(193, 48);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(168, 22);
            this.txtNameProduct.TabIndex = 11;
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(193, 15);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(168, 22);
            this.txtIdProduct.TabIndex = 10;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(410, 17);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(47, 17);
            this.lbl_Brand.TabIndex = 16;
            this.lbl_Brand.Text = "Marca";
            // 
            // lbl_nameProduct
            // 
            this.lbl_nameProduct.AutoSize = true;
            this.lbl_nameProduct.Location = new System.Drawing.Point(37, 53);
            this.lbl_nameProduct.Name = "lbl_nameProduct";
            this.lbl_nameProduct.Size = new System.Drawing.Size(119, 17);
            this.lbl_nameProduct.TabIndex = 14;
            this.lbl_nameProduct.Text = "Nombre Producto";
            // 
            // lbl_idProduct
            // 
            this.lbl_idProduct.AutoSize = true;
            this.lbl_idProduct.Location = new System.Drawing.Point(37, 20);
            this.lbl_idProduct.Name = "lbl_idProduct";
            this.lbl_idProduct.Size = new System.Drawing.Size(113, 17);
            this.lbl_idProduct.TabIndex = 12;
            this.lbl_idProduct.Text = "Codigo Producto";
            // 
            // btnAddTo
            // 
            this.btnAddTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTo.Location = new System.Drawing.Point(193, 88);
            this.btnAddTo.Name = "btnAddTo";
            this.btnAddTo.Size = new System.Drawing.Size(116, 44);
            this.btnAddTo.TabIndex = 21;
            this.btnAddTo.Text = "Agregar a la lista";
            this.btnAddTo.UseVisualStyleBackColor = true;
            this.btnAddTo.Click += new System.EventHandler(this.btnAddTo_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(760, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(116, 44);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Volver";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormAddProductForSaleOrPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(918, 632);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddTo);
            this.Controls.Add(this.dgvProductDetails);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbIdBrand);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lbl_idProductType);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.txtIdProduct);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_nameProduct);
            this.Controls.Add(this.lbl_idProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProductForSaleOrPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar producto a ";
            this.Load += new System.EventHandler(this.FormAddProductForSaleOrPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn saleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn netContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduct;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewImageColumn DetailProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbIdBrand;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lbl_idProductType;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_nameProduct;
        private System.Windows.Forms.Label lbl_idProduct;
        private System.Windows.Forms.Button btnAddTo;
        private System.Windows.Forms.Button btnReturn;
    }
}