using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank.Classes
{
    public interface Observer
    {
        void Notify(string Hastane);
    }
    public class Donör
    {
        public Donör(string adsoyad, BloodType bloodType, İlçeler ilçe,string mail)
        {
            this.AdSoyad = adsoyad;
            this.BloodType = bloodType;
            this.İlçe = ilçe;
            this.MailAddress = mail;
        }
        public string AdSoyad { get; set; }
        public İlçeler İlçe { get; set; }
        public BloodType BloodType { get; set; }
        public string MailAddress { get; set; }
    }
    public class DtN : Donör, Observer
    {
        public DtN(string adsoyad, BloodType bloodType, İlçeler ilçe,string mail) : base(adsoyad, bloodType, ilçe,mail)
        { }
        public void Notify(string Hastane)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("prof1998@hotmail.com", "12345678-b");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage mailMessage = new MailMessage(new MailAddress("prof1998@hotmail.com"), new MailAddress(MailAddress));
            mailMessage.Subject = "AcilKanİhtiyacı";
            mailMessage.Body = Hastane + "'nde Acil Kan ihtiyacı";
            smtpClient.Send(mailMessage);
        }
    }
}
