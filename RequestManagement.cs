using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Navigation;
using UI.RestaurantControls;
using UI.UserControls;

namespace UI
{
    public partial class formRequestManagement : Form
    {

        NavigationControl navigationControl;
        NavigationButton navigationButton;
        Color btnDefaultColor = Color.FromArgb(24, 30, 54);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);

        public formRequestManagement()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void formRequestManagement_Load(object sender, EventArgs e)
        {
            lblUserID.Text = User.UserID;
            lblPosistion.Text = User.Position;
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new RequestManagementControl(), new RequestRecordControl(), new RestaurantStockControl (), new RestaurantDeliveryNoteControl(), new DashboardControl()};

            navigationControl = new NavigationControl(userControls, mainPanel);  // create instance of navigation control class
            navigationControl.Display(4);   // display the search request control as first view

        }

        private void InitializeNavigationButton()
        {
            List<Button> button = new List<Button>()
            { navSearchRequest, navRequestRecord, navRestaurantStock ,navResDNote,navDashboard};
            // instance nav button
                        navigationButton = new NavigationButton(button, btnDefaultColor, btnSelectedColor);
                        // make default selected button
            navigationButton.selectedButton(navDashboard);
        }


        private void navDashboard_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButton.selectedButton(navDashboard);
        }

        private void navSearchRequest_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.selectedButton(navSearchRequest);
        }

        private void navRequestRecord_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.selectedButton(navRequestRecord);
        }

        private void navRequestStock_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.selectedButton(navRestaurantStock);
        }

        private void navResDNote_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButton.selectedButton(navResDNote);
        }


        private void formRequestManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void navPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRequestList_Click(object sender, EventArgs e)
        {

        }

        private void dgvRequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void lbluIDTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPosistionTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPosistion_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void centralizedprocurementsystemDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pbPosition_Click(object sender, EventArgs e)
        {

        }

        private void pbStaff_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void formRequestManagement_Load_1(object sender, EventArgs e)
        {

        }

    }
}


