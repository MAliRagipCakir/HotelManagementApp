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
    public partial class ServicesForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        public ServicesForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            LoadServices();
        }

        private void LoadServices()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                txtSearch.Text = "";
            if (!db.Services.Any())
            {
                dgvServices.DataSource = null;
                return;
            }
            dgvServices.DataSource = db.Services
                .Select(x => new
                {
                    x.Id,
                    x.ServiceName,
                    x.UnitPrice
                }).ToList();
            dgvServices.Columns[1].HeaderText = "Service Name";
            dgvServices.Columns[2].HeaderText = "Unit Price";
            dgvServices.Columns[2].DefaultCellStyle.Format = "C2";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count != 1) return;
            int serviceId = (int)dgvServices.SelectedRows[0].Cells[0].Value;
            Service deletingService = db.Services.Find(serviceId);
            db.Services.Remove(deletingService);
            db.SaveChanges();
            MessageBox.Show("Service deleted!");
            LoadServices();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newServiceName = txtServiceName.Text.Trim();
            if (string.IsNullOrEmpty(newServiceName))
            {
                MessageBox.Show("Service Name field is Required!");
                return;
            }
            Service newService = new Service() { ServiceName = newServiceName, UnitPrice = nudServicePrice.Value };
            if (db.Services.Any(x => x.ServiceName.ToLower() == newServiceName.ToLower()))
            {
                MessageBox.Show("There is already a service with this name, can't add another service with same name!");
                return;
            }
            db.Services.Add(newService);
            db.SaveChanges();
            txtServiceName.Text = "";
            MessageBox.Show("Service succesfully added!");
            LoadServices();
        }

        private void dgvServices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvServices.SelectedRows.Count != 1) return;
            if (e.RowIndex == -1) return;
            int serviceId = (int)dgvServices.SelectedRows[0].Cells[0].Value;
            Service updatingService = db.Services.Find(serviceId);
            new UpdateServiceForm(db, updatingService).ShowDialog();
            LoadServices();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                LoadServices();
            else
            {
                if (!db.Services.Any())
                {
                    dgvServices.DataSource = null;
                    return;
                }
                string searchedServiceName = txtSearch.Text.ToLower().Trim();
                dgvServices.DataSource = db.Services
                    .Where(x => x.ServiceName.ToLower().Contains(searchedServiceName))
                    .Select(x => new
                    {
                        x.Id,
                        x.ServiceName,
                        x.UnitPrice
                    }).ToList();
                dgvServices.Columns[1].HeaderText = "Service Name";
                dgvServices.Columns[2].HeaderText = "Unit Price";
                dgvServices.Columns[2].DefaultCellStyle.Format = "C2";
            }
        }
    }
}
