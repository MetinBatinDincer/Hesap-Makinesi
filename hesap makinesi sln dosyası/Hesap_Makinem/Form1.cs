using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_Makinem
{
    public partial class Form1 : Form
    {
        float sayi1, sayi2, sonuc;
        bool temizlensinmi = false;
        char islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            
            ekranlabel.Text += "1";
            temizlensinmi = false;
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "2";
            temizlensinmi = false;
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "3";
            temizlensinmi = false;
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "4";
            temizlensinmi = false;
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "5";
            temizlensinmi = false;
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "6";
            temizlensinmi = false;
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "7";
            temizlensinmi = false;
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "8";
            temizlensinmi = false;
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "9";
            temizlensinmi = false;
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            if (temizlensinmi == true) ekranlabel.Text = "";
            ekranlabel.Text += "0";
            temizlensinmi = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            islem = '+';
            temizlensinmi = true;
            sayi1 = Convert.ToInt32(ekranlabel.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (islem == '+')
            {
                sayi2 = Convert.ToInt32(ekranlabel.Text);
                sonuc = sayi1 + sayi2;
                ekranlabel.Text = sonuc.ToString();
            }

            if (islem == '-')
            {
                sayi2 = Convert.ToInt32(ekranlabel.Text);
                sonuc = sayi1 - sayi2;
                ekranlabel.Text = sonuc.ToString();
            }

            if (islem == '*')
            {
                sayi2 = Convert.ToInt32(ekranlabel.Text);
                sonuc = sayi1 * sayi2;
                ekranlabel.Text = sonuc.ToString();
            }
            if (islem == '/')
            {
                sayi2 = Convert.ToInt32(ekranlabel.Text);
                sonuc = sayi1 / sayi2;
                ekranlabel.Text = sonuc.ToString();
            }
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            islem = '-';
            temizlensinmi = true;
            sayi1 = Convert.ToInt32(ekranlabel.Text);
        }

        private void carpbutton_Click(object sender, EventArgs e)
        {
            islem = '*';
            temizlensinmi = true;
            sayi1 = Convert.ToInt32(ekranlabel.Text);
        }

        private void bolbutton_Click(object sender, EventArgs e)
        {
            islem = '/';
            temizlensinmi = true;
            sayi1 = Convert.ToInt32(ekranlabel.Text);
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
