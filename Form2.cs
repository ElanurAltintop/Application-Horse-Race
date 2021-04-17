using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            int atbirsoluzaklik, atikisoluzaklık, atucsolauzaklık, bitis;
            atbirsoluzaklik = pictureBox1.Left;
            atikisoluzaklık = pictureBox2.Left;
            atucsolauzaklık = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int atbirgenislik = pictureBox1.Width;
            int atikigenislik = pictureBox2.Width;
            int atucgenislik = pictureBox3.Width;
            int bitis = label5.Left;
            int miktar;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 10);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 10);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 10);



            if (pictureBox1.Left + pictureBox1.Width > pictureBox2.Left + pictureBox2.Width && pictureBox1.Left + pictureBox1.Width > pictureBox3.Left + pictureBox3.Width)
            {
                label6.Text = "Birinci at önde götürüyor yarışı";
            }
            if (pictureBox2.Left + pictureBox2.Width > pictureBox1.Left + pictureBox1.Width && pictureBox2.Left + pictureBox2.Width > pictureBox3.Left + pictureBox3.Width)
            {
                label6.Text = "ikinci at önde götürüyor yarışı";
            }
            if (pictureBox3.Left + pictureBox3.Width > pictureBox2.Left + pictureBox2.Width && pictureBox3.Left + pictureBox3.Width > pictureBox1.Left + pictureBox1.Width)
            {
                label6.Text = "ücüncü at önde götürüyor yarışı";
            }
            if (pictureBox1.Left + pictureBox1.Width >= bitis)
            {
                timer1.Enabled = false;
                label6.Text=" Birinci At";
                lblMiktar.Text = (int.Parse(cmbboxYatirilanMiktar.Text) * 3).ToString();
            }
            else if (pictureBox2.Left + pictureBox2.Width >= bitis)
            {
                timer1.Enabled = false;
               label6.Text="İkinci At";
                lblMiktar.Text = (int.Parse(cmbboxYatirilanMiktar.Text) * 3).ToString();
            }
            else if (pictureBox3.Left + pictureBox3.Width >= bitis)
            {
                timer1.Enabled = false;
                lblMiktar.Text = (int.Parse(cmbboxYatirilanMiktar.Text) * 3).ToString();
               label6.Text="Üçüncü At";
            }

            if(label6.Text==comboBox1.Text&& comboBox1.Text=="Birinci At")
           {
                label12.Text = cmbboxYatirilanMiktar.Text;
                lblMiktar.Text = cmbboxYatirilanMiktar.Text;
            }
            else if (label6.Text == comboBox1.Text && comboBox1.Text == "İkinci At")
            {
                label13.Text = cmbboxYatirilanMiktar.Text;
                lblMiktar.Text = cmbboxYatirilanMiktar.Text;
            }
            else if(label6.Text == comboBox1.Text && comboBox1.Text == "Üçüncü At")
            {
                label14.Text = cmbboxYatirilanMiktar.Text;
                lblMiktar.Text = cmbboxYatirilanMiktar.Text;
            }
            label21.Text = label6.Text;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
