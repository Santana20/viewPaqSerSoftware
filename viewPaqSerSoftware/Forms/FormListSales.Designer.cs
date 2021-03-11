namespace viewPaqSerSoftware.Forms
{
    partial class FormListSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListSales));
            this.dtpDateSale = new System.Windows.Forms.DateTimePicker();
            this.btnSearchSales = new System.Windows.Forms.Button();
            this.dgvDetailsSale = new System.Windows.Forms.DataGridView();
            this.saleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailSale = new System.Windows.Forms.DataGridViewImageColumn();
            this.PDFView = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnVisualizeSaleInPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateSale
            // 
            this.dtpDateSale.CustomFormat = "dd-MM-yyyy";
            this.dtpDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateSale.Location = new System.Drawing.Point(95, 34);
            this.dtpDateSale.Name = "dtpDateSale";
            this.dtpDateSale.Size = new System.Drawing.Size(134, 22);
            this.dtpDateSale.TabIndex = 0;
            this.dtpDateSale.Value = new System.DateTime(2021, 3, 3, 11, 26, 7, 0);
            // 
            // btnSearchSales
            // 
            this.btnSearchSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchSales.Location = new System.Drawing.Point(289, 22);
            this.btnSearchSales.Name = "btnSearchSales";
            this.btnSearchSales.Size = new System.Drawing.Size(140, 44);
            this.btnSearchSales.TabIndex = 3;
            this.btnSearchSales.Text = "Buscar";
            this.btnSearchSales.UseVisualStyleBackColor = true;
            this.btnSearchSales.Click += new System.EventHandler(this.btnSearchSales_Click);
            // 
            // dgvDetailsSale
            // 
            this.dgvDetailsSale.AllowUserToAddRows = false;
            this.dgvDetailsSale.AllowUserToDeleteRows = false;
            this.dgvDetailsSale.AllowUserToOrderColumns = true;
            this.dgvDetailsSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailsSale.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailsSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetailsSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetailsSale.ColumnHeadersHeight = 29;
            this.dgvDetailsSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleCount,
            this.saleUnit,
            this.idProduct,
            this.description,
            this.unitPrice,
            this.subTotal});
            this.dgvDetailsSale.Location = new System.Drawing.Point(45, 349);
            this.dgvDetailsSale.Name = "dgvDetailsSale";
            this.dgvDetailsSale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetailsSale.RowHeadersVisible = false;
            this.dgvDetailsSale.RowHeadersWidth = 51;
            this.dgvDetailsSale.RowTemplate.Height = 24;
            this.dgvDetailsSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsSale.Size = new System.Drawing.Size(857, 271);
            this.dgvDetailsSale.TabIndex = 4;
            // 
            // saleCount
            // 
            this.saleCount.DataPropertyName = "count";
            this.saleCount.HeaderText = "Cantidad";
            this.saleCount.MinimumWidth = 6;
            this.saleCount.Name = "saleCount";
            this.saleCount.ReadOnly = true;
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
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSale,
            this.nameClient,
            this.dateSale,
            this.total,
            this.DetailSale,
            this.PDFView});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.NullValue = "(nulo)";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSales.Location = new System.Drawing.Point(45, 72);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSales.Size = new System.Drawing.Size(857, 252);
            this.dgvSales.TabIndex = 9;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // idSale
            // 
            this.idSale.DataPropertyName = "idSale";
            this.idSale.HeaderText = "Codigo Venta";
            this.idSale.MinimumWidth = 6;
            this.idSale.Name = "idSale";
            this.idSale.ReadOnly = true;
            // 
            // nameClient
            // 
            this.nameClient.DataPropertyName = "nameClient";
            this.nameClient.HeaderText = "Cliente";
            this.nameClient.MinimumWidth = 6;
            this.nameClient.Name = "nameClient";
            this.nameClient.ReadOnly = true;
            // 
            // dateSale
            // 
            this.dateSale.DataPropertyName = "dateSale";
            this.dateSale.HeaderText = "Fecha de Venta";
            this.dateSale.MinimumWidth = 6;
            this.dateSale.Name = "dateSale";
            this.dateSale.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // DetailSale
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.DetailSale.DefaultCellStyle = dataGridViewCellStyle1;
            this.DetailSale.Description = "Presentaciones del producto";
            this.DetailSale.HeaderText = "Ver Detalles";
            this.DetailSale.Image = ((System.Drawing.Image)(resources.GetObject("DetailSale.Image")));
            this.DetailSale.MinimumWidth = 6;
            this.DetailSale.Name = "DetailSale";
            this.DetailSale.ReadOnly = true;
            // 
            // PDFView
            // 
            this.PDFView.HeaderText = "Ver en PDF";
            this.PDFView.MinimumWidth = 6;
            this.PDFView.Name = "PDFView";
            this.PDFView.ReadOnly = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 17);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Fecha\r\n";
            // 
            // btnVisualizeSaleInPDF
            // 
            this.btnVisualizeSaleInPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizeSaleInPDF.Location = new System.Drawing.Point(472, 25);
            this.btnVisualizeSaleInPDF.Name = "btnVisualizeSaleInPDF";
            this.btnVisualizeSaleInPDF.Size = new System.Drawing.Size(140, 44);
            this.btnVisualizeSaleInPDF.TabIndex = 11;
            this.btnVisualizeSaleInPDF.Text = "Ver en PDF";
            this.btnVisualizeSaleInPDF.UseVisualStyleBackColor = true;
            this.btnVisualizeSaleInPDF.Click += new System.EventHandler(this.btnVisualizeSaleInPDF_Click);
            // 
            // FormListSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 632);
            this.Controls.Add(this.btnVisualizeSaleInPDF);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.dgvDetailsSale);
            this.Controls.Add(this.btnSearchSales);
            this.Controls.Add(this.dtpDateSale);
            this.Name = "FormListSales";
            this.Text = "Listar Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateSale;
        private System.Windows.Forms.Button btnSearchSales;
        private System.Windows.Forms.DataGridView dgvDetailsSale;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnVisualizeSaleInPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn DetailSale;
        private System.Windows.Forms.DataGridViewImageColumn PDFView;
    }
}