using Entities;
using RestService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace viewPaqSerSoftware
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            //restService = new RestHelper();
            
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
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
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
                    idProduct = txtIdProduct.Text,
                    nameProduct = txtNameProduct.Text,
                    idBrand = (long)cmbIdBrand.SelectedValue,
                    idProductType = (long)cmbProductType.SelectedValue
                };

                Product responseProduct = await ProductService.RegisterProduct(product);

                MessageBox.Show("El producto fue registrado correctamente.\n" + responseProduct.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            ClearItems(); txtIdProduct.Focus();

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
                    string parametros = String.Empty;
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

                    dgvProducts.DataSource = await ProductService.SearchProducts(parametros);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            ClearItems(); txtIdProduct.Focus();
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

        #endregion

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvProducts.SelectedRows[0] != default)
                {
                    Product product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
                    dgvProductDetails.DataSource = product.detailProductsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }

}
