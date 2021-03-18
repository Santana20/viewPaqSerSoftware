namespace viewPaqSerSoftware.Forms
{
    partial class FormListPurchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPurchases));
            this.dtpDatePurchase = new System.Windows.Forms.DateTimePicker();
            this.btnSearchPurchases = new System.Windows.Forms.Button();
            this.dgvDetailsPurchase = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.idPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailPurchase = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatePurchase
            // 
            this.dtpDatePurchase.CustomFormat = "dd-MM-yyyy";
            this.dtpDatePurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePurchase.Location = new System.Drawing.Point(117, 31);
            this.dtpDatePurchase.Name = "dtpDatePurchase";
            this.dtpDatePurchase.Size = new System.Drawing.Size(216, 22);
            this.dtpDatePurchase.TabIndex = 12;
            this.dtpDatePurchase.Value = new System.DateTime(2021, 3, 3, 11, 26, 7, 0);
            // 
            // btnSearchPurchases
            // 
            this.btnSearchPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPurchases.Location = new System.Drawing.Point(769, 20);
            this.btnSearchPurchases.Name = "btnSearchPurchases";
            this.btnSearchPurchases.Size = new System.Drawing.Size(140, 44);
            this.btnSearchPurchases.TabIndex = 13;
            this.btnSearchPurchases.Text = "Buscar";
            this.btnSearchPurchases.UseVisualStyleBackColor = true;
            this.btnSearchPurchases.Click += new System.EventHandler(this.btnSearchPurchases_Click);
            // 
            // dgvDetailsPurchase
            // 
            this.dgvDetailsPurchase.AllowUserToAddRows = false;
            this.dgvDetailsPurchase.AllowUserToDeleteRows = false;
            this.dgvDetailsPurchase.AllowUserToOrderColumns = true;
            this.dgvDetailsPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailsPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetailsPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailsPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetailsPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetailsPurchase.ColumnHeadersHeight = 29;
            this.dgvDetailsPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.purchaseUnit,
            this.codProduct,
            this.description,
            this.unitPrice,
            this.subTotal});
            this.dgvDetailsPurchase.Location = new System.Drawing.Point(52, 349);
            this.dgvDetailsPurchase.Name = "dgvDetailsPurchase";
            this.dgvDetailsPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetailsPurchase.RowHeadersVisible = false;
            this.dgvDetailsPurchase.RowHeadersWidth = 51;
            this.dgvDetailsPurchase.RowTemplate.Height = 24;
            this.dgvDetailsPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsPurchase.Size = new System.Drawing.Size(857, 271);
            this.dgvDetailsPurchase.TabIndex = 14;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Cantidad";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // purchaseUnit
            // 
            this.purchaseUnit.DataPropertyName = "purchaseUnit";
            this.purchaseUnit.HeaderText = "Unidad de medida";
            this.purchaseUnit.MinimumWidth = 6;
            this.purchaseUnit.Name = "purchaseUnit";
            this.purchaseUnit.ReadOnly = true;
            // 
            // codProduct
            // 
            this.codProduct.DataPropertyName = "codProduct";
            this.codProduct.HeaderText = "Codigo";
            this.codProduct.MinimumWidth = 6;
            this.codProduct.Name = "codProduct";
            this.codProduct.ReadOnly = true;
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
            // dgvPurchases
            // 
            this.dgvPurchases.AllowUserToAddRows = false;
            this.dgvPurchases.AllowUserToDeleteRows = false;
            this.dgvPurchases.AllowUserToOrderColumns = true;
            this.dgvPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPurchases.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPurchase,
            this.Ruc,
            this.datePurchase,
            this.total,
            this.DetailPurchase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.NullValue = "(nulo)";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchases.Location = new System.Drawing.Point(52, 78);
            this.dgvPurchases.MultiSelect = false;
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.ReadOnly = true;
            this.dgvPurchases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPurchases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchases.RowHeadersVisible = false;
            this.dgvPurchases.RowHeadersWidth = 51;
            this.dgvPurchases.RowTemplate.Height = 24;
            this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchases.Size = new System.Drawing.Size(857, 252);
            this.dgvPurchases.TabIndex = 15;
            this.dgvPurchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchases_CellContentClick);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(49, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 20);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Fecha:";
            // 
            // idPurchase
            // 
            this.idPurchase.DataPropertyName = "idPurchase";
            this.idPurchase.HeaderText = "Codigo Compra";
            this.idPurchase.MinimumWidth = 6;
            this.idPurchase.Name = "idPurchase";
            this.idPurchase.ReadOnly = true;
            // 
            // Ruc
            // 
            this.Ruc.DataPropertyName = "ruc";
            this.Ruc.HeaderText = "RUC";
            this.Ruc.MinimumWidth = 6;
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            // 
            // datePurchase
            // 
            this.datePurchase.DataPropertyName = "datePurchase";
            this.datePurchase.HeaderText = "Fecha de Compra";
            this.datePurchase.MinimumWidth = 6;
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // DetailPurchase
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.DetailPurchase.DefaultCellStyle = dataGridViewCellStyle1;
            this.DetailPurchase.Description = "Presentaciones del producto";
            this.DetailPurchase.HeaderText = "Ver Detalles";
            this.DetailPurchase.Image = ((System.Drawing.Image)(resources.GetObject("DetailPurchase.Image")));
            this.DetailPurchase.MinimumWidth = 6;
            this.DetailPurchase.Name = "DetailPurchase";
            this.DetailPurchase.ReadOnly = true;
            // 
            // FormListPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 632);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvPurchases);
            this.Controls.Add(this.dgvDetailsPurchase);
            this.Controls.Add(this.btnSearchPurchases);
            this.Controls.Add(this.dtpDatePurchase);
            this.Name = "FormListPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatePurchase;
        private System.Windows.Forms.Button btnSearchPurchases;
        private System.Windows.Forms.DataGridView dgvDetailsPurchase;
        private System.Windows.Forms.DataGridView dgvPurchases;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn DetailPurchase;
    }
}