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
    public partial class FormListSales : Form
    {
        public FormListSales()
        {
            InitializeComponent();
            this.dgvDetailsSale.AutoGenerateColumns = false;
            this.dgvSales.AutoGenerateColumns = false;
        }

        private async void btnSearchSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvSales.DataSource = await SaleService.ListSales(this.dtpDateSale.Value.ToString("dd-MM-yyyy"));
                if (this.dgvSales.Rows.Count == 0)
                    throw new Exception("No se encontraron ventas el dia " + 
                        this.dtpDateSale.Value.ToString("dd-MM-yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSales.Rows[e.RowIndex].Cells["DetailSale"].Selected)
                {
                    long idSale = (long)this.dgvSales.Rows[e.RowIndex].Cells["idSale"].Value;
                    this.dgvDetailsSale.DataSource = await DetailSaleService.ListDetailSaleLikeCartItemByIdSale(idSale);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
