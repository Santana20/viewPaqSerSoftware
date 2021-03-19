using Entities;
using APIRestService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using viewPaqSerSoftware.Forms;

namespace viewPaqSerSoftware
{
    public partial class FormProductMaintenance : Form
    {
        #region Attributes
        public CartDetailSale carrito { get; set; }
        private Product currentProductSelected;
        private int lastRowSelected = -1;
        #endregion
        public FormProductMaintenance()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgvProductDetails.AutoGenerateColumns = false;
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
            this.dgvProductDetails.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
        }
        private async void FormProducts_Load(object sender, EventArgs e)
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

        #region Button Events
        private async void btnCreateProduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                Product product = new Product
                {
                    codProduct = this.txtIdProduct.Text,
                    nameProduct = this.txtNameProduct.Text,
                    brand = new Brand { idBrand = (long)cmbIdBrand.SelectedValue },
                    productType = new ProductType { idProductType = (long)cmbProductType.SelectedValue }
                };

                Product responseProduct = await ProductService.RegisterProduct(product);

                FormSuccess.ConfirmationForm("REGISTRADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            ClearItems(); this.txtIdProduct.Focus();

        }
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

        #endregion

        #region DGVManagenment
        private async void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
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
                else if (this.dgvProducts.Rows[e.RowIndex].Cells["addDetailproduct"].Selected)
                {
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);
                    
                    DialogResult result = new DialogResult();
                    FormViewMaintainDetailProduct formViewMaintainDetailProduct = new FormViewMaintainDetailProduct();
                    result = formViewMaintainDetailProduct.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        DetailProduct detailProductForMaintain = formViewMaintainDetailProduct.GetDetailProduct();

                        detailProductForMaintain.product = this.dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;

                        DetailProduct resultDetailProduct = await DetailProductService
                            .RegisterDetailProduct(detailProductForMaintain);

                        FormSuccess.ConfirmationForm("REGISTRADO");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Utils
        private void ClearItems()
        {
            txtIdProduct.Clear();
            txtNameProduct.Clear();
            cmbIdBrand.SelectedIndex = -1;
            cmbProductType.SelectedIndex = -1;
        }
        // Manejo visual de la seleccion de toda la fila cuando se selecciona determinadas celdas de la fila.
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
    }
}
