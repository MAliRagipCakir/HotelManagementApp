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
    public partial class FeaturesForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        public FeaturesForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            LoadFeatures();
        }

        private void LoadFeatures()
        {
            txtSearch.Text = "";
            if (!db.Features.Any())
            {
                dgvFeatures.DataSource = null;
                return;
            }
            dgvFeatures.DataSource = db.Features
                .Select(x => new
                {
                    x.Id,
                    x.FeatureName
                }).ToList();
            dgvFeatures.Columns[1].HeaderText = "Feature Name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvFeatures_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFeatures.SelectedRows.Count != 1) return;
            if (e.RowIndex == -1) return;
            int featureId = (int)dgvFeatures.SelectedRows[0].Cells[0].Value;
            Feature updatingFeature = db.Features.Find(featureId);
            new UpdateFeatureForm(db, updatingFeature).ShowDialog();
            LoadFeatures();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newFeatureName = txtFeatureName.Text.Trim();
            if (string.IsNullOrEmpty(newFeatureName))
            {
                MessageBox.Show("Feature Name field is Required!");
                return;
            }
            if (db.Features.Any(x => x.FeatureName.ToLower() == newFeatureName.ToLower()))
            {
                MessageBox.Show("There is already a feature with this name, can't add another feature with same name!");
                return;
            }
            Feature newFeature = new Feature() { FeatureName = newFeatureName };
            db.Features.Add(newFeature);
            db.SaveChanges();
            txtFeatureName.Text = "";
            MessageBox.Show("Feature succesfully added!");
            LoadFeatures();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFeatures.SelectedRows.Count != 1) return;
            int featureId = (int)dgvFeatures.SelectedRows[0].Cells[0].Value;
            Feature deletingFeature = db.Features.Find(featureId);
            db.Features.Remove(deletingFeature);
            db.SaveChanges();
            MessageBox.Show("Feature deleted!");
            LoadFeatures();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                LoadFeatures();
            else
            {
                if (!db.Features.Any())
                {
                    dgvFeatures.DataSource = null;
                    return;
                }
                string searchedFeatureName = txtSearch.Text.ToLower().Trim();
                dgvFeatures.DataSource = db.Features
                    .Where(x => x.FeatureName.ToLower().Contains(searchedFeatureName))
                    .Select(x => new
                    {
                        x.Id,
                        x.FeatureName
                    }).ToList();
                dgvFeatures.Columns[1].HeaderText = "Feature Name";
            }
        }
    }
}
