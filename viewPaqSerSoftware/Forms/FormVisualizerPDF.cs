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
    public partial class FormVisualizerPDF : Form
    {
        public FormVisualizerPDF()
        {
            InitializeComponent();
        }
        private void FormVisualizerPDF_Load(object sender, EventArgs e)
        {
            //this.wbPDF.Url = new Uri("http://localhost:8080/api/sale/export?day=2021-02-22");
            //this.wbPDF.Navigate(new Uri("http://localhost:8080/api/sale/export?day=2021-02-22"));
            //System.Diagnostics.Process.Start("http://localhost:8080/api/sale/export?day=2021-02-22");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
