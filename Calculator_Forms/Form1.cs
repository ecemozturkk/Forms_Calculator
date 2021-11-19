using System;
using System.Windows.Forms;

namespace Calculator_Forms
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            optDurum = false;
            if(txtSonuc.Text=="0")
            {
                txtSonuc.Text = "0";

            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";

            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            //MessageBox.Show("Tusa tiklandi");
            if (txtSonuc.Text == "0" || optDurum) //0 girdisini tekte tutmak
                txtSonuc.Clear();
            optDurum = false;

            Button btn = (Button)sender; //butonun degerini alma
            txtSonuc.Text += btn.Text; //degeri txtSonuc alanina yazdirma

        }

        private void lbSonuc_Click(object sender, EventArgs e)
        {

        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender; //butonun degerini alma
            string yeniOpt = btn.Text;

            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch(opt)
            {
                case "+":txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "÷":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "";
            sonuc = 0;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+":
                    txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "*":
                    txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString();
                    break;
                case "÷":
                    txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString();
                    break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = ""; //hafizadaki bilgiyi temizler
        }

        private void Hover(object sender, EventArgs e)
        {

        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
