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
    public partial class FormListPurchases : Form
    {
        private int lastRowSelected = -1;
        public FormListPurchases()
        {
            InitializeComponent();
            this.dgvPurchases.AutoGenerateColumns = false;
            this.dgvDetailsPurchase.AutoGenerateColumns = false;
            this.dtpDatePurchase.Value = DateTime.Now;
        }
        private void FormListPurchases_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
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
            this.dgvPurchases.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
            this.dgvDetailsPurchase.DefaultCellStyle.SelectionBackColor = ThemeColor.primaryColor;
        }
        private async void btnSearchPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvPurchases.DataSource = await PurchaseService.ListPurchasesByDate(this.dtpDatePurchase.Value.ToString("dd-MM-yyyy"));
                this.UpdateLastRowIndexSelected(-1);
                if (this.dgvPurchases.Rows.Count == 0)
                    throw new Exception("No se encontraron ventas el dia " +
                        this.dtpDatePurchase.Value.ToString("dd-MM-yyyy"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvPurchases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPurchases.Rows[e.RowIndex].Cells["DetailPurchase"].Selected)
                {
                    this.PaintRowAndUnpaintLastSelectedRow(e.RowIndex);

                    long idPurchase = (long)this.dgvPurchases.Rows[e.RowIndex].Cells["idPurchase"].Value;
                    this.dgvDetailsPurchase.DataSource = await DetailPurchaseService.ListDetailSaleLikeCartItemByIdSale(idPurchase);
                }
                
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
            if (this.lastRowSelected > -1 && this.lastRowSelected < this.dgvPurchases.Rows.Count)
                this.dgvPurchases.Rows[this.lastRowSelected].DefaultCellStyle.BackColor = this.dgvPurchases.DefaultCellStyle.BackColor;

            this.UpdateLastRowIndexSelected(currentRowIndex);
            this.dgvPurchases.Rows[currentRowIndex].DefaultCellStyle.BackColor = this.dgvPurchases.DefaultCellStyle.SelectionBackColor;
        }
        private void UpdateLastRowIndexSelected(int currentRowIndex) => this.lastRowSelected = currentRowIndex;

        #endregion

        
    }
}
