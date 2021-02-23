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
    public partial class FormSuccess : Form
    {
        public FormSuccess(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
        }
        public static void ConfirmationForm(string message)
        {
            FormSuccess formSuccess = new FormSuccess(message);
            formSuccess.ShowDialog();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
