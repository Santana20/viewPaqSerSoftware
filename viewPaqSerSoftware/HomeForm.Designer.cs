namespace viewPaqSerSoftware
{
    partial class HomeForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlSalesSubMenu = new System.Windows.Forms.Panel();
            this.btnListSales = new System.Windows.Forms.Button();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.btnMenuSales = new System.Windows.Forms.Button();
            this.pnlProductsSubMenu = new System.Windows.Forms.Panel();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnMenuProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnMenuPurchase = new System.Windows.Forms.Button();
            this.pnlPurchaseSubMenu = new System.Windows.Forms.Panel();
            this.btnListPurchases = new System.Windows.Forms.Button();
            this.btnRegisterPurchase = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.pnlSalesSubMenu.SuspendLayout();
            this.pnlProductsSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.pnlPurchaseSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.pnlPurchaseSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuPurchase);
            this.panelMenu.Controls.Add(this.pnlSalesSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuSales);
            this.panelMenu.Controls.Add(this.pnlProductsSubMenu);
            this.panelMenu.Controls.Add(this.btnMenuProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 753);
            this.panelMenu.TabIndex = 1;
            // 
            // pnlSalesSubMenu
            // 
            this.pnlSalesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(99)))));
            this.pnlSalesSubMenu.Controls.Add(this.btnListSales);
            this.pnlSalesSubMenu.Controls.Add(this.btnRegisterSale);
            this.pnlSalesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesSubMenu.Location = new System.Drawing.Point(0, 250);
            this.pnlSalesSubMenu.Name = "pnlSalesSubMenu";
            this.pnlSalesSubMenu.Size = new System.Drawing.Size(246, 101);
            this.pnlSalesSubMenu.TabIndex = 5;
            // 
            // btnListSales
            // 
            this.btnListSales.AutoSize = true;
            this.btnListSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListSales.FlatAppearance.BorderSize = 0;
            this.btnListSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListSales.Location = new System.Drawing.Point(0, 45);
            this.btnListSales.Name = "btnListSales";
            this.btnListSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnListSales.Size = new System.Drawing.Size(246, 50);
            this.btnListSales.TabIndex = 3;
            this.btnListSales.Text = "Listar Ventas";
            this.btnListSales.UseVisualStyleBackColor = true;
            this.btnListSales.Click += new System.EventHandler(this.btnListSales_Click);
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.AutoSize = true;
            this.btnRegisterSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterSale.FlatAppearance.BorderSize = 0;
            this.btnRegisterSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterSale.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterSale.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegisterSale.Size = new System.Drawing.Size(246, 45);
            this.btnRegisterSale.TabIndex = 2;
            this.btnRegisterSale.Text = "Registrar Venta";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.btnRegisterSale_Click);
            // 
            // btnMenuSales
            // 
            this.btnMenuSales.AutoSize = true;
            this.btnMenuSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSales.FlatAppearance.BorderSize = 0;
            this.btnMenuSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSales.Location = new System.Drawing.Point(0, 185);
            this.btnMenuSales.Name = "btnMenuSales";
            this.btnMenuSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuSales.Size = new System.Drawing.Size(246, 65);
            this.btnMenuSales.TabIndex = 1;
            this.btnMenuSales.Text = "Ventas";
            this.btnMenuSales.UseVisualStyleBackColor = true;
            this.btnMenuSales.Click += new System.EventHandler(this.btnMenuSales_Click);
            // 
            // pnlProductsSubMenu
            // 
            this.pnlProductsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(99)))));
            this.pnlProductsSubMenu.Controls.Add(this.btnListProducts);
            this.pnlProductsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductsSubMenu.Location = new System.Drawing.Point(0, 134);
            this.pnlProductsSubMenu.Name = "pnlProductsSubMenu";
            this.pnlProductsSubMenu.Size = new System.Drawing.Size(246, 51);
            this.pnlProductsSubMenu.TabIndex = 4;
            // 
            // btnListProducts
            // 
            this.btnListProducts.AutoSize = true;
            this.btnListProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListProducts.FlatAppearance.BorderSize = 0;
            this.btnListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProducts.Location = new System.Drawing.Point(0, 0);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnListProducts.Size = new System.Drawing.Size(246, 45);
            this.btnListProducts.TabIndex = 2;
            this.btnListProducts.Text = "Listar Productos";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnMenuProducts
            // 
            this.btnMenuProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuProducts.FlatAppearance.BorderSize = 0;
            this.btnMenuProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProducts.Location = new System.Drawing.Point(0, 74);
            this.btnMenuProducts.Name = "btnMenuProducts";
            this.btnMenuProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuProducts.Size = new System.Drawing.Size(246, 60);
            this.btnMenuProducts.TabIndex = 2;
            this.btnMenuProducts.Text = "Productos";
            this.btnMenuProducts.UseVisualStyleBackColor = true;
            this.btnMenuProducts.Click += new System.EventHandler(this.btnMenuProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogoName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(246, 74);
            this.panelLogo.TabIndex = 3;
            // 
            // lblLogoName
            // 
            this.lblLogoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoName.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogoName.Location = new System.Drawing.Point(50, 24);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(195, 29);
            this.lblLogoName.TabIndex = 0;
            this.lblLogoName.Text = "PaqSer Software";
            this.lblLogoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(246, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(936, 74);
            this.panelTitleBar.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Snow;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(82, 74);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.White;
            this.lblTitleBar.Location = new System.Drawing.Point(413, 24);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(96, 32);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "HOME";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDesktop.Location = new System.Drawing.Point(246, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(936, 679);
            this.panelDesktop.TabIndex = 3;
            // 
            // btnMenuPurchase
            // 
            this.btnMenuPurchase.AutoSize = true;
            this.btnMenuPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPurchase.FlatAppearance.BorderSize = 0;
            this.btnMenuPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPurchase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPurchase.Location = new System.Drawing.Point(0, 351);
            this.btnMenuPurchase.Name = "btnMenuPurchase";
            this.btnMenuPurchase.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuPurchase.Size = new System.Drawing.Size(246, 65);
            this.btnMenuPurchase.TabIndex = 6;
            this.btnMenuPurchase.Text = "Compras";
            this.btnMenuPurchase.UseVisualStyleBackColor = true;
            this.btnMenuPurchase.Click += new System.EventHandler(this.btnMenuPurchase_Click);
            // 
            // pnlPurchaseSubMenu
            // 
            this.pnlPurchaseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(99)))));
            this.pnlPurchaseSubMenu.Controls.Add(this.btnListPurchases);
            this.pnlPurchaseSubMenu.Controls.Add(this.btnRegisterPurchase);
            this.pnlPurchaseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPurchaseSubMenu.Location = new System.Drawing.Point(0, 416);
            this.pnlPurchaseSubMenu.Name = "pnlPurchaseSubMenu";
            this.pnlPurchaseSubMenu.Size = new System.Drawing.Size(246, 95);
            this.pnlPurchaseSubMenu.TabIndex = 7;
            // 
            // btnListPurchases
            // 
            this.btnListPurchases.AutoSize = true;
            this.btnListPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListPurchases.FlatAppearance.BorderSize = 0;
            this.btnListPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPurchases.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPurchases.Location = new System.Drawing.Point(0, 45);
            this.btnListPurchases.Name = "btnListPurchases";
            this.btnListPurchases.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnListPurchases.Size = new System.Drawing.Size(246, 45);
            this.btnListPurchases.TabIndex = 3;
            this.btnListPurchases.Text = "Listar Compras";
            this.btnListPurchases.UseVisualStyleBackColor = true;
            this.btnListPurchases.Click += new System.EventHandler(this.btnListPurchases_Click);
            // 
            // btnRegisterPurchase
            // 
            this.btnRegisterPurchase.AutoSize = true;
            this.btnRegisterPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterPurchase.FlatAppearance.BorderSize = 0;
            this.btnRegisterPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPurchase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterPurchase.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterPurchase.Name = "btnRegisterPurchase";
            this.btnRegisterPurchase.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegisterPurchase.Size = new System.Drawing.Size(246, 45);
            this.btnRegisterPurchase.TabIndex = 2;
            this.btnRegisterPurchase.Text = "Registrar Compra";
            this.btnRegisterPurchase.UseVisualStyleBackColor = true;
            this.btnRegisterPurchase.Click += new System.EventHandler(this.btnRegisterPurchase_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.pnlSalesSubMenu.ResumeLayout(false);
            this.pnlSalesSubMenu.PerformLayout();
            this.pnlProductsSubMenu.ResumeLayout(false);
            this.pnlProductsSubMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.pnlPurchaseSubMenu.ResumeLayout(false);
            this.pnlPurchaseSubMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuSales;
        private System.Windows.Forms.Button btnMenuProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogoName;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel pnlProductsSubMenu;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Panel pnlSalesSubMenu;
        private System.Windows.Forms.Button btnListSales;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.Panel pnlPurchaseSubMenu;
        private System.Windows.Forms.Button btnListPurchases;
        private System.Windows.Forms.Button btnRegisterPurchase;
        private System.Windows.Forms.Button btnMenuPurchase;
    }
}