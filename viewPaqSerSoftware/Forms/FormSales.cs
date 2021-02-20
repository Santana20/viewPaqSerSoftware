using Entities;
using RestService;
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
    public partial class FormSales : Form
    {
        public Cart carrito { get; set; }
        public FormSales()
        {
            InitializeComponent();
            this.dgvCart.AutoGenerateColumns = false;
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            this.dgvCart.DataSource = this.carrito.getCartList();
        }

        private void btnUpdateDS_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCart.SelectedRows.Count > 1)
                    throw new ArgumentException("Debe seleccionar solo una fila para editar.");
                if (this.dgvCart.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar una fila para editar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDS_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                FormInformation formInformation = new FormInformation("¿ESTAS SEGURO DE ELIMINAR EL REGISTRO?");
                result = formInformation.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CartItem detailProduct =  (CartItem)(this.dgvCart.CurrentRow.DataBoundItem);
                    this.carrito.DeleteCartItem(detailProduct.idDetailProduct);
                    this.dgvCart.DataSource = this.carrito.getCartList();
                    FormSuccess.confirmationForm("ELIMINADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
