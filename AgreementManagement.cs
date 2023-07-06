using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AgreementControls;
using UI.Navigation;
using UI.UserControls;

namespace UI
{
    public partial class AgreementManagement : Form
    {
        NavigationControl navigationControl;
        NavigationButton navigationButton;
        Color btnDefaultColor = Color.FromArgb(24, 30, 54);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public AgreementManagement()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void AgreementManagement_Load(object sender, EventArgs e)
        {
            lblUserID.Text = User.UserID;
            lblPosistion.Text = User.Position;
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new BlanketPurchaseAgreementControl(), new PlannedPurchaseAgreementControl(), new ContractPurchaseAgreementControl(), new DespatchInstructionControl(),
            new BPAOrderControl(), new RequestQueueControl(), new PPAOrderControl(), new  CPAOrderListControl(), new PurchaseDashboardControl()};

            navigationControl = new NavigationControl(userControls, mainPanel);  // create instance of navigation control class
            navigationControl.Display(8);   // display the search request control as first view
        }

        private void InitializeNavigationButton()
        {
            List<Button> button = new List<Button>()
            { navBPA, navPPA, navCPA, navDespatchInstruction, navBPAOrder, navQueue, navPPAOrder,navCPAOrder, navDashboard};
            // instance nav button
            navigationButton = new NavigationButton(button, btnDefaultColor, btnSelectedColor);
            // make default selected button
            navigationButton.selectedButton(navDashboard);
        }


        private void navDashboard_Click(object sender, EventArgs e)
        {
            navigationControl.Display(8);
            navigationButton.selectedButton(navDashboard);
        }


        private void navQueue_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButton.selectedButton(navQueue);
        }

        private void navBPA_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.selectedButton(navBPA);
        }

        private void navPPA_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.selectedButton(navPPA);
        }

        private void navCPA_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.selectedButton(navCPA);
        }

        private void navDespatchInstruction_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButton.selectedButton(navDespatchInstruction);
        }


        private void navBPAOrder_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButton.selectedButton(navBPAOrder);
        }


        private void navPPAOrder_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
            navigationButton.selectedButton(navPPAOrder);
        }


        private void navCPAOrder_Click(object sender, EventArgs e)
        {
            navigationControl.Display(7);
            navigationButton.selectedButton(navCPAOrder);
        }

        private void AgreementManagement_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPosistion_Click(object sender, EventArgs e)
        {

        }

        private void navPannel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
