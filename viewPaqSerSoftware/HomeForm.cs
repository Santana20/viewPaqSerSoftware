using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viewPaqSerSoftware.Forms;

namespace viewPaqSerSoftware
{
    public enum FormTypes
    {
        None,
        HomeForm,
        FormProductMaintenance,
        FormRegisterSales,
        FormListSales,
        FormRegisterPurchase,
        FormListPurchases
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
        private CartDetailSale cartDetailSale;
        private CartDetailPurchase cartDetailPurchase;
        private Process ProcessAPIRest;
        private string nameJarFIleAPI = "inventarioAPI-1.0.0.jar";
        #endregion

        public HomeForm()
        {
            InitializeComponent();
            this.cartDetailSale = new CartDetailSale();
            this.cartDetailPurchase = new CartDetailPurchase();
            this.InitialConfigurationDesign();
            this.OpenJarAPI();
        }

        #region ManagementJarApi

        private void OpenJarAPI()
        {
            try
            {
                string filePath = string.Concat(Application.StartupPath, @"\", nameJarFIleAPI);
                ProcessAPIRest = Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Falta el siguiente archivo: " + nameJarFIleAPI);
            }
        }
        private void CloseJarAPI()
        {
            if (ProcessAPIRest != null) ProcessAPIRest.Kill();
        }
        #endregion

        #region MethodsDesigns

        #region PanelTitleBarMovement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region ButtonCloseMaxiAndMinimizeForm
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                FormInformation formInformation = new FormInformation("¿Esta seguro de salir del sistema?", "SALIR");
                result = formInformation.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    this.CloseJarAPI();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void InitialConfigurationDesign()
        {
            random = new Random();
            
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MakeInvisibleSubPanels();
        }
        private void MakeInvisibleSubPanels()
        {
            this.pnlProductsSubMenu.Visible = false;
            this.pnlSalesSubMenu.Visible = false;
            this.pnlPurchaseSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.MakeInvisibleSubPanels();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
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
            previousBtn.BackColor = Color.FromArgb(51, 53, 99);
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

        #region ChildFormsManagenment
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
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            ResetFormStyle();
        }
        #endregion

        #region ProductsRegion
        private void btnMenuProducts_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(this.pnlProductsSubMenu);   
        }
        private void btnListProducts_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormProductMaintenance)
            {
                FormProductMaintenance formListProduct = new FormProductMaintenance
                {
                    carrito = this.cartDetailSale
                };
                OpenChildForm(formListProduct, FormTypes.FormProductMaintenance, sender);
            }
        }
        #endregion

        #region SalesRegion
        private void btnMenuSales_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(this.pnlSalesSubMenu);
        }
        private void btnRegisterSale_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormRegisterSales)
            {
                FormRegisterSale formRegisterSales = new FormRegisterSale
                {
                    cartDetailSale = this.cartDetailSale
                };
                OpenChildForm(formRegisterSales, FormTypes.FormRegisterSales, sender);
            }
        }
        private void btnListSales_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormListSales)
            {
                FormListSales formListSales = new FormListSales();
                OpenChildForm(formListSales, FormTypes.FormListSales, sender);
            }
        }
        #endregion

        #region PurchaseRegion
        private void btnMenuPurchase_Click(object sender, EventArgs e)
        {
            this.ShowSubMenu(this.pnlPurchaseSubMenu);
        }

        private void btnRegisterPurchase_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormRegisterPurchase)
            {
                FormRegisterPurchase formRegisterPurchase = new FormRegisterPurchase(this.cartDetailPurchase);
                
                OpenChildForm(formRegisterPurchase, FormTypes.FormRegisterPurchase, sender);
                formRegisterPurchase.LoadTheme();
            }
        }

        private void btnListPurchases_Click(object sender, EventArgs e)
        {
            if (activeForm == null || activeFormType != FormTypes.FormListPurchases)
            {
                FormListPurchases formListPurchases = new FormListPurchases();
                OpenChildForm(formListPurchases, FormTypes.FormListPurchases, sender);
            }
        }


        #endregion

        #endregion

    }
}
