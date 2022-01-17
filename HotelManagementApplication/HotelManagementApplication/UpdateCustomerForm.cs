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
    public partial class UpdateCustomerForm : Form
    {
        private readonly HotelManagementApplicationDb db;
        private readonly Customer updatingCustomer;

        private string oldIdentity;
        private string oldPhoneNumer;
        public UpdateCustomerForm(HotelManagementApplicationDb db, Customer updatingCustomer)
        {
            InitializeComponent();
            this.db = db;
            this.updatingCustomer = updatingCustomer;
            LoadCustomerInfo();
            oldIdentity = updatingCustomer.IdentityNumber;//Update ederken ya kendi IdentityNumberı olmalı yada Herhangi diğer bir Customer'ın identityNumer'ı ile çakışmamalı
            oldPhoneNumer = updatingCustomer.PhoneNumber;//Update ederken ya kendi PhoneNumberı olmalı yada Herhangi diğer bir Customer'ın phoneNumber'ı ile çakışmamalı
        }

        private void LoadCustomerInfo()
        {
            dtpBirthDate.Value = updatingCustomer.BirthDate;
            txtFullName.Text = updatingCustomer.FullName;
            txtIdentityNumber.Text = updatingCustomer.IdentityNumber;
            txtPhoneNumber.Text = updatingCustomer.PhoneNumber;
            rdbMale.Checked = updatingCustomer.Gender == Gender.Male ? true : false;
            rdbFemale.Checked = updatingCustomer.Gender == Gender.Female ? true : false;
            txtDescription.Text = updatingCustomer.Description;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatingCustomerName = txtFullName.Text.Trim();
            string updatingCustomerIdentity = txtIdentityNumber.Text.Trim();
            string updatingCustomerPhoneNumber = txtPhoneNumber.Text.Trim();
            DateTime updatingCustomerBirthDate = dtpBirthDate.Value;
            var updatingGender = rdbMale.Checked ? Gender.Male : Gender.Female;
            string updatingCustomerDescription = txtDescription.Text.Trim();
            //Ayrı kontroller else-if olarak birleşmiyor
            if (string.IsNullOrEmpty(updatingCustomerName) || string.IsNullOrEmpty(updatingCustomerIdentity))
            {
                MessageBox.Show("Name and Identity Number fields are required!");
                return;
            }
            if (!IdentityNumberValidation(updatingCustomerIdentity))/*TC Kimlik No Kontrolü, bu elseIf yoruma alınabilir veya proje içindeki küçük program ile random tc üretilebilir*/
            {
                MessageBox.Show("Invalid Identity Number please check your identity number");
                return;
            }
            else if (oldIdentity != updatingCustomerIdentity)//Yeni bir identity girildiyse kontrol et yoksa etme
            {
                if (db.Customers.Any(x => x.IdentityNumber == updatingCustomerIdentity))//Ve yeni identity db'de başka biriyle eşleşiyorsa mesaj ver eşleşmiyorsa en alttaki if'den devam
                {
                    MessageBox.Show("There is another customer with this Identity Number please check your identity number");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(updatingCustomerPhoneNumber))//Telefon boş bırakılabilir, boş değilse kontrol yap
            {
                if (oldPhoneNumer != updatingCustomerPhoneNumber)
                {
                    if (db.Customers.Any(x => x.PhoneNumber == updatingCustomerPhoneNumber))
                    {
                        MessageBox.Show("There is another customer with this Phone Number please check your phone number");
                        return;
                    }
                }
            }
            if (updatingCustomerBirthDate.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Go back to Future");
                return;
            }

            updatingCustomer.FullName = updatingCustomerName;
            updatingCustomer.IdentityNumber = updatingCustomerIdentity;//try catch max 11 karakter?
            updatingCustomer.PhoneNumber = updatingCustomerPhoneNumber;
            updatingCustomer.BirthDate = updatingCustomerBirthDate;
            updatingCustomer.Gender = updatingGender;
            updatingCustomer.Description = updatingCustomerDescription;
            db.SaveChanges();
            MessageBox.Show("Customer succesfully updated!");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
