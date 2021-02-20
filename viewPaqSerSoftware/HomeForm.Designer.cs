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
            this.btnMenuSales = new System.Windows.Forms.Button();
            this.btnMenuProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMenuSales);
            this.panelMenu.Controls.Add(this.btnMenuProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(199, 753);
            this.panelMenu.TabIndex = 1;
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
            this.btnMenuSales.Location = new System.Drawing.Point(0, 134);
            this.btnMenuSales.Name = "btnMenuSales";
            this.btnMenuSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMenuSales.Size = new System.Drawing.Size(199, 65);
            this.btnMenuSales.TabIndex = 1;
            this.btnMenuSales.Text = "Ventas";
            this.btnMenuSales.UseVisualStyleBackColor = true;
            this.btnMenuSales.Click += new System.EventHandler(this.btnMenuSales_Click);
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
            this.btnMenuProducts.Size = new System.Drawing.Size(199, 60);
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
            this.panelLogo.Size = new System.Drawing.Size(199, 74);
            this.panelLogo.TabIndex = 3;
            // 
            // lblLogoName
            // 
            this.lblLogoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoName.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogoName.Location = new System.Drawing.Point(27, 24);
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
            this.panelTitleBar.Location = new System.Drawing.Point(199, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(983, 74);
            this.panelTitleBar.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Snow;
            this.btnCloseChildForm.Location = new System.Drawing.Point(901, 0);
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
            this.lblTitleBar.Location = new System.Drawing.Point(436, 24);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(96, 32);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "HOME";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Controls.Add(this.panelMenu);
            this.panelDesktop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1182, 753);
            this.panelDesktop.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelDesktop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuProducts;
        private System.Windows.Forms.Button btnMenuSales;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogoName;
    }
}