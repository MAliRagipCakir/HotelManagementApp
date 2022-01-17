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
    public partial class UpdateRoomForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private readonly Room updatingRoom;

        private string oldRoomName;
        public UpdateRoomForm(HotelManagementApplicationDb db, Room updatingRoom)
        {
            InitializeComponent();
            this.db = db;
            this.updatingRoom = updatingRoom;
            oldRoomName = updatingRoom.RoomName;
            LoadRoomInfo();
            LoadAllFeatures();
            LoadRoomFeatures();
        }

        private void LoadRoomInfo()
        {
            txtRoomName.Text = updatingRoom.RoomName;
            nudCapacity.Value = updatingRoom.Capacity;
            nudPricePerDay.Value = updatingRoom.PricePerDay;
        }

        private void LoadRoomFeatures()
        {
            if (!string.IsNullOrEmpty(txtSearchRoom.Text))
                txtSearchRoom.Text = "";
            if (updatingRoom.Features.Count > 0)
            {
                dgvRoomFeatures.DataSource = updatingRoom.Features.Select(x => new
                {
                    x.Id,
                    x.FeatureName
                }).ToList();
                dgvRoomFeatures.Columns[1].HeaderText = "Feature Name";
            }
            else
            {
                dgvRoomFeatures.DataSource = null;
            }
        }

        private void LoadAllFeatures()
        {
            if (!string.IsNullOrEmpty(txtSearchAll.Text))
                txtSearchAll.Text = "";
            if (db.Features.Any())
            {
                if (updatingRoom.Features.Count > 0)
                {
                    dgvAllFeatures.DataSource = db.Features.ToList().Where(x => updatingRoom.Features.All(x2 => x2.Id != x.Id)).Select(k => new
                    {
                        k.Id,
                        k.FeatureName
                    }).ToList();//Room'da olmayan feature'ları listele
                    dgvAllFeatures.Columns[1].HeaderText = "Feature Name";
                }
                else
                {
                    dgvAllFeatures.DataSource = db.Features.Select(k => new
                    {
                        k.Id,
                        k.FeatureName
                    }).ToList();
                    dgvAllFeatures.Columns[1].HeaderText = "Feature Name";
                }
            }
            else
            {
                dgvAllFeatures.DataSource = null;
            }
        }

        private void btnAddFeature_Click(object sender, EventArgs e)
        {
            if (dgvAllFeatures.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a feature to add");
                return;
            }
            int featureId = (int)dgvAllFeatures.SelectedRows[0].Cells[0].Value;
            Feature feature = db.Features.Find(featureId);
            updatingRoom.Features.Add(feature);
            db.SaveChanges();
            LoadAllFeatures();
            LoadRoomFeatures();
        }

        private void btnRemoveFeature_Click(object sender, EventArgs e)
        {
            if (dgvRoomFeatures.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a feature to remove");
                return;
            }
            int featureId = (int)dgvRoomFeatures.SelectedRows[0].Cells[0].Value;
            Feature feature = db.Features.Find(featureId);
            updatingRoom.Features.Remove(feature);
            db.SaveChanges();
            LoadAllFeatures();
            LoadRoomFeatures();
        }

        private void txtSearchAll_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAll.Text))
                LoadAllFeatures();
            else
            {
                if (!db.Features.Any())
                {
                    dgvAllFeatures.DataSource = null;
                    return;
                }
                string searchedFeatureName = txtSearchAll.Text.ToLower().Trim();

                if (updatingRoom.Features.Count > 0)
                {
                    dgvAllFeatures.DataSource = db.Features
                        .ToList()//DbSet ... hatası
                        .Where(x => x.FeatureName.ToLower().Contains(searchedFeatureName) && updatingRoom.Features.All(x2 => x2.Id != x.Id))
                        .Select(x => new
                        {
                            x.Id,
                            x.FeatureName
                        }).ToList();
                    dgvAllFeatures.Columns[1].HeaderText = "Feature Name";
                }
                else
                {
                    dgvAllFeatures.DataSource = db.Features.Where(x => x.FeatureName.ToLower().Contains(searchedFeatureName)).Select(k => new
                    {
                        k.Id,
                        k.FeatureName
                    }).ToList();
                    dgvAllFeatures.Columns[1].HeaderText = "Feature Name";
                }
            }
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchRoom.Text))
                LoadRoomFeatures();
            else
            {
                if (!db.Features.Any())
                {
                    dgvRoomFeatures.DataSource = null;
                    return;
                }
                string searchedFeatureName = txtSearchRoom.Text.ToLower().Trim();
                if (updatingRoom.Features.Count > 0)
                {
                    dgvRoomFeatures.DataSource = updatingRoom.Features
                        .Where(x => x.FeatureName.ToLower().Contains(searchedFeatureName))
                        .Select(x => new
                        {
                            x.Id,
                            x.FeatureName
                        }).ToList();
                    dgvRoomFeatures.Columns[1].HeaderText = "Feature Name";
                }
                else
                {
                    dgvRoomFeatures.DataSource = null;
                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string updatingRoomName = txtRoomName.Text.Trim();
            int capacity = (int)nudCapacity.Value;
            decimal pricePerDay = nudPricePerDay.Value;
            if (string.IsNullOrEmpty(updatingRoomName))
            {
                MessageBox.Show("Room Name field is Required!");
                return;
            }
            else if (updatingRoomName.Length < 3 || updatingRoomName.Length > 15)
            {
                MessageBox.Show("Room Name has to be min '3' max '15' characters");
                return;
            }
            else if (updatingRoomName.ToLower() != oldRoomName.ToLower())
            {
                if (db.Rooms.Any(x => x.RoomName.ToLower() == updatingRoomName.ToLower()))
                {
                    MessageBox.Show("There is already a room with this name, can't add another room with same name!");
                    return;
                }
            }
            if (!updatingRoom.Features.Any())
            {
                MessageBox.Show("Every Room Has to have atleast 'TV', 'Bathroom', 'Wi-Fi', 'Clean Towels' and 'Mini Bar'; Add these feature or create these features first");
                return;
            }
            if (updatingRoom.Features.Where(x => x.FeatureName.ToLower() == "tv" || x.FeatureName.ToLower() == "bathroom" || x.FeatureName.ToLower() == "wi-fi" || x.FeatureName.ToLower() == "clean towels" || x.FeatureName.ToLower() == "mini bar").ToList().Count < 5)
            {
                MessageBox.Show("Every Room Has to have atleast 'TV', 'Bathroom', 'Wi-Fi', 'Clean Towels' and 'Mini Bar'");
                return;
            }
            updatingRoom.RoomName = updatingRoomName;
            updatingRoom.Capacity = capacity;
            updatingRoom.PricePerDay = pricePerDay;
            db.SaveChanges();
            MessageBox.Show("Room succesfully updated");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
