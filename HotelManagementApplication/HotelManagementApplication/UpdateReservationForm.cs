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
    public partial class UpdateReservationForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private readonly Reservation updatingReservation;

        private DateTime startDate;
        private DateTime endDate;

        private DateTime checkedInTime;
        private DateTime checkedOutTime;

        public UpdateReservationForm(HotelManagementApplicationDb db, Reservation updatingReservation)
        {
            InitializeComponent();
            this.db = db;
            this.updatingReservation = updatingReservation;
            // Bu Formda 4 dtp ve 4 ayrı tarih ile kontrol yapmak biraz zorluydu, Burda Hata çıkabilir
            dtpStartDate.MinDate = updatingReservation.CheckInDate.Date;//Geçmişe yönelik tarih değişimi yapılması mantıklı gelmedi
            dtpStartDate.Value = updatingReservation.CheckInDate.Date;
            dtpEndDate.Value = updatingReservation.CheckOutDate.AddSeconds(1).Date;

            dtpCheckIn.MinDate = dtpStartDate.Value.Date;
            dtpCheckIn.MaxDate = dtpEndDate.Value.Date;
            dtpCheckOut.MinDate = dtpCheckIn.Value.Date;
            dtpCheckOut.MaxDate = dtpEndDate.Value.Date;

            if (updatingReservation.CheckInTime != null)
            {
                dtpCheckIn.Value = updatingReservation.CheckInTime.Value.Date;
                chkCheckedIn.Checked = true;
            }
            if (updatingReservation.CheckOutTime != null)
            {
                dtpCheckOut.Value = updatingReservation.CheckOutTime.Value.Date;
                chkCheckedOut.Checked = true;
            }

            LoadRooms();//Aslında LoadRooms eventi dtp'leri tarihlerini kısıtlamaya çalışırken 2-3 sefer tetikleniyor ama alttaki sorguyu garantiye almak için safety olarak çağırdım
            if (cmbRooms.DataSource != null)
            {
                cmbRooms.SelectedItem = updatingReservation.Room;
            }
            LoadAllServices();
            LoadAllCustomers();

            LoadReservationServices();
            LoadReservationCustomers();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)//CheckInDate
        {
            startDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1).Date;
            dtpCheckIn.MinDate = dtpStartDate.Value.Date;
            dtpCheckOut.MinDate = dtpCheckIn.Value.Date;
            checkedInTime = dtpCheckIn.Value.Date;
            checkedOutTime = dtpCheckOut.Value.Date;
            endDate = dtpEndDate.Value.Date;
            LoadRooms();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)//CheckOutDate
        {
            endDate = dtpEndDate.Value.Date;
            dtpCheckIn.MaxDate = dtpEndDate.Value.Date;
            dtpCheckOut.MaxDate = dtpEndDate.Value.Date;
            checkedInTime = dtpCheckIn.Value.Date;
            checkedOutTime = dtpCheckOut.Value.Date;
            LoadRooms();
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            checkedInTime = dtpCheckIn.Value.Date;
            dtpCheckOut.MinDate = dtpCheckIn.Value.Date;
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            checkedOutTime = dtpCheckOut.Value.Date;
        }

        private void LoadRooms()// Seçili tarih aralığında boş olan odaları listeler (Update olduğu için gelen reservasyon tarihleri haricinde bakar)
        {
            if (db.Rooms.Any())
            {
                if (db.Rooms.ToList().Any(y => !y.Reservations.Where(k => k.Id != updatingReservation.Id).Any(x => endDate.Date > x.CheckInDate.Date && x.CheckOutDate.Date > startDate.Date)))
                {
                    cmbRooms.DataSource = db.Rooms.ToList().Where(y => !y.Reservations.Where(k => k.Id != updatingReservation.Id).Any(x => endDate.Date > x.CheckInDate.Date && x.CheckOutDate.Date > startDate.Date)).OrderBy(z => z.RoomName).ToList();
                    cmbRooms.DisplayMember = "RoomName";
                }
                else
                {
                    cmbRooms.DataSource = null;
                }
            }
        }

        private void LoadReservationServices()
        {
            if (!string.IsNullOrEmpty(txtSearchReservationService.Text))
                txtSearchReservationService.Text = "";
            if (updatingReservation.ReservationServices.Any())
            {
                dgvReservationServices.DataSource = updatingReservation.ReservationServices.Select(k => new
                {
                    k.ServiceName,
                    k.ServiceTotalPrice,
                    k.Quantity
                }).ToList();
                dgvReservationServices.Columns[0].HeaderText = "Service Name";
                dgvReservationServices.Columns[1].HeaderText = "Unit Price";
                dgvReservationServices.Columns[1].DefaultCellStyle.Format = "C2";
                dgvReservationServices.Columns[2].DefaultCellStyle.Format = "N2";
            }
            else
                dgvReservationServices.DataSource = null;
        }

        private void LoadAllServices()
        {
            if (!string.IsNullOrEmpty(txtSearchAllService.Text))
                txtSearchAllService.Text = "";
            if (db.Services.Any())
            {
                dgvAllServices.DataSource = db.Services.Select(k => new
                {
                    k.Id,
                    k.ServiceName,
                    k.UnitPrice
                }).ToList();
                dgvAllServices.Columns[1].HeaderText = "Service Name";
                dgvAllServices.Columns[2].HeaderText = "Unit Price";
                dgvAllServices.Columns[2].DefaultCellStyle.Format = "C2";
            }
            else
                dgvAllServices.DataSource = null;
        }

        private void LoadReservationCustomers()
        {
            if (!string.IsNullOrEmpty(txtSearchReservationCustomer.Text))
                txtSearchReservationCustomer.Text = "";
            if (updatingReservation.ReservationCustomers.Count > 0)
            {
                dgvReservationCustomers.DataSource = updatingReservation.ReservationCustomers.Select(x => new
                {
                    x.Id,
                    x.FullName,
                    x.IdentityNumber,
                    x.PhoneNumber,
                    x.Gender,
                }).ToList();
                dgvReservationCustomers.Columns[1].HeaderText = "Full Name";
                dgvReservationCustomers.Columns[2].HeaderText = "Identity Number";
                dgvReservationCustomers.Columns[3].HeaderText = "Phone Number";
            }
            else
            {
                dgvReservationCustomers.DataSource = null;
            }
        }

        private void LoadAllCustomers()
        {
            if (!string.IsNullOrEmpty(txtSearchAllCustomer.Text))
                txtSearchAllCustomer.Text = "";
            if (db.Customers.Any())
            {
                if (updatingReservation.ReservationCustomers.Count > 0)
                {
                    dgvAllCustomers.DataSource = db.Customers.ToList().Where(x => updatingReservation.ReservationCustomers.All(x2 => x2.Id != x.Id)).Select(x => new
                    {
                        x.Id,
                        x.FullName,
                        x.IdentityNumber,
                        x.PhoneNumber,
                        x.Gender,
                    }).ToList();
                    dgvAllCustomers.Columns[1].HeaderText = "Full Name";
                    dgvAllCustomers.Columns[2].HeaderText = "Identity Number";
                    dgvAllCustomers.Columns[3].HeaderText = "Phone Number";
                }
                else
                {
                    dgvAllCustomers.DataSource = db.Customers.Select(x => new
                    {
                        x.Id,
                        x.FullName,
                        x.IdentityNumber,
                        x.PhoneNumber,
                        x.Gender,
                    }).ToList();
                    dgvAllCustomers.Columns[1].HeaderText = "Full Name";
                    dgvAllCustomers.Columns[2].HeaderText = "Identity Number";
                    dgvAllCustomers.Columns[3].HeaderText = "Phone Number";
                }
            }
            else
            {
                dgvAllCustomers.DataSource = null;
            }

        }

        private void txtSearchAllCustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAllCustomer.Text))
                LoadAllCustomers();
            else
            {
                if (!db.Customers.Any())
                {
                    dgvAllCustomers.DataSource = null;
                    return;
                }
                string searchedCustomereName = txtSearchAllCustomer.Text.ToLower().Trim();
                if (updatingReservation.ReservationCustomers.Count > 0)
                {
                    dgvAllCustomers.DataSource = db.Customers
                        .ToList()//DbSet Hatası almamak için
                        .Where(x => x.FullName.ToLower().Contains(searchedCustomereName) && updatingReservation.ReservationCustomers.All(x2 => x2.Id != x.Id))
                        .Select(x => new
                        {
                            x.Id,
                            x.FullName,
                            x.IdentityNumber,
                            x.PhoneNumber,
                            x.Gender,
                        }).ToList();
                    dgvAllCustomers.Columns[1].HeaderText = "Full Name";
                    dgvAllCustomers.Columns[2].HeaderText = "Identity Number";
                    dgvAllCustomers.Columns[3].HeaderText = "Phone Number";
                }
                else
                {
                    dgvAllCustomers.DataSource = db.Customers
                        .Where(x => x.FullName.ToLower().Contains(searchedCustomereName))
                        .Select(x => new
                        {
                            x.Id,
                            x.FullName,
                            x.IdentityNumber,
                            x.PhoneNumber,
                            x.Gender,
                        }).ToList();
                    dgvAllCustomers.Columns[1].HeaderText = "Full Name";
                    dgvAllCustomers.Columns[2].HeaderText = "Identity Number";
                    dgvAllCustomers.Columns[3].HeaderText = "Phone Number";
                }
            }
        }

        private void txtSearchReservationCustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchReservationCustomer.Text))
                LoadReservationCustomers();
            else
            {
                string searchedReservationCustomerName = txtSearchReservationCustomer.Text.ToLower().Trim();
                if (updatingReservation.ReservationCustomers.Count > 0)
                {
                    dgvReservationCustomers.DataSource = updatingReservation.ReservationCustomers
                        .Where(x => x.FullName.ToLower().Contains(searchedReservationCustomerName))
                        .Select(x => new
                        {
                            x.Id,
                            x.FullName,
                            x.IdentityNumber,
                            x.PhoneNumber,
                            x.Gender,
                        }).ToList();
                    dgvReservationCustomers.Columns[1].HeaderText = "Full Name";
                    dgvReservationCustomers.Columns[2].HeaderText = "Identity Number";
                    dgvReservationCustomers.Columns[3].HeaderText = "Phone Number";
                }
                else
                {
                    dgvReservationCustomers.DataSource = null;
                }
            }
        }

        private void txtSearchAllService_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAllService.Text))
                LoadAllServices();
            else
            {
                if (db.Services.Any())
                {
                    string searchedServiceName = txtSearchAllService.Text.ToLower().Trim();
                    dgvAllServices.DataSource = db.Services
                        .Where(x => x.ServiceName.ToLower().Contains(searchedServiceName))
                        .Select(x => new
                        {
                            x.Id,
                            x.ServiceName,
                            x.UnitPrice
                        }).ToList();
                    dgvAllServices.Columns[1].HeaderText = "Service Name";
                    dgvAllServices.Columns[2].HeaderText = "Unit Price";
                    dgvAllServices.Columns[2].DefaultCellStyle.Format = "C2";
                }
                else
                    dgvAllServices.DataSource = null;
            }
        }

        private void txtSearchReservationService_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchReservationService.Text))
                LoadReservationServices();
            else
            {
                if (updatingReservation.ReservationServices.Any())
                {
                    string searchedReservationServiceName = txtSearchReservationService.Text.ToLower().Trim();
                    dgvReservationServices.DataSource = updatingReservation.ReservationServices
                        .Where(x => x.ServiceName.ToLower().Contains(searchedReservationServiceName))
                        .Select(k => new
                        {
                            k.ServiceName,
                            k.ServiceTotalPrice,
                            k.Quantity
                        }).ToList();
                    dgvReservationServices.Columns[0].HeaderText = "Service Name";
                    dgvReservationServices.Columns[1].HeaderText = "Unit Price";
                    dgvReservationServices.Columns[1].DefaultCellStyle.Format = "C2";
                    dgvReservationServices.Columns[2].DefaultCellStyle.Format = "N2";
                }
                else
                    dgvReservationServices.DataSource = null;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (dgvAllServices.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a service to add");
                return;
            }
            int serviceeId = (int)dgvAllServices.SelectedRows[0].Cells[0].Value;
            Service service = db.Services.Find(serviceeId);
            ReservationService reservationService = new ReservationService();
            reservationService.Service = service;
            reservationService.ServiceName = service.ServiceName;
            reservationService.Quantity = nudServiceQuantity.Value;
            reservationService.ServiceTotalPrice = service.UnitPrice * reservationService.Quantity;
            updatingReservation.ReservationServices.Add(reservationService);
            db.SaveChanges();
            LoadReservationServices();
            LoadAllServices();
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (dgvReservationServices.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a reservation service to remove");
                return;
            }
            //Create ederken Id'yi kullanamadığımdan(reservationService db'de olmayınca Id=0) ordaki kodu buraya kopyaladım burda'da Id'den çekmektense hazır kodu kullandım
            string reservationServiceName = (string)dgvReservationServices.SelectedRows[0].Cells[0].Value;
            decimal reservationServiceTotalPrice = (decimal)dgvReservationServices.SelectedRows[0].Cells[1].Value;
            decimal reservationServiceQuantity = (decimal)dgvReservationServices.SelectedRows[0].Cells[2].Value;
            ReservationService reservationService = updatingReservation.ReservationServices.FirstOrDefault(x => x.ServiceName == reservationServiceName && x.ServiceTotalPrice == reservationServiceTotalPrice && x.Quantity == reservationServiceQuantity);
            updatingReservation.ReservationServices.Remove(reservationService);
            db.SaveChanges();
            LoadReservationServices();
            LoadAllServices();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (dgvAllCustomers.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a customer to add");
                return;
            }
            int customerId = (int)dgvAllCustomers.SelectedRows[0].Cells[0].Value;
            Customer customer = db.Customers.Find(customerId);
            updatingReservation.ReservationCustomers.Add(customer);
            db.SaveChanges();
            LoadReservationCustomers();
            LoadAllCustomers();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (dgvReservationCustomers.SelectedRows.Count == -1)
            {
                MessageBox.Show("Please Select a customer to remove");
                return;
            }
            int customerId = (int)dgvReservationCustomers.SelectedRows[0].Cells[0].Value;
            Customer customer = db.Customers.Find(customerId);
            updatingReservation.ReservationCustomers.Remove(customer);
            db.SaveChanges();
            LoadReservationCustomers();
            LoadAllCustomers();
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (!updatingReservation.ReservationCustomers.Any())
            {
                MessageBox.Show("Cant create a reservation without a customer, Please add atleast 1 Customer");
                return;
            }
            if (updatingReservation.Room == null)
            {
                MessageBox.Show("You have to select a room! If there is no avaliable room change dates or create new Room");
                return;
            }

            if (chkCheckedIn.Checked)
                updatingReservation.CheckInTime = checkedInTime;
            else
                updatingReservation.CheckInTime = null;

            if (chkCheckedOut.Checked)
                updatingReservation.CheckOutTime = checkedOutTime;
            else
                updatingReservation.CheckOutTime = null;

            updatingReservation.CheckInDate = startDate;
            updatingReservation.CheckOutDate = endDate;
            db.SaveChanges();
            MessageBox.Show("Reservation succesfully updated!");
            Close();
        }


        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedIndex == -1)
            {
                updatingReservation.Room = null;
                db.SaveChanges();
            }
            Room room = (Room)cmbRooms.SelectedItem;
            updatingReservation.Room = room;
            db.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
