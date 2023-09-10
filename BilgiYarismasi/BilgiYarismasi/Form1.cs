using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int soruno = 0 , dogru = 0, yanlis =0;

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;


            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnNext.Enabled = true;


            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;



            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblNo.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "2 + 2";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "4";
                label4.Text = "4";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresi?";
                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "Adana";
                btnD.Text = "İzmir";
                label4.Text = "Ankara";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiye'de kaç bölge vardır? ";
                btnA.Text = "7";
                btnB.Text = "3";
                btnC.Text = "6";
                btnD.Text = "4";
                label4.Text = "7";
                btnNext.Text = "Sonuçşar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Dogru :" + dogru + "\n" + "Yanlış :" + yanlis);

            }
        }
    }
}
