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
    public partial class FormListSales : Form
    {
        private int lastRowSelected = -1;
        public FormListSales()
        {
            InitializeComponent();
            this.dgvDetailsSale.AutoGenerateColumns = false;
            this.dgvSales.AutoGenerateColumns = false;
            this.dtpDateSale.Value = DateTime.Now;
        }

        private async void btnSearchSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvSales.DataSource = await SaleService.ListSalesByDate(this.dtpDateSale.Value.ToString("dd-MM-yyyy"));
                this.UpdateLastRowIndexSelected(-1);
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
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);

                    long idSale = (long)this.dgvSales.Rows[e.RowIndex].Cells["idSale"].Value;
                    this.dgvDetailsSale.DataSource = await DetailSaleService.ListDetailSaleLikeCartItemByIdSale(idSale);
                }
                else if (this.dgvSales.Rows[e.RowIndex].Cells["PDFView"].Selected)
                {
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);

                    long idSale = (long)this.dgvSales.Rows[e.RowIndex].Cells["idSale"].Value;
                    SaleService.ExportInPDFDetailSaleLikeCartItemByIdSale(idSale);
                }
                else if (this.dgvSales.Rows[e.RowIndex].Cells["cancelSale"].Selected)
                {
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);

                    DialogResult result = new DialogResult();
                    FormInformation formInformation = new FormInformation("¿ESTAS SEGURO DE ANULAR LA VENTA?");
                    result = formInformation.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        long idSale = (long)this.dgvSales.Rows[e.RowIndex].Cells["idSale"].Value;
                        if (await SaleService.CancelSaleByIdSale(idSale))
                        {
                            FormSuccess.ConfirmationForm("ANULADO");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizeSaleInPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string day = this.dtpDateSale.Value.ToString("dd-MM-yyyy");

                SaleService.ExportInPDFListSalesByDate(day);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Manejo visual de la seleccion de toda la fila cuando se selecciona determinadas celdas de la fila.
        #region VisualRowsManagements
        private void PaintRowAndUnpaintLastSelectedRow(int currentRowIndex)
        {
            if (this.lastRowSelected > -1 && this.lastRowSelected < this.dgvSales.Rows.Count)
                this.dgvSales.Rows[this.lastRowSelected].DefaultCellStyle.BackColor = this.dgvSales.DefaultCellStyle.BackColor;

            this.UpdateLastRowIndexSelected(currentRowIndex);
            this.dgvSales.Rows[currentRowIndex].DefaultCellStyle.BackColor = this.dgvSales.DefaultCellStyle.SelectionBackColor;
        }
        private void UpdateLastRowIndexSelected(int currentRowIndex) => this.lastRowSelected = currentRowIndex;
        #endregion
    }
}
