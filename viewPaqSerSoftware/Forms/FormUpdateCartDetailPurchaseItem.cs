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
    public partial class FormUpdateCartDetailPurchaseItem : Form
    {
        public decimal quantity { get; set; }
        public decimal unitPrice { get; set; }
        public FormUpdateCartDetailPurchaseItem(string message, decimal quantity = 0m, decimal unitPrice = 0m)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.txtQuantity.Text = this.quantity.ToString();
            this.txtUnitPrice.Text = this.unitPrice.ToString();
            this.txtQuantity.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtQuantity.TextLength + this.txtUnitPrice.TextLength >= 15)
                    throw new Exception("Los numeros no pueden ser muy grandes");
                
                quantity = Convert.ToDecimal(this.txtQuantity.Text);
                unitPrice = Convert.ToDecimal(this.txtUnitPrice.Text);
                if (quantity < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa");
                if (unitPrice < 0)
                    throw new ArgumentException("El precio unitario no puede ser negativo");

                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
