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
    public partial class CreateRoomForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        private Room newRoom;
        public CreateRoomForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            newRoom = new Room();
            LoadAllFeatures();
        }

        private void LoadRoomFeatures()
        {
            if (!string.IsNullOrEmpty(txtSearchRoom.Text))
                txtSearchRoom.Text = "";
            if (newRoom.Features.Count > 0)
            {
                dgvRoomFeatures.DataSource = newRoom.Features.Select(x => new
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

        private void LoadAllFeatures()//Room'da ekli olmayan Feature'ları listeler
        {
            if (!string.IsNullOrEmpty(txtSearchAll.Text))
                txtSearchAll.Text = "";
            if (db.Features.Any())
            {
                if (newRoom.Features.Count > 0)
                {
                    dgvAllFeatures.DataSource = db.Features.ToList().Where(x => newRoom.Features.All(x2 => x2.Id != x.Id)).Select(k => new
                    {
                        k.Id,
                        k.FeatureName
                    }).ToList();
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
                dgvAllFeatures.DataSource = null;
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
            newRoom.Features.Add(feature);
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
            newRoom.Features.Remove(feature);
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

                if (newRoom.Features.Count > 0)
                {
                    dgvAllFeatures.DataSource = db.Features
                        .ToList()//DbSet ... hatası
                        .Where(x => x.FeatureName.ToLower().Contains(searchedFeatureName) && newRoom.Features.All(x2 => x2.Id != x.Id))
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
                string searchedFeatureName = txtSearchRoom.Text.ToLower().Trim();
                if (newRoom.Features.Count > 0)
                {
                    dgvRoomFeatures.DataSource = newRoom.Features
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            int capacity = (int)nudCapacity.Value;
            decimal pricePerDay = nudPricePerDay.Value;
            if (string.IsNullOrEmpty(roomName))
            {
                MessageBox.Show("Room Name field is Required!");
                return;
            }
            if (roomName.Length < 3 || roomName.Length > 15)
            {
                MessageBox.Show("Room Name has to be min '3' max '15' characters");
                return;
            }
            if (db.Rooms.Any(x => x.RoomName.ToLower() == roomName.ToLower()))
            {
                MessageBox.Show("There is already a room with this name, can't add another room with same name!");
                return;
            }
            if (!newRoom.Features.Any())
            {
                MessageBox.Show("Every Room Has to have atleast 'TV', 'Bathroom', 'Wi-Fi', 'Clean Towels' and 'Mini Bar'; Add these feature or create these features first");
                return;
            }
            if (newRoom.Features.Where(x => x.FeatureName.ToLower() == "tv" || x.FeatureName.ToLower() == "bathroom" || x.FeatureName.ToLower() == "wi-fi" || x.FeatureName.ToLower() == "clean towels" || x.FeatureName.ToLower() == "mini bar").ToList().Count < 5)
            {
                MessageBox.Show("Every Room Has to have atleast 'TV', 'Bathroom', 'Wi-Fi', 'Clean Towels' and 'Mini Bar'");
                return;
            }
            newRoom.RoomName = roomName;
            newRoom.Capacity = capacity;
            newRoom.PricePerDay = pricePerDay;
            db.Rooms.Add(newRoom);
            db.SaveChanges();
            MessageBox.Show("Room succesfully created!");
            Close();
        }
    }
}
