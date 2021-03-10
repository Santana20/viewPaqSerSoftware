using Entities;
using APIRestService;
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
    public partial class FormRegisterSale : Form
    {
        #region Atributtes
        public Cart carrito { get; set; }
        private BindingList<CartItem> source;
        #endregion
        public FormRegisterSale()
        {
            InitializeComponent();
            this.dgvCart.AutoGenerateColumns = false;
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
            this.source = new BindingList<CartItem>(this.carrito.getList());
            this.dgvCart.DataSource = this.source;
            this.lblTotalCart.Text = Convert.ToString(this.carrito.total);
        }
        private void LoadTheme()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            this.dgvCart.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
        }
        private void btnUpdateDS_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCart.SelectedRows.Count > 1)
                    throw new ArgumentException("Debe seleccionar solo una fila para editar.");
                if (this.dgvCart.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar una fila para editar.");

                int index = this.dgvCart.CurrentRow.Index;

                DialogResult result = new DialogResult();
                FormModifySaleCount frmModifySaleCount = new FormModifySaleCount(
                    "Ingrese la cantidad", this.carrito.GetByIndex(index));
                result = frmModifySaleCount.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    this.carrito.UpdateSaleCountByIndex(index, frmModifySaleCount.value);
                    this.source.ResetItem(index);
                    this.lblTotalCart.Text = Convert.ToString(this.carrito.total);

                    FormSuccess.ConfirmationForm("MODIFICADO");
                }
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
                if (this.dgvCart.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar una fila para eliminar.");

                DialogResult result = new DialogResult();
                FormInformation formInformation = new FormInformation("¿ESTAS SEGURO DE ELIMINAR EL REGISTRO?");
                result = formInformation.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CartItem detailProduct = this.dgvCart.CurrentRow.DataBoundItem as CartItem;
                    int index = this.dgvCart.CurrentRow.Index;
                    this.carrito.DeleteCartItem(index, detailProduct.idDetailProduct);
                    this.source.ResetBindings();
                    this.lblTotalCart.Text = Convert.ToString(this.carrito.total);

                    FormSuccess.ConfirmationForm("ELIMINADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dirijase al menu de productos para agregar.");
        }

        private async void btnRegisterSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameClient.Text == string.Empty)
                    throw new ArgumentNullException("Debe ingresar el nombre del cliente.");
                if (this.carrito.getCount() == 0)
                    throw new ArgumentException("Debe registrar como minimo 1 producto a vender para realizar la venta");

                Sale mySale = new Sale
                {
                    nameClient = txtNameClient.Text,
                    detailSaleList = this.carrito.ToDetailSaleList(),
                    total = this.carrito.total
                };
                Sale resultSale = await SaleService.RegisterSale(mySale);

                DialogResult result = new DialogResult();
                FormSuccessRegisterSale formSuccessRegisterSale = new FormSuccessRegisterSale("REGISTRADO");
                result = formSuccessRegisterSale.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    SaleService.ExportInPDFDetailSaleLikeCartItemByIdSale(resultSale.idSale);
                }

                this.carrito.GenerateNewList();
                this.dgvCart.DataSource = null;
                this.txtNameClient.Text = string.Empty;
                this.lblTotalCart.Text = string.Empty;
                this.txtNameClient.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
