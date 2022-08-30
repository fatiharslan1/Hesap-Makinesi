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

namespace hesapmakinesi
{

    public partial class Form1 : Form
    {
        private char _islem;
        private bool  _ekrantemizlenecek;
        private int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if(_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek)
            {
                textBox1.Text = "";
                _ekrantemizlenecek = false;
            }
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "0";
        }
        //toplama
        private void button14_Click(object sender, EventArgs e)
        {
            try
            { 
            _islem = '+';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
            }
        }
        //cıkartma
        private void button15_Click(object sender, EventArgs e)
        {
            try 
            { 
            _islem = '-';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
            }
        }
        //bolme
        private void button18_Click(object sender, EventArgs e)
        {
            try
            { 
            _islem = '/';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
            }
        }
        //carpma
        private void button17_Click(object sender, EventArgs e)
        {
            try
            { 
            _islem = '*';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz");
            }
        }
        //esittir
        private void button13_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(textBox1.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            textBox1.Text = Convert.ToString(sonuc);
        }
        //temizleme
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //silme 
        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text.Length > 0)
           {
               textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
           }

          //  textBox1.Text = textBox1.Text.ToString().Remove(textBox1.Text.ToString().Length - 1, 1);
        }
    }

}
