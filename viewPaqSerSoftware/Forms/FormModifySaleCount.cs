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
        public FormModifySaleCount(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
            this.txtSaleCount.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToInt32(txtSaleCount.Text);

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
