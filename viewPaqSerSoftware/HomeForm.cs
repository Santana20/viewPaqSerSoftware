using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viewPaqSerSoftware.Forms;

namespace viewPaqSerSoftware
{
    public enum FormTypes
    {
        None,
        FormProducts,
        FormSales
    };
    public partial class HomeForm : Form
    {
        #region FieldsToDesigns
        private Button currentButton;
        private Random random;
        private int tempIndex;
        #endregion

        #region FieldsPrincipal
        
        private Form activeForm;
        private FormTypes activeFormType;
        private Cart carrito;
        #endregion

        public HomeForm()
        {
            InitializeComponent();
            random = new Random();
            carrito = new Cart();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
        }


        #region MethodsDesigns
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index) index = random.Next(ThemeColor.ColorList.Count);

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableBeforeButton(currentButton);

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.primaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableBeforeButton(Button previousBtn)
        {
            if (previousBtn == null) return;
            previousBtn.BackColor = Color.FromArgb(51, 51, 76);
            previousBtn.ForeColor = Color.Gainsboro;
            previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void ResetFormStyle()
        {
            DisableBeforeButton(currentButton);
            lblTitleBar.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            activeFormType = FormTypes.None;
        } 
        #endregion

        #region principal
        private void OpenChildForm(Form childForm, FormTypes formType, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);

            activeForm = childForm;
            activeFormType = formType;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitleBar.Text = childForm.Text;
        }

        private void btnMenuProducts_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormProducts)
            {
                FormProducts formProduct = new FormProducts
                {
                    carrito = this.carrito
                };
                OpenChildForm(formProduct, FormTypes.FormProducts, sender);
            }
        }

        private void btnMenuSales_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormSales)
            {
                FormRegisterSale formSales = new FormRegisterSale
                {
                    carrito = this.carrito
                };
                OpenChildForm(formSales, FormTypes.FormSales, sender);
            }
        }
        #endregion

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            ResetFormStyle();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
