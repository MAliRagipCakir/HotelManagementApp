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
    public partial class RoomsForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        public RoomsForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            LoadRooms();
        }

        private void LoadRooms()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                txtSearch.Text = "";
            if (!db.Rooms.Any())
            {
                dgvRooms.DataSource = null;
                return;
            }
            dgvRooms.DataSource = db.Rooms.ToList()
                .Select(x => new
                {
                    x.Id,
                    x.RoomName,
                    x.Capacity,
                    x.PricePerDay,
                    Features = string.Join(", ", x.Features.Select(p => p.FeatureName))
                }).ToList();
            dgvRooms.Columns[1].HeaderText = "Room Name";
            dgvRooms.Columns[3].HeaderText = "Price Per Day";

            dgvRooms.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                LoadRooms();
            else
            {
                string searchedRoomName = txtSearch.Text.ToLower().Trim();
                if (!db.Rooms.Any())
                {
                    dgvRooms.DataSource = null;
                }
                else if (!db.Rooms.Any(x => x.RoomName.ToLower().Contains(searchedRoomName)))
                {
                    dgvRooms.DataSource = null;
                }
                else
                {
                    dgvRooms.DataSource = db.Rooms.ToList()
                         .Where(x => x.RoomName.ToLower().Contains(searchedRoomName))
                         .Select(x => new
                         {
                             x.Id,
                             x.RoomName,
                             x.Capacity,
                             x.PricePerDay,
                             Features = x.Features.Count > 0 ? string.Join(", ", x.Features.Select(p => p.FeatureName)) : ""
                         }).ToList();
                    dgvRooms.Columns[1].HeaderText = "Room Name";
                    dgvRooms.Columns[3].HeaderText = "Price Per Day";

                    dgvRooms.Columns[3].DefaultCellStyle.Format = "C2";
                }
            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            new CreateRoomForm(db).ShowDialog();
            LoadRooms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a Room to update");
                return;
            }
            int roomId = (int)dgvRooms.SelectedRows[0].Cells[0].Value;
            Room updatingRoom = db.Rooms.Find(roomId);
            new UpdateRoomForm(db, updatingRoom).ShowDialog();
            LoadRooms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a Room to delete");
                return;
            }
            int roomId = (int)dgvRooms.SelectedRows[0].Cells[0].Value;
            Room deletingRoom = db.Rooms.Find(roomId);
            db.Rooms.Remove(deletingRoom);
            db.SaveChanges();
            MessageBox.Show("Room deleted!");
            LoadRooms();
        }
    }
}
