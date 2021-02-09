using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBank.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox3.DataSource = Enum.GetValues(typeof(İlçeler));
            this.comboBox6.DataSource = Enum.GetValues(typeof(İlçeler));
        }
        private void DonörOlmaButton_Click(object sender, EventArgs e)
        {
            object rh = null;
            switch (comboBox2.Text)
            {
                case "Rh(-)":
                    rh = Rhfaktörü.RhNegatif;
                    break;
                case "Rh(+)":
                    rh = Rhfaktörü.RhPozitif;
                    break;
                default:
                    break;
            }
            BloodType bloodType = new BloodType((Rhfaktörü)rh, (KanGrubu)Enum.Parse(typeof(KanGrubu), comboBox1.Text));
            var a = (İlçeler)comboBox6.SelectedValue;
            if (new EmailAddressAttribute().IsValid(this.textBox2.Text) && checkBox2.Checked && checkBox3.Checked)
            {
                string[] vs = { textBox1.Text, (bloodType.KanGrubu.ToString() + bloodType.Rhfaktörü.ToString()), textBox2.Text, comboBox6.SelectedValue.ToString() };
                listView1.Items.Add(new ListViewItem(vs));
                if (checkBox1.Checked)
                {
                    DtN dt = new DtN(textBox1.Text, bloodType, a, textBox2.Text);
                    Donörler.BilgilendirilecekDonörler.Add(dt);

                }
                else
                {
                    Donör dt = new Donör(textBox1.Text, bloodType, a, textBox2.Text);
                    Donörler.NormalDonörler.Add(dt);
                }
            }
            else
            {
                MessageBox.Show("Not Valid");
            }
        }
        private void Acilbutton(object sender, EventArgs e)
        {
            object rh = null;
            switch (comboBox5.Text)
            {
                case "Rh(-)":
                    rh = Rhfaktörü.RhNegatif;
                    break;
                case "Rh(+)":
                    rh = Rhfaktörü.RhPozitif;
                    break;
                default:
                    break;
            }
            BloodType bloodType = new BloodType((Rhfaktörü)rh, (KanGrubu)Enum.Parse(typeof(KanGrubu), comboBox4.Text));
            Acilİhtiyaç ihtiyaç = new Acilİhtiyaç(bloodType, Scraping.GetHospitalsİnİstanbul().First(x => x.İsim.Trim() == comboBox7.Text.Trim()));
            ihtiyaç.NotifyObservers();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Items.Clear();
            List<string> vs = new List<string>();
            foreach (var item in Scraping.GetHospitalsİnİstanbul().Where(x => x.İlçe == (İlçeler)comboBox3.SelectedValue))
            {
                vs.Add(item.İsim);
            }
            comboBox7.Items.AddRange(vs.ToArray());
        }
    }
}
