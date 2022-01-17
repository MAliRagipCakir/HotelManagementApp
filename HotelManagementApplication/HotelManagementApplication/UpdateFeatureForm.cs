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
    public partial class UpdateFeatureForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private readonly Feature updatingFeature;

        private string oldfeatureName;

        public UpdateFeatureForm(HotelManagementApplicationDb db, Feature updatingFeature)
        {
            InitializeComponent();
            this.db = db;
            this.updatingFeature = updatingFeature;
            txtFeatureName.Text = updatingFeature.FeatureName;
            oldfeatureName = updatingFeature.FeatureName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatingFeatureName = txtFeatureName.Text.Trim();
            if (string.IsNullOrEmpty(updatingFeatureName))
            {
                MessageBox.Show("Feature Name field is Required!");
                return;
            }
            else if (updatingFeatureName.ToLower() != oldfeatureName.ToLower())
            {
                if (db.Features.Any(x => x.FeatureName.ToLower() == updatingFeatureName.ToLower()))
                {
                    MessageBox.Show("There is already a feature with this name, try different name or cancel!");
                    return;
                }
            }

            updatingFeature.FeatureName = updatingFeatureName;
            db.SaveChanges();
            MessageBox.Show("Feature succesfully updated");
            Close();
        }
    }
}
