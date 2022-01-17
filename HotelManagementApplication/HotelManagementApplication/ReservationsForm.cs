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
    public partial class ReservationsForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private DateTime startDate;
        private DateTime endDate;
        private string roomOrCustomerName;
        public ReservationsForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            dtpStartDate.Value = DateTime.Now.Date;//Value change eventi ile listeleme ve diğer dtp'nin tarih ayarını değiştirmeyi tetiklemek için
            dtpEndDate.Value = DateTime.Now.AddDays(6).Date;//.Date'ler tarihlerdeki saat çakışmalarından kurtulmak için
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1).Date;
            LoadReservationsWithFilters();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value.Date;
            LoadReservationsWithFilters();
        }

        private void LoadReservationsWithFilters()
        {
            if (!db.Reservations.Any())
            {
                dgvReservations.DataSource = null;
                return;
            }
            if (string.IsNullOrEmpty(roomOrCustomerName))
            {
                if (rdbInAll.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k=>k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInAll.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckOutTime == null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInAll.Checked && rdbOutYes.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckOutTime != null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null && x.CheckOutTime == null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutYes.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null && x.CheckOutTime != null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null && x.CheckOutTime == null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutYes.Checked)
                {
                    //Check-in yapmadan check-out yapan müşteri olamaz ama belki hatalı reservasyon güncellemesi yapıldıysa görülsün
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null && x.CheckOutTime != null).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                    MessageBox.Show("These reservations needs a Check-In time please fix them");
                }
                else
                    dgvReservations.DataSource = null;// Buraya hiç gelmemesi lazım çünkü radio buttonlar desing'dan seçili olarak geliyorlar 2 sinden biri veya 2 sinin seçili olmama durumu kalkmış olarak geliyor
            }
            else//Text ile arama yapılıyorsa
            {
                //Yukardaki ++ where içinde ekstra && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName)||x.ReservationCustomers.Any(y=> y.FullName.ToLower().Contains(roomOrCustomerName))).Select...
                if (rdbInAll.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInAll.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckOutTime == null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInAll.Checked && rdbOutYes.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckOutTime != null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null && x.CheckOutTime == null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInYes.Checked && rdbOutYes.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime != null && x.CheckOutTime != null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutAll.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutNo.Checked)
                {
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null && x.CheckOutTime == null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                }
                else if (rdbInNo.Checked && rdbOutYes.Checked)
                {
                    //Check-in yapmadan check-out yapan müşteri olamaz ama belki hatalı reservasyon güncellemesi yapıldıysa görülsün
                    dgvReservations.DataSource = db.Reservations.ToList().Where(x => x.CheckInDate.Date >= startDate.Date && x.CheckOutDate.Date <= endDate.Date && x.CheckInTime == null && x.CheckOutTime != null && (x.Room.RoomName.ToLower().Contains(roomOrCustomerName) || x.ReservationCustomers.Any(y => y.FullName.ToLower().Contains(roomOrCustomerName)))).Select(y => new
                    {
                        y.Id,
                        Room = y.Room.RoomName,
                        y.CheckInDate,
                        y.CheckOutDate,
                        CheckedIn = y.CheckInTime == null ? "No" : "Yes",
                        CheckedOut = y.CheckOutTime == null ? "No" : "Yes",
                        Customers = string.Join(", ", y.ReservationCustomers.Select(k => k.FullName)),
                        Services = y.ReservationServices.Count != 0 ? string.Join(", ", y.ReservationServices.Select(m => m.ServiceName)) : "",
                        y.ReservationTotalPrice
                    }).OrderByDescending(k => k.CheckInDate).ToList();
                    dgvReservations.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                    dgvReservations.Columns[8].DefaultCellStyle.Format = "C2";
                    MessageBox.Show("These reservations needs a Check-In time please fix them");
                }
                else
                    dgvReservations.DataSource = null;// Buraya hiç gelmemesi lazım çünkü radio buttonlar desing'dan seçili olarak geliyorlar 2 sinden biri veya 2 sinin seçili olmama durumu kalkmış olarak geliyor
            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            new CreateReservationForm(db).ShowDialog();
            LoadReservationsWithFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a Reservation to update");
                return;
            }
            int reservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
            Reservation updatingReservation = db.Reservations.Find(reservationId);
            new UpdateReservationForm(db, updatingReservation).ShowDialog();
            LoadReservationsWithFilters();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a Reservation to delete");
                return;
            }
            int reservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
            Reservation deletingReservation = db.Reservations.Find(reservationId);
            db.Reservations.Remove(deletingReservation);
            db.SaveChanges();
            MessageBox.Show("Reservation deleted!");
            LoadReservationsWithFilters();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            roomOrCustomerName = txtSearch.Text.Trim().ToLower();
            LoadReservationsWithFilters();
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)// 6 radio button tek event'e bağlı
        {
            LoadReservationsWithFilters();
        }
    }
}
