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
    public partial class CreateReservationForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        private DateTime startDate;
        private DateTime endDate;
        private Reservation newReservation;

        public CreateReservationForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            newReservation = new Reservation();
            dtpStartDate.MinDate = DateTime.Now.Date;//Otel sitelerinde geçmiş tarihli reservasyon oluşturulmuyor o yüzden tarihi kısıtladım
            dtpStartDate.Value = DateTime.Now.Date;// dtp eventini tetikliyerek odaları listelemek için ve dtpEndDate'i kısıtlamak için
            LoadAllServices();
            LoadAllCustomers();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1).Date;
            endDate = dtpEndDate.Value.Date;
            LoadRooms();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value.Date;
            LoadRooms();
        }

        private void LoadRooms()// Seçili tarih aralığıyla reservasyon tarihleri çakışmayan odaları listeler
        {
            if (db.Rooms.Any())
            {
                if (db.Rooms.ToList().Any(y => !y.Reservations.Any(x => endDate.Date > x.CheckInDate.Date && x.CheckOutDate.Date > startDate.Date)))
                {
                    cmbRooms.DataSource = db.Rooms.ToList().Where(y => !y.Reservations.Any(x => endDate.Date > x.CheckInDate.Date && x.CheckOutDate.Date > startDate.Date)).OrderBy(k=>k.RoomName).ToList();
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
            if (newReservation.ReservationServices.Any())
            {
                dgvReservationServices.DataSource = newReservation.ReservationServices.Select(k => new
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
            if (newReservation.ReservationCustomers.Count > 0)
            {
                dgvReservationCustomers.DataSource = newReservation.ReservationCustomers.Select(x => new
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
                if (newReservation.ReservationCustomers.Count > 0)
                {
                    dgvAllCustomers.DataSource = db.Customers.ToList().Where(x => newReservation.ReservationCustomers.All(x2 => x2.Id != x.Id)).Select(x => new
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
                if (newReservation.ReservationCustomers.Count > 0)
                {
                    dgvAllCustomers.DataSource = db.Customers
                        .ToList()//DbSet Hatası almamak için
                        .Where(x => x.FullName.ToLower().Contains(searchedCustomereName) && newReservation.ReservationCustomers.All(x2 => x2.Id != x.Id))
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
                if (newReservation.ReservationCustomers.Count > 0)
                {
                    dgvReservationCustomers.DataSource = newReservation.ReservationCustomers
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
                if (newReservation.ReservationServices.Any())
                {
                    string searchedReservationServiceName = txtSearchReservationService.Text.ToLower().Trim();
                    dgvReservationServices.DataSource = newReservation.ReservationServices
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
            newReservation.ReservationServices.Add(reservationService);
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
            string reservationServiceName = (string)dgvReservationServices.SelectedRows[0].Cells[0].Value;
            decimal reservationServiceTotalPrice = (decimal)dgvReservationServices.SelectedRows[0].Cells[1].Value;
            decimal reservationServiceQuantity = (decimal)dgvReservationServices.SelectedRows[0].Cells[2].Value;
            ReservationService reservationService = newReservation.ReservationServices.FirstOrDefault(x => x.ServiceName == reservationServiceName && x.ServiceTotalPrice == reservationServiceTotalPrice && x.Quantity == reservationServiceQuantity);
            newReservation.ReservationServices.Remove(reservationService);
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
            newReservation.ReservationCustomers.Add(customer);
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
            newReservation.ReservationCustomers.Remove(customer);
            LoadReservationCustomers();
            LoadAllCustomers();
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (!newReservation.ReservationCustomers.Any())
            {
                MessageBox.Show("Cant create a reservation without a customer, Please add atleast 1 Customer");
                return;
            }
            if (newReservation.Room == null)
            {
                MessageBox.Show("You have to select a room! If there is no avaliable room change dates or create new Room");
                return;
            }

            newReservation.CheckInDate = startDate;
            newReservation.CheckOutDate = endDate;
            db.Reservations.Add(newReservation);
            db.SaveChanges();
            MessageBox.Show("Reservation succesfully created!");
            Close();
        }


        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedIndex == -1) return;
            Room room = (Room)cmbRooms.SelectedItem;
            newReservation.Room = room;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
