﻿using Entities;
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
    public partial class FormModifySaleCount : Form
    {
        public decimal value { get; set; }
        private CartDetailSaleItem currentItem; 
        public FormModifySaleCount(string message, CartDetailSaleItem curItem)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
            this.currentItem = curItem;
            this.value = currentItem.count;
            this.txtSaleCount.Text = this.value.ToString();
            this.txtSaleCount.Focus();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDecimal(this.txtSaleCount.Text);
                if (value > this.currentItem.Stock)
                    throw new ArgumentException("La cantidad no puede ser mayor al stock disponible.\n" +
                        "Stock disponible para el producto actual: " + this.currentItem.Stock.ToString());
                if (value < 0)
                    throw new ArgumentException("la cantidad no puede ser negativa");
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
