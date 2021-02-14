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
        public FormSales()
        {
            InitializeComponent();
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            
            /*
            Sale testSale = new Sale()
            {
                nameClient = "Felipe",
                total = 400.00m,
                detailSaleList = new List<DetailSale>()
                {
                    new DetailSale()
                    {
                        saleCount = 2m,
                        subTotal = 200.00m,
                        idDetailProduct = 3
                    },
                    new DetailSale()
                    {
                        saleCount = 1m,
                        subTotal = 200.00m,
                        idDetailProduct = 4
                    }
                }
            };
            
            Sale resultSale = await SaleService.RegisterSale(testSale);
            MessageBox.Show(resultSale.ToString());
            */
        }
    }
}
