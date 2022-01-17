using HotelManagementData.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public partial class MainMenuForm : Form
    {
        HotelManagementApplicationDb db = new HotelManagementApplicationDb();
        private Form activeForm = null;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();


            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnReservations);
            openChildForm(new ReservationsForm(db));
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnRooms);
            openChildForm(new RoomsForm(db));
        }

        private void btnFeatures_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnFeatures);
            openChildForm(new FeaturesForm(db));
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnServices);
            openChildForm(new ServicesForm(db));
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomersForm(db));
            ChangeButtonColor(btnCustomers);
        }
        
        private void ChangeButtonColor(Button button)
        {
            btnRooms.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            btnFeatures.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            btnServices.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            btnCustomers.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            btnReservations.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            button.BackColor = Color.FromKnownColor(KnownColor.GradientActiveCaption);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            tmrClock.Start();//Breakpoint'de devamlı buna geliyor, ShowDialog değilde Show ile açıldığından arka planda devamlı çalışıyor
        }
    }
}
