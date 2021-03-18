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
    public partial class FormAddProductForSaleOrPurchase : Form
    {
        #region Attributes
        public CartDetailSale cartDetailSale { get; set; }
        public CartDetailPurchase cartDetailPurchase{ get; set; }
        private FormTypes formParent;
        private Product currentProductSelected;
        private int lastRowSelected = -1;
        #endregion
        public FormAddProductForSaleOrPurchase(string isFor, FormTypes formParent)
        {
            InitializeComponent();
            this.Text += isFor;
            this.formParent = formParent;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProductDetails.AutoGenerateColumns = false;
        }
        private async void FormAddProductForSaleOrPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadTheme();
                cmbIdBrand.DataSource = await BrandService.ListAllBrands();
                cmbProductType.DataSource = await ProductTypeService.ListAllProductTypes();

                cmbIdBrand.DisplayMember = "nameBrand"; cmbIdBrand.ValueMember = "idBrand";
                cmbProductType.DisplayMember = "nameProductType"; cmbProductType.ValueMember = "idProductType";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearItems(); txtIdProduct.Focus();
        }
        
        #region Utils
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
            this.dgvProductDetails.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
        }
        private void ClearItems()
        {
            txtIdProduct.Clear();
            txtNameProduct.Clear();
            cmbIdBrand.SelectedIndex = -1;
            cmbProductType.SelectedIndex = -1;
        }
        #region VisualRowsManagements
        private void PaintRowAndUnpaintLastSelectedRow(int currentRowIndex)
        {
            if (this.lastRowSelected > -1 && this.lastRowSelected < this.dgvProducts.Rows.Count)
                this.dgvProducts.Rows[this.lastRowSelected].DefaultCellStyle.BackColor = this.dgvProducts.DefaultCellStyle.BackColor;

            this.UpdateLastRowIndexSelected(currentRowIndex);
            this.dgvProducts.Rows[currentRowIndex].DefaultCellStyle.BackColor = this.dgvProducts.DefaultCellStyle.SelectionBackColor;
        }
        private void UpdateLastRowIndexSelected(int currentRowIndex) => this.lastRowSelected = currentRowIndex;
        #endregion
        #endregion

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProduct.Text != string.Empty)
                {
                    dgvProducts.DataSource = new List<Product>()
                    { await ProductService.FindByIdProduct(txtIdProduct.Text) };
                }

                else
                {
                    string parametros = string.Empty;
                    List<string> requestParams = new List<string>();
                    if (txtNameProduct.Text != string.Empty)
                        requestParams.Add("name=" + txtNameProduct.Text);
                    if (cmbIdBrand.SelectedIndex != -1)
                        requestParams.Add("idBrand=" + cmbIdBrand.SelectedValue);
                    if (cmbProductType.SelectedIndex != -1)
                        requestParams.Add("idProductType=" + cmbProductType.SelectedValue);

                    for (int i = 0; i < requestParams.Count; ++i)
                    {
                        parametros += (i == 0) ? '?' : '&';
                        parametros += requestParams[i];
                    }

                    this.dgvProducts.DataSource = await ProductService.SearchProducts(parametros);
                }
                this.UpdateLastRowIndexSelected(-1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearItems(); txtIdProduct.Focus();
        }

        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvProducts.Rows[e.RowIndex].Cells["DetailProduct"].Selected)
                {
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);

                    long idProduct = (this.dgvProducts.Rows[e.RowIndex].DataBoundItem as Product).id;
                    this.dgvProductDetails.DataSource = await DetailProductService.ListDetailProductByIdProduct(idProduct);
                    this.currentProductSelected = (Product)this.dgvProducts.Rows[e.RowIndex].DataBoundItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductDetails.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccione un producto para agregar al carrito");
                }

                foreach (DataGridViewRow detailProduct in this.dgvProductDetails.SelectedRows)
                {
                    if (this.formParent == FormTypes.FormRegisterSales)
                    {
                        this.cartDetailSale.AddCartItem(new CartDetailSaleItem(currentProductSelected,
                                            detailProduct.DataBoundItem as DetailProduct));
                    }
                    else if (this.formParent == FormTypes.FormRegisterPurchase)
                    {
                        this.cartDetailPurchase.AddCartDPItem(new CartDetailPurchaseItem(currentProductSelected,
                            detailProduct.DataBoundItem as DetailProduct));
                    }
                    
                }
                FormSuccess.ConfirmationForm("AGREGADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
