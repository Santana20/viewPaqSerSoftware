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
        public CartDetailSale cartDetailSale { get; set; }
        private BindingList<CartDetailSaleItem> sourceList;
        #endregion
        public FormRegisterSale()
        {
            InitializeComponent();
            this.dgvCart.AutoGenerateColumns = false;
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
            this.sourceList = new BindingList<CartDetailSaleItem>(this.cartDetailSale.getList());
            this.dgvCart.DataSource = this.sourceList;
            this.lblTotalCart.Text = Convert.ToString(this.cartDetailSale.total);
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
                    "Ingrese la cantidad", this.cartDetailSale.GetByIndex(index));
                result = frmModifySaleCount.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    this.cartDetailSale.UpdateSaleCountByIndex(index, frmModifySaleCount.value);
                    this.sourceList.ResetItem(index);
                    this.lblTotalCart.Text = Convert.ToString(this.cartDetailSale.total);

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
                    CartDetailSaleItem detailProduct = this.dgvCart.CurrentRow.DataBoundItem as CartDetailSaleItem;
                    int index = this.dgvCart.CurrentRow.Index;
                    this.cartDetailSale.DeleteCartItem(index, detailProduct.idDetailProduct);
                    this.sourceList.ResetBindings();
                    this.lblTotalCart.Text = Convert.ToString(this.cartDetailSale.total);

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
            try
            {
                FormAddProductForSaleOrPurchase frmSearchProduct = new FormAddProductForSaleOrPurchase("Venta", FormTypes.FormRegisterSales);
                frmSearchProduct.cartDetailSale = this.cartDetailSale;
                frmSearchProduct.ShowDialog(this);
                this.sourceList.ResetBindings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnRegisterSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameClient.Text == string.Empty)
                    throw new ArgumentNullException("Debe ingresar el nombre del cliente.");
                if (this.cartDetailSale.getCount() == 0)
                    throw new ArgumentException("Debe registrar como minimo 1 producto a vender para realizar la venta");

                Sale mySale = new Sale
                {
                    nameClient = txtNameClient.Text,
                    detailSaleList = this.cartDetailSale.ToDetailSaleList(),
                    total = this.cartDetailSale.total
                };
                Sale resultSale = await SaleService.RegisterSale(mySale);

                DialogResult result = new DialogResult();
                FormSuccessRegisterSale formSuccessRegisterSale = new FormSuccessRegisterSale("REGISTRADO");
                result = formSuccessRegisterSale.ShowDialog(this);

                if (result == DialogResult.Yes)
                {
                    SaleService.ExportInPDFDetailSaleLikeCartItemByIdSale(resultSale.idSale);
                }

                this.ResetRegisterConfiguration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetRegisterConfiguration()
        {
            this.cartDetailSale.GenerateNewList();
            this.sourceList = new BindingList<CartDetailSaleItem>(this.cartDetailSale.getList());
            this.dgvCart.DataSource = this.sourceList;
            this.lblTotalCart.Text = Convert.ToString(this.cartDetailSale.total);
            this.txtNameClient.Text = string.Empty;
            this.txtNameClient.Focus();
        }
    }
}
