using APIRestService;
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
    public partial class FormRegisterPurchase : Form
    {
        #region Atributtes
        public CartDetailPurchase cartDetailPurchase { get; set; }
        private BindingList<CartDetailPurchaseItem> sourceList;
        #endregion

        public FormRegisterPurchase(CartDetailPurchase cartDetailPurchase)
        {
            InitializeComponent();
            this.dgvDPurchase.AutoGenerateColumns = false;
            this.cartDetailPurchase = cartDetailPurchase;
            this.LoadForm();
        }
        private void LoadForm()
        {
            this.sourceList = new BindingList<CartDetailPurchaseItem>(this.cartDetailPurchase.getList());
            this.dgvDPurchase.DataSource = this.sourceList;
            this.UpdateTotalAndSimilars(Convert.ToDecimal(this.cartDetailPurchase.total));
            this.pnlAddDProductForm.Visible = false;
        }
        public void LoadTheme()
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
            this.dgvDPurchase.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
        }

        private void btnUpdateDPu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDPurchase.SelectedRows.Count > 1)
                    throw new ArgumentException("Debe seleccionar solo una fila para editar.");
                if (this.dgvDPurchase.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar una fila para editar.");

                int index = this.dgvDPurchase.CurrentRow.Index;
                
                DialogResult result = new DialogResult();
                FormUpdateCartDetailPurchaseItem formUpdateCartDetailPurchaseItem = new FormUpdateCartDetailPurchaseItem(
                    "Modificar Registro", this.cartDetailPurchase.GetByIndex(index).quantity,
                    this.cartDetailPurchase.GetByIndex(index).unitPrice);
                result = formUpdateCartDetailPurchaseItem.ShowDialog(this);

                if (result == DialogResult.OK)
                {

                    this.cartDetailPurchase.UpdateQuantityByIndex(index, formUpdateCartDetailPurchaseItem.quantity);
                    this.cartDetailPurchase.UpdateUnitPriceByIndex(index, formUpdateCartDetailPurchaseItem.unitPrice);

                    this.sourceList.ResetItem(index);
                    this.UpdateTotalAndSimilars(Convert.ToDecimal(this.cartDetailPurchase.total));

                    FormSuccess.ConfirmationForm("MODIFICADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteDPu_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDPurchase.SelectedRows.Count == 0)
                    throw new ArgumentException("Debe seleccionar una fila para eliminar.");

                DialogResult result = new DialogResult();
                FormInformation formInformation = new FormInformation("¿ESTAS SEGURO DE ELIMINAR EL REGISTRO?");
                result = formInformation.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CartDetailPurchase detailProduct = this.dgvDPurchase.CurrentRow.DataBoundItem as CartDetailPurchase;
                    int index = this.dgvDPurchase.CurrentRow.Index;
                    this.cartDetailPurchase.DeleteCartDetailPurchaseItem(index);
                    this.sourceList.ResetBindings();
                    this.UpdateTotalAndSimilars(Convert.ToDecimal(this.cartDetailPurchase.total));

                    FormSuccess.ConfirmationForm("ELIMINADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDPu_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddProductForSaleOrPurchase frmSearchProduct = new FormAddProductForSaleOrPurchase("Compra", FormTypes.FormRegisterPurchase, this.pnlAddDProductForm);
                frmSearchProduct.cartDetailPurchase = this.cartDetailPurchase;
                frmSearchProduct.sourceListCartDetailPurchase = this.sourceList;

                this.EnableChildForm(frmSearchProduct);

                this.UpdateTotalAndSimilars(Convert.ToDecimal(this.cartDetailPurchase.total));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnRegisterPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtRuc.Text == string.Empty)
                    throw new ArgumentNullException("Debe ingresar el RUC del proveedor.");
                if (this.txtRuc.TextLength != 11)
                    throw new ArgumentException("El RUC debe tener exacntamente 11 digitos");
                if (this.cartDetailPurchase.getCount() == 0)
                    throw new ArgumentException("Debe registrar como minimo 1 producto para realizar la COMPRA");

                Purchase purchase = new Purchase
                {
                    ruc = this.txtRuc.Text,
                    detailPurchaseList = this.cartDetailPurchase.ToDetailPurchaseList(),
                    total = this.cartDetailPurchase.total
                };

                Purchase resultPurchase = await PurchaseService.RegisterPurchase(purchase);

                FormSuccess.ConfirmationForm("REGISTRADO");

                this.ResetRegisterConfiguration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetRegisterConfiguration()
        {
            this.cartDetailPurchase.GenerateNewList();
            this.sourceList = new BindingList<CartDetailPurchaseItem>(this.cartDetailPurchase.getList());
            this.dgvDPurchase.DataSource = this.sourceList;
            this.UpdateTotalAndSimilars(Convert.ToDecimal(this.cartDetailPurchase.total));
            this.txtRuc.Text = string.Empty;
            this.txtRuc.Focus();
        }

        private void UpdateTotalAndSimilars(decimal total)
        {
            this.lblTotalDPList.Text = decimal.Round(total, 2, MidpointRounding.AwayFromZero).ToString();
            decimal subTotal = decimal.Round((total / 1.18m), 2, MidpointRounding.AwayFromZero);
            decimal IGV = decimal.Round((total - subTotal), 2, MidpointRounding.AwayFromZero);
            this.lblSubTotalValue.Text = subTotal.ToString();
            this.lblIGVValue.Text = IGV.ToString();

        }

        #region ChildFormManagement
        private void EnableChildForm(Form childForm)
        {
            this.pnlAddDProductForm.Dock = DockStyle.Fill;
            this.pnlAddDProductForm.Visible = true;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlAddDProductForm.Controls.Add(childForm);
            this.pnlAddDProductForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion
    }
}
