using HotelManagementData.Data;
using HotelManagementData.Entities;
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
    public partial class UpdateServiceForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private readonly Service updatingService;

        private string oldServiceName;
        public UpdateServiceForm(HotelManagementApplicationDb db, Service updatingService)
        {
            InitializeComponent();
            this.db = db;
            this.updatingService = updatingService;
            txtServiceName.Text = updatingService.ServiceName;
            nudServicePrice.Value = updatingService.UnitPrice;
            oldServiceName = updatingService.ServiceName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatingServiceName = txtServiceName.Text.Trim();
            if (string.IsNullOrEmpty(updatingServiceName))
            {
                MessageBox.Show("Service Name field is Required!");
                return;
            }
            else if (updatingServiceName.ToLower() != oldServiceName.ToLower())
            {
                if (db.Services.Any(x => x.ServiceName.ToLower() == updatingServiceName.ToLower()))
                {
                    MessageBox.Show("There is already a service with this name, try different name or cancel!");
                    return;
                }
            }
            updatingService.ServiceName = updatingServiceName;
            updatingService.UnitPrice = nudServicePrice.Value;
            db.SaveChanges();
            MessageBox.Show("Service Updated");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
