namespace viewPaqSerSoftware
{
    partial class FormProductMaintenance
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductMaintenance));
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lbl_idProduct = new System.Windows.Forms.Label();
            this.lbl_nameProduct = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lbl_idProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.cmbIdBrand = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.netContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarDProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.addDetailproduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.Location = new System.Drawing.Point(12, 96);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(119, 44);
            this.btnCreateProduct.TabIndex = 4;
            this.btnCreateProduct.Text = "Registrar Producto";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lbl_idProduct
            // 
            this.lbl_idProduct.AutoSize = true;
            this.lbl_idProduct.Location = new System.Drawing.Point(12, 22);
            this.lbl_idProduct.Name = "lbl_idProduct";
            this.lbl_idProduct.Size = new System.Drawing.Size(117, 17);
            this.lbl_idProduct.TabIndex = 1;
            this.lbl_idProduct.Text = "Codigo Producto:";
            // 
            // lbl_nameProduct
            // 
            this.lbl_nameProduct.AutoSize = true;
            this.lbl_nameProduct.Location = new System.Drawing.Point(12, 55);
            this.lbl_nameProduct.Name = "lbl_nameProduct";
            this.lbl_nameProduct.Size = new System.Drawing.Size(123, 17);
            this.lbl_nameProduct.TabIndex = 2;
            this.lbl_nameProduct.Text = "Nombre Producto:";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(575, 12);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(51, 17);
            this.lbl_Brand.TabIndex = 3;
            this.lbl_Brand.Text = "Marca:";
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(168, 17);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(249, 22);
            this.txtIdProduct.TabIndex = 0;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(168, 50);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(249, 22);
            this.txtNameProduct.TabIndex = 1;
            // 
            // lbl_idProductType
            // 
            this.lbl_idProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idProductType.AutoSize = true;
            this.lbl_idProductType.Location = new System.Drawing.Point(575, 49);
            this.lbl_idProductType.Name = "lbl_idProductType";
            this.lbl_idProductType.Size = new System.Drawing.Size(120, 17);
            this.lbl_idProductType.TabIndex = 7;
            this.lbl_idProductType.Text = "Tipo de producto:";
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(723, 51);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(243, 24);
            this.cmbProductType.TabIndex = 3;
            // 
            // cmbIdBrand
            // 
            this.cmbIdBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdBrand.FormattingEnabled = true;
            this.cmbIdBrand.Location = new System.Drawing.Point(723, 12);
            this.cmbIdBrand.Name = "cmbIdBrand";
            this.cmbIdBrand.Size = new System.Drawing.Size(243, 24);
            this.cmbIdBrand.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(220, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 44);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.DetailProduct,
            this.addDetailproduct,
            this.edit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.NullValue = "(nulo)";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Location = new System.Drawing.Point(12, 155);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProducts.Size = new System.Drawing.Size(954, 256);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.netContent,
            this.stock,
            this.salePrice,
            this.saleUnit,
            this.editarDProduct});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.NullValue = "(nulo)";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductDetails.EnableHeadersVisualStyles = false;
            this.dgvProductDetails.Location = new System.Drawing.Point(12, 433);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductDetails.RowHeadersVisible = false;
            this.dgvProductDetails.RowHeadersWidth = 51;
            this.dgvProductDetails.RowTemplate.Height = 24;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(954, 213);
            this.dgvProductDetails.TabIndex = 9;
            // 
            // netContent
            // 
            this.netContent.DataPropertyName = "netContent";
            this.netContent.HeaderText = "Contenido Neto";
            this.netContent.MinimumWidth = 6;
            this.netContent.Name = "netContent";
            this.netContent.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "salePrice";
            this.salePrice.HeaderText = "Precio de Venta";
            this.salePrice.MinimumWidth = 6;
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // saleUnit
            // 
            this.saleUnit.DataPropertyName = "saleUnit";
            this.saleUnit.HeaderText = "Unidad de Venta";
            this.saleUnit.MinimumWidth = 6;
            this.saleUnit.Name = "saleUnit";
            this.saleUnit.ReadOnly = true;
            // 
            // editarDProduct
            // 
            this.editarDProduct.HeaderText = "Editar";
            this.editarDProduct.Image = ((System.Drawing.Image)(resources.GetObject("editarDProduct.Image")));
            this.editarDProduct.MinimumWidth = 6;
            this.editarDProduct.Name = "editarDProduct";
            this.editarDProduct.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codProduct";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nameProduct
            // 
            this.nameProduct.DataPropertyName = "nameProduct";
            this.nameProduct.HeaderText = "Nombre";
            this.nameProduct.MinimumWidth = 6;
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "nameBrand";
            this.Brand.HeaderText = "Marca";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "nameProductType";
            this.ProductType.HeaderText = "Tipo de Producto";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // DetailProduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.DetailProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.DetailProduct.Description = "Presentaciones del producto";
            this.DetailProduct.HeaderText = "Ver Presentaciones";
            this.DetailProduct.Image = ((System.Drawing.Image)(resources.GetObject("DetailProduct.Image")));
            this.DetailProduct.MinimumWidth = 6;
            this.DetailProduct.Name = "DetailProduct";
            // 
            // addDetailproduct
            // 
            this.addDetailproduct.HeaderText = "Agregar Presentacion";
            this.addDetailproduct.Image = ((System.Drawing.Image)(resources.GetObject("addDetailproduct.Image")));
            this.addDetailproduct.MinimumWidth = 6;
            this.addDetailproduct.Name = "addDetailproduct";
            this.addDetailproduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addDetailproduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // edit
            // 
            this.edit.HeaderText = "Editar";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Visible = false;
            // 
            // FormProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(978, 679);
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
            this.Controls.Add(this.btnCreateProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductMaintenance";
            this.Text = "Listar Productos";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lbl_idProduct;
        private System.Windows.Forms.Label lbl_nameProduct;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lbl_idProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.ComboBox cmbIdBrand;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn netContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleUnit;
        private System.Windows.Forms.DataGridViewImageColumn editarDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewImageColumn DetailProduct;
        private System.Windows.Forms.DataGridViewImageColumn addDetailproduct;
        private System.Windows.Forms.DataGridViewImageColumn edit;
    }
}

