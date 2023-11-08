using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace Banka_Sıra_Al___Çagıran_Vezne_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int redValue = 0;
        private int greenValue = 0;
        private int blueValue = 255;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBanka.Text = textBanka.Text.Substring(1) + textBanka.Text.Substring(0, 1);
            Color newColor = Color.FromArgb(redValue, greenValue, blueValue);
            textBanka.ForeColor = newColor;
            redValue = (redValue + 1) % 256;
            greenValue = (greenValue + 2) % 256;
            blueValue = (blueValue + 3) % 256;
        }
        public void Listele()
        {
            listNumaralar.Items.Clear();
            foreach (int item in kuyruk)
            {
                listNumaralar.Items.Add(item);
            }
        }
        Queue kuyruk = new Queue();
        int sıra1 = 0;
        int sıra2 = 150;
        int sıra3 = 300;
        int sıra4 = 450;
        int sıra5 = 600;
        int sıra6 = 750;


        private void buttonSıra_Click(object sender, EventArgs e)
        {            
            if (radioButton1.Checked)
            {
                sıra1++;
                kuyruk.Enqueue(sıra1);
                Listele();
                if (sıra1 == 149)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
            else if (radioButton2.Checked)
            {
                sıra2++;
                kuyruk.Enqueue(sıra2);
                Listele();
                if (sıra2 == 299)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
            else if (radioButton3.Checked)
            {
                sıra3++;
                kuyruk.Enqueue(sıra3);
                Listele();
                if (sıra3 == 449)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
            else if (radioButton4.Checked)
                 {
                sıra4++;
                kuyruk.Enqueue(sıra4);
                Listele();
                if (sıra4 == 599)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
           else  if (radioButton5.Checked)
            {
                sıra5++;
                kuyruk.Enqueue(sıra5);
                Listele();
                if (sıra5 == 749)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
            else if (radioButton6.Checked)
            {
                sıra6++;
                kuyruk.Enqueue(sıra6);
                Listele();
                if (sıra6 == 899)
                {
                    buttonSıra.Enabled = false;
                    MessageBox.Show("Günlük Sınıra Ulaştı.. Sıra Verilmemektedir.. Yarın Tekrar Geliniz..");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir İşlem Türü Seçiniz..");
            }
        }

        private void buttonCagır_Click(object sender, EventArgs e)
        {
            if (listNumaralar.Items.Count > 0)
            {
                var a = (int)kuyruk.Dequeue();
                labelSıra.Text = a.ToString();
                Listele();

                Random random = new Random();
                int randomVezneIndex = random.Next(1, 10);
                labelVezne.Text = "Vezne " + randomVezneIndex.ToString();
                
            }
            else
            {
                MessageBox.Show("Lütfen Önce Sıra Alınız..");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioİslem.Checked = true;
            if (listNumaralar == null)
            {
                buttonCagır.Enabled = false;
            }
        }        
    }
}
