namespace viewPaqSerSoftware.Forms
{
    partial class FormRegisterPurchase
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
            this.btnRegisterPurchase = new System.Windows.Forms.Button();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.dgvDPurchase = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitlePurchaseValue = new System.Windows.Forms.Label();
            this.lblTitleIGV = new System.Windows.Forms.Label();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            this.btnDeleteDPu = new System.Windows.Forms.Button();
            this.btnUpdateDPu = new System.Windows.Forms.Button();
            this.btnAddDPu = new System.Windows.Forms.Button();
            this.lblPurchaseDetails = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.lblIGVValue = new System.Windows.Forms.Label();
            this.lblTotalDPList = new System.Windows.Forms.Label();
            this.pnlAddDProductForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterPurchase
            // 
            this.btnRegisterPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPurchase.Location = new System.Drawing.Point(749, 20);
            this.btnRegisterPurchase.Name = "btnRegisterPurchase";
            this.btnRegisterPurchase.Size = new System.Drawing.Size(136, 42);
            this.btnRegisterPurchase.TabIndex = 10;
            this.btnRegisterPurchase.Text = "Realizar Compra";
            this.btnRegisterPurchase.UseVisualStyleBackColor = true;
            this.btnRegisterPurchase.Click += new System.EventHandler(this.btnRegisterPurchase_Click);
            // 
            // lblRuc
            // 
            this.lblRuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(23, 33);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(41, 17);
            this.lblRuc.TabIndex = 9;
            this.lblRuc.Text = "RUC:";
            // 
            // txtRuc
            // 
            this.txtRuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuc.Location = new System.Drawing.Point(70, 30);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(202, 22);
            this.txtRuc.TabIndex = 8;
            // 
            // dgvDPurchase
            // 
            this.dgvDPurchase.AllowUserToAddRows = false;
            this.dgvDPurchase.AllowUserToDeleteRows = false;
            this.dgvDPurchase.AllowUserToOrderColumns = true;
            this.dgvDPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvDPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDPurchase.ColumnHeadersHeight = 29;
            this.dgvDPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.purchaseUnit,
            this.idProduct,
            this.description,
            this.unitPrice,
            this.subTotal});
            this.dgvDPurchase.Location = new System.Drawing.Point(26, 158);
            this.dgvDPurchase.Name = "dgvDPurchase";
            this.dgvDPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDPurchase.RowHeadersVisible = false;
            this.dgvDPurchase.RowHeadersWidth = 51;
            this.dgvDPurchase.RowTemplate.Height = 24;
            this.dgvDPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDPurchase.Size = new System.Drawing.Size(859, 309);
            this.dgvDPurchase.TabIndex = 21;
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
            // lblTitlePurchaseValue
            // 
            this.lblTitlePurchaseValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitlePurchaseValue.AutoSize = true;
            this.lblTitlePurchaseValue.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePurchaseValue.Location = new System.Drawing.Point(579, 496);
            this.lblTitlePurchaseValue.Name = "lblTitlePurchaseValue";
            this.lblTitlePurchaseValue.Size = new System.Drawing.Size(182, 28);
            this.lblTitlePurchaseValue.TabIndex = 20;
            this.lblTitlePurchaseValue.Text = "Valor de venta:";
            // 
            // lblTitleIGV
            // 
            this.lblTitleIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleIGV.AutoSize = true;
            this.lblTitleIGV.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIGV.Location = new System.Drawing.Point(632, 536);
            this.lblTitleIGV.Name = "lblTitleIGV";
            this.lblTitleIGV.Size = new System.Drawing.Size(127, 28);
            this.lblTitleIGV.TabIndex = 19;
            this.lblTitleIGV.Text = "IGV(18%):";
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTotal.Location = new System.Drawing.Point(682, 576);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(77, 28);
            this.lblTitleTotal.TabIndex = 17;
            this.lblTitleTotal.Text = "Total:";
            // 
            // btnDeleteDPu
            // 
            this.btnDeleteDPu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDPu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDPu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDPu.Location = new System.Drawing.Point(774, 93);
            this.btnDeleteDPu.Name = "btnDeleteDPu";
            this.btnDeleteDPu.Size = new System.Drawing.Size(111, 46);
            this.btnDeleteDPu.TabIndex = 16;
            this.btnDeleteDPu.Text = "Quitar";
            this.btnDeleteDPu.UseVisualStyleBackColor = true;
            this.btnDeleteDPu.Click += new System.EventHandler(this.btnDeleteDPu_Click);
            // 
            // btnUpdateDPu
            // 
            this.btnUpdateDPu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDPu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDPu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDPu.Location = new System.Drawing.Point(648, 93);
            this.btnUpdateDPu.Name = "btnUpdateDPu";
            this.btnUpdateDPu.Size = new System.Drawing.Size(111, 46);
            this.btnUpdateDPu.TabIndex = 15;
            this.btnUpdateDPu.Text = "Modificar Cantidad";
            this.btnUpdateDPu.UseVisualStyleBackColor = true;
            this.btnUpdateDPu.Click += new System.EventHandler(this.btnUpdateDPu_Click);
            // 
            // btnAddDPu
            // 
            this.btnAddDPu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDPu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDPu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDPu.Location = new System.Drawing.Point(520, 93);
            this.btnAddDPu.Name = "btnAddDPu";
            this.btnAddDPu.Size = new System.Drawing.Size(111, 46);
            this.btnAddDPu.TabIndex = 14;
            this.btnAddDPu.Text = "Agregar";
            this.btnAddDPu.UseVisualStyleBackColor = true;
            this.btnAddDPu.Click += new System.EventHandler(this.btnAddDPu_Click);
            // 
            // lblPurchaseDetails
            // 
            this.lblPurchaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurchaseDetails.AutoSize = true;
            this.lblPurchaseDetails.Location = new System.Drawing.Point(23, 122);
            this.lblPurchaseDetails.Name = "lblPurchaseDetails";
            this.lblPurchaseDetails.Size = new System.Drawing.Size(125, 17);
            this.lblPurchaseDetails.TabIndex = 13;
            this.lblPurchaseDetails.Text = "Detalle de Compra";
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotalValue.AutoSize = true;
            this.lblSubTotalValue.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValue.Location = new System.Drawing.Point(834, 497);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubTotalValue.Size = new System.Drawing.Size(56, 28);
            this.lblSubTotalValue.TabIndex = 24;
            this.lblSubTotalValue.Text = "0.00";
            // 
            // lblIGVValue
            // 
            this.lblIGVValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIGVValue.AutoSize = true;
            this.lblIGVValue.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGVValue.Location = new System.Drawing.Point(834, 537);
            this.lblIGVValue.Name = "lblIGVValue";
            this.lblIGVValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIGVValue.Size = new System.Drawing.Size(56, 28);
            this.lblIGVValue.TabIndex = 23;
            this.lblIGVValue.Text = "0.00";
            // 
            // lblTotalDPList
            // 
            this.lblTotalDPList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDPList.AutoSize = true;
            this.lblTotalDPList.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDPList.Location = new System.Drawing.Point(834, 577);
            this.lblTotalDPList.Name = "lblTotalDPList";
            this.lblTotalDPList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalDPList.Size = new System.Drawing.Size(56, 28);
            this.lblTotalDPList.TabIndex = 22;
            this.lblTotalDPList.Text = "0.00";
            // 
            // pnlAddDProductForm
            // 
            this.pnlAddDProductForm.Location = new System.Drawing.Point(33, 507);
            this.pnlAddDProductForm.Name = "pnlAddDProductForm";
            this.pnlAddDProductForm.Size = new System.Drawing.Size(115, 68);
            this.pnlAddDProductForm.TabIndex = 25;
            // 
            // FormRegisterPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 632);
            this.Controls.Add(this.pnlAddDProductForm);
            this.Controls.Add(this.lblSubTotalValue);
            this.Controls.Add(this.lblIGVValue);
            this.Controls.Add(this.lblTotalDPList);
            this.Controls.Add(this.dgvDPurchase);
            this.Controls.Add(this.lblTitlePurchaseValue);
            this.Controls.Add(this.lblTitleIGV);
            this.Controls.Add(this.lblTitleTotal);
            this.Controls.Add(this.btnDeleteDPu);
            this.Controls.Add(this.btnUpdateDPu);
            this.Controls.Add(this.btnAddDPu);
            this.Controls.Add(this.lblPurchaseDetails);
            this.Controls.Add(this.btnRegisterPurchase);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.txtRuc);
            this.Name = "FormRegisterPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterPurchase;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.DataGridView dgvDPurchase;
        private System.Windows.Forms.Label lblTitlePurchaseValue;
        private System.Windows.Forms.Label lblTitleIGV;
        private System.Windows.Forms.Label lblTitleTotal;
        private System.Windows.Forms.Button btnDeleteDPu;
        private System.Windows.Forms.Button btnUpdateDPu;
        private System.Windows.Forms.Button btnAddDPu;
        private System.Windows.Forms.Label lblPurchaseDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblIGVValue;
        private System.Windows.Forms.Label lblTotalDPList;
        private System.Windows.Forms.Panel pnlAddDProductForm;
    }
}