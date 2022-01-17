using HotelManagementApplication.Enums;
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
    public partial class CustomersForm : Form
    {
        private readonly HotelManagementApplicationDb db;

        public CustomersForm(HotelManagementApplicationDb db)
        {
            InitializeComponent();
            this.db = db;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
                txtSearch.Text = "";
            if (!db.Customers.Any())
            {
                dgvCustomers.DataSource = null;
                return;
            }
            dgvCustomers.DataSource = db.Customers
                .Select(x => new
                {
                    x.Id,
                    x.FullName,
                    x.IdentityNumber,
                    x.PhoneNumber,
                    x.Gender,
                    x.BirthDate,
                    x.Description
                }).ToList();
            dgvCustomers.Columns[1].HeaderText = "Full Name";
            dgvCustomers.Columns[2].HeaderText = "Identity Number";
            dgvCustomers.Columns[3].HeaderText = "Phone Number";
            dgvCustomers.Columns[5].HeaderText = "Birth Date";

            dgvCustomers.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count != 1) return;
            if (e.RowIndex == -1) return;
            int customerId = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;
            Customer updatingCustomer = db.Customers.Find(customerId);
            new UpdateCustomerForm(db, updatingCustomer).ShowDialog();
            LoadCustomers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                LoadCustomers();
            else
            {
                string searchedCustomerName = txtSearch.Text.ToLower().Trim();
                if (!db.Customers.Any())
                {
                    dgvCustomers.DataSource = null;
                    return;
                }

                dgvCustomers.DataSource = db.Customers
                    .Where(x => x.FullName.ToLower().Contains(searchedCustomerName))
                    .Select(x => new
                    {
                        x.Id,
                        x.FullName,
                        x.IdentityNumber,
                        x.PhoneNumber,
                        x.Gender,
                        x.BirthDate,
                        x.Description
                    }).ToList();
                dgvCustomers.Columns[1].HeaderText = "Full Name";
                dgvCustomers.Columns[2].HeaderText = "Identity Number";
                dgvCustomers.Columns[3].HeaderText = "Phone Number";
                dgvCustomers.Columns[5].HeaderText = "Birth Date";

                dgvCustomers.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newCustomerName = txtFullName.Text.Trim();
            string newCustomerIdentity = txtIdentityNumber.Text.Trim();
            string newCustomerPhoneNumber = txtPhoneNumber.Text.Trim();
            DateTime newCustomerBirthDate = dtpBirthDate.Value;
            var gender = rdbMale.Checked ? Gender.Male : Gender.Female;
            string newCustomerDescription = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(newCustomerName) || string.IsNullOrEmpty(newCustomerIdentity))
            {
                MessageBox.Show("Name and Identity Number fields are required!");
                return;
            }
            else if (!IdentityNumberValidation(newCustomerIdentity))/*TC Kimlik No Kontrolü, bu elseIf yoruma alınabilir veya proje içindeki küçük program ile random tc üretilebilir*/
            {
                MessageBox.Show("Invalid Identity Number please check your identity number");
                return;
            }
            else if (db.Customers.Any(x => x.IdentityNumber == newCustomerIdentity))
            {
                MessageBox.Show("There is another customer with this Identity Number please check your identity number");
                return;
            }
            else if (!string.IsNullOrEmpty(newCustomerPhoneNumber))
            {
                if (db.Customers.Any(x => x.PhoneNumber == newCustomerPhoneNumber))
                {
                    MessageBox.Show("There is another customer with this Phone Number please check your phone number");
                    return;
                }
            }
            else if (newCustomerBirthDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Go back to Future");
                return;
            }
            Customer newCustomer = new Customer()
            {
                FullName = newCustomerName,
                IdentityNumber = newCustomerIdentity,
                PhoneNumber = newCustomerPhoneNumber,
                BirthDate = newCustomerBirthDate,
                Gender = gender,
                Description = newCustomerDescription
            };
            db.Customers.Add(newCustomer);
            ClearForm();
            db.SaveChanges();
            MessageBox.Show("Customer succesfully added!");
            LoadCustomers();
        }

        private void ClearForm()
        {
            dtpBirthDate.Value = DateTime.Now;
            txtFullName.Text = "";
            txtIdentityNumber.Text = "";
            txtPhoneNumber.Text = "";
            rdbMale.Checked = true;
            txtDescription.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select a Customer to delete");
                return;
            }
            int customerId = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;
            Customer deletingCustomer = db.Customers.Find(customerId);
            db.Customers.Remove(deletingCustomer);
            db.SaveChanges();
            MessageBox.Show("Customer deleted!");
            LoadCustomers();
        }

        /// <summary>
        /// Tc kimlik kontrolü,eski bir projeden alındı ve uyarlandı, Proje klasörü içinde Tc kimlik üreten küçük bir program var
        /// </summary>
        /// <param name="identityNumber"></param>
        /// <returns></returns>
        private bool IdentityNumberValidation(string identityNumber)
        {
            try
            {
                long rakamlar = Convert.ToInt64(identityNumber);
            }
            catch (Exception)
            {
                return false;
            }

            //Toplam 11 Basamak Kontrolü
            bool toplam11Basamak = false;
            if ((identityNumber.Length == 11))
                toplam11Basamak = true;
            else
                return false;

            //10.Basamak Kontrol
            int tekler = 0;
            int ciftler = 0;
            for (int i = 0; i < 9; i++)//ilk 9 hanenin tekler(1.3.5.7.9. basamaklar) ve çiftler(2.4.6.8. basamaklar)toplamı
                if (i % 2 == 0)
                    tekler += Convert.ToInt32(identityNumber[i].ToString());
                else
                    ciftler += Convert.ToInt32(identityNumber[i].ToString());

            int onuncuBasamak = Convert.ToInt32(identityNumber[9].ToString());
            bool onuncuBasamakKontrol;
            if ((tekler * 7 - ciftler) % 10 == onuncuBasamak)
                onuncuBasamakKontrol = true;
            else
                onuncuBasamakKontrol = false;

            //İlk Hane 0 kontrolü
            int ilkHane = Convert.ToInt32(identityNumber[0].ToString()); ;
            bool ilkHaneKontrol;
            if (ilkHane != 0)
                ilkHaneKontrol = true;
            else
                ilkHaneKontrol = false;

            //11.Basamak Kontrolü
            int onbirinciBasamak = Convert.ToInt32(identityNumber[10].ToString());
            bool onbirinciBasamakKontrol;
            if ((tekler + ciftler + onuncuBasamak) % 10 == onbirinciBasamak)
                onbirinciBasamakKontrol = true;
            else
                onbirinciBasamakKontrol = false;

            //TC Kontrol: diğer tüm durumların doğru olması durumu
            if (toplam11Basamak && ilkHaneKontrol && onuncuBasamakKontrol && onbirinciBasamakKontrol)
                return true;
            else
                return false;
        }
    }
}
