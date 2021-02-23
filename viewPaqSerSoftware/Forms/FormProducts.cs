﻿using Entities;
using RestService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using viewPaqSerSoftware.Forms;

namespace viewPaqSerSoftware
{
    public partial class FormProducts : Form
    {
        #region Attributes
        public Cart carrito { get; set; }
        private Product currentProductSelected;
        #endregion
        public FormProducts()
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
            dgvProductDetails.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
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

                FormSuccess.ConfirmationForm("REGISTRADO");
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

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProducts.Rows[e.RowIndex].Cells["DetailProduct"].Selected)
                {
                    this.currentProductSelected = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
                    dgvProductDetails.DataSource = this.currentProductSelected.detailProductsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddDPToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductDetails.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccione producto(s) para agregar al carrito");
                }

                foreach (DataGridViewRow detailProduct in this.dgvProductDetails.SelectedRows)
                {
                    this.carrito.AddCartItem(new CartItem(currentProductSelected, 
                                            (DetailProduct)detailProduct.DataBoundItem));
                }
                FormSuccess.ConfirmationForm("AGREGADO");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}