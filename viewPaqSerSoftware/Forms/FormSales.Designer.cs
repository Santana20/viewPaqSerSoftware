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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSaleDetails = new System.Windows.Forms.Label();
            this.btnAddDS = new System.Windows.Forms.Button();
            this.btnUpdateDS = new System.Windows.Forms.Button();
            this.btnDeleteDS = new System.Windows.Forms.Button();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(168, 47);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(387, 22);
            this.txtNameClient.TabIndex = 0;
            // 
            // lblnameClient
            // 
            this.lblnameClient.AutoSize = true;
            this.lblnameClient.Location = new System.Drawing.Point(37, 47);
            this.lblnameClient.Name = "lblnameClient";
            this.lblnameClient.Size = new System.Drawing.Size(128, 17);
            this.lblnameClient.TabIndex = 1;
            this.lblnameClient.Text = "Nombre del Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 279);
            this.dataGridView1.TabIndex = 2;
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
            // btnAddDS
            // 
            this.btnAddDS.Location = new System.Drawing.Point(307, 108);
            this.btnAddDS.Name = "btnAddDS";
            this.btnAddDS.Size = new System.Drawing.Size(111, 46);
            this.btnAddDS.TabIndex = 4;
            this.btnAddDS.Text = "Agregar";
            this.btnAddDS.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDS
            // 
            this.btnUpdateDS.Location = new System.Drawing.Point(435, 108);
            this.btnUpdateDS.Name = "btnUpdateDS";
            this.btnUpdateDS.Size = new System.Drawing.Size(111, 46);
            this.btnUpdateDS.TabIndex = 5;
            this.btnUpdateDS.Text = "Modificar";
            this.btnUpdateDS.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDS
            // 
            this.btnDeleteDS.Location = new System.Drawing.Point(561, 108);
            this.btnDeleteDS.Name = "btnDeleteDS";
            this.btnDeleteDS.Size = new System.Drawing.Size(111, 46);
            this.btnDeleteDS.TabIndex = 6;
            this.btnDeleteDS.Text = "Quitar";
            this.btnDeleteDS.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Location = new System.Drawing.Point(561, 37);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(111, 42);
            this.btnRegisterSale.TabIndex = 7;
            this.btnRegisterSale.Text = "Realizar Venta";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 482);
            this.Controls.Add(this.btnRegisterSale);
            this.Controls.Add(this.btnDeleteDS);
            this.Controls.Add(this.btnUpdateDS);
            this.Controls.Add(this.btnAddDS);
            this.Controls.Add(this.lblSaleDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblnameClient);
            this.Controls.Add(this.txtNameClient);
            this.Name = "FormSales";
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label lblnameClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSaleDetails;
        private System.Windows.Forms.Button btnAddDS;
        private System.Windows.Forms.Button btnUpdateDS;
        private System.Windows.Forms.Button btnDeleteDS;
        private System.Windows.Forms.Button btnRegisterSale;
    }
}