using System;
using System.Windows.Forms;

namespace Nesne_Tabanli_Programlama_OOP_Projesi_Otogar_Hesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Taksi");
            comboBox1.Items.Add("Minibüs");
            comboBox1.Items.Add("Otobüs");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen araç türü seçiniz.");
                return;
            }
            int outval = 0;
            if (textBox1.Text == null || !(int.TryParse(textBox1.Text, out outval)))
            {
                MessageBox.Show("Kalış süresi hatalı girildi.");
                return;
            }
            if (!(checkBox1.Checked) && !(checkBox2.Checked) && !(checkBox3.Checked))
            {
                MessageBox.Show("İndirim oranı seçmek zorundasınız.");
                return;
            }
            double toplam_tutar = 0, indirim_tutar = 0, odenmesi_gereken = 0;
            if (comboBox1.SelectedItem == "Taksi")
            {
                toplam_tutar = 2 + (Convert.ToDouble(textBox1.Text) * 5);
                if (checkBox1.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 25;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox2.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 50;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox3.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 75;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
            }
            else if (comboBox1.SelectedItem == "Minibüs")
            {
                toplam_tutar = 3 + (Convert.ToDouble(textBox1.Text) * 7);
                if (checkBox1.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 25;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox2.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 50;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox3.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 75;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
            } else if (comboBox1.SelectedItem == "Otobüs")
            {
                toplam_tutar = 5 + (Convert.ToDouble(textBox1.Text) * 10);
                if (checkBox1.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 25;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox2.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 50;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
                else if (checkBox3.Checked)
                {
                    indirim_tutar = toplam_tutar / 100 * 75;
                    odenmesi_gereken = toplam_tutar - indirim_tutar;
                }
            }
            label7.Text = toplam_tutar.ToString();
            label8.Text = indirim_tutar.ToString();
            label9.Text = odenmesi_gereken.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            textBox1.Text = null;
            comboBox1.SelectedIndex = -1;
        }
    }
}
