using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ItemControls;
using UI.Navigation;
using UI.UserControls;

namespace UI
{
    public partial class ItemManagement : Form
    {
        NavigationControl navigationControl;
        NavigationButton navigationButton;
        Color btnDefaultColor = Color.FromArgb(24, 30, 54);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public ItemManagement()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void ItemManagement_Load(object sender, EventArgs e)
        {
            lblUserID.Text = User.UserID;
            lblPosistion.Text = User.Position;
        }


        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new ItemManagementControl(), new VirtualIDMappingControl() ,new SupplierManageControl() };

            navigationControl = new NavigationControl(userControls, mainPanel);  // create instance of navigation control class
            navigationControl.Display(0);   // display the search request control as first view

        }

        private void InitializeNavigationButton()
        {
            List<Button> button = new List<Button>()
            { navCreatEditItem, navVirtualIDMapping, navSupplierManage };
            // instance nav button
            navigationButton = new NavigationButton(button, btnDefaultColor, btnSelectedColor);
            // make default selected button
            navigationButton.selectedButton(navCreatEditItem);
        }

        private void navCreatEditItem_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.selectedButton(navCreatEditItem);
        }

        private void navVirtualIDMapping_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.selectedButton(navVirtualIDMapping);
        }

        private void ItemManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void navSupplierManage_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.selectedButton(navSupplierManage);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                fmLogoin login = new fmLogoin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void lblPosistion_Click(object sender, EventArgs e)
        {

        }

        private void navPannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
