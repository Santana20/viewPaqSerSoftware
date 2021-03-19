using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewPaqSerSoftware.Forms
{
    public partial class FormViewMaintainDetailProduct : Form
    {
        private DetailProduct detailProduct;
        public FormViewMaintainDetailProduct(DetailProduct paramDetailproduct = null)
        {
            InitializeComponent();
            
            if (paramDetailproduct == null)
            {
                this.detailProduct = new DetailProduct();
                this.txtStock.Text = "0";
                this.txtSalePrice.Text = "0";

                this.lblStock.Text += " Inicial";
            }
            else
            {
                this.detailProduct = paramDetailproduct;
                this.txtNetContent.Text = this.detailProduct.netContent;
                this.txtSalePrice.Text = this.detailProduct.salePrice.ToString();
                this.txtSaleUnit.Text = this.detailProduct.saleUnit;
                this.txtStock.Text = this.detailProduct.stock.ToString();
            }
            this.lblStock.Text += ":";
            this.txtNetContent.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.detailProduct.netContent = this.txtNetContent.Text;
                this.detailProduct.stock = Convert.ToDecimal(this.txtStock.Text);
                this.detailProduct.salePrice = Convert.ToDecimal(this.txtSalePrice.Text);
                this.detailProduct.saleUnit = this.txtSaleUnit.Text;

                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DetailProduct GetDetailProduct() { return this.detailProduct; }
    }
}
