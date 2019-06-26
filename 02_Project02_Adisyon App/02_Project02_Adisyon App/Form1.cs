using System;
using System.Windows.Forms;

namespace _02_Project02_Adisyon_App
{
    public partial class Form1 : Form
    {
        #region Parameters

        double DF = 20, KF = 6.5, CF = 3, IF = 45, QF = 15,ALF=18,TF=100;

        double Toplam; // Bütün Adisyon Toplamını Tutacak
        double NetPara;
        double MP;

        #endregion

        #region Form Events

        public Form1()
        {
            InitializeComponent();
        }


        #endregion

        #region Btn Events

        private void BtnCash_Click(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                Toplam = Toplam + (DF * double.Parse(textBox1.Text));
            }

            if (checkBox2.Checked == true)
            {
                Toplam = Toplam + (KF * double.Parse(textBox2.Text));
            }

            if (checkBox3.Checked == true)
            {
                Toplam = Toplam + (CF * double.Parse(textBox3.Text));
            }

            if (checkBox4.Checked == true)
            {
                Toplam = Toplam + (IF * double.Parse(textBox4.Text));
            }

            if (checkBox5.Checked == true)
            {
                Toplam = Toplam + (QF * double.Parse(textBox5.Text));
            }

            if (checkBox6.Checked == true)
            {
                Toplam = Toplam + (TF * double.Parse(textBox7.Text));
            }

            if (checkBox7.Checked == true)
            {
                Toplam += ALF * Convert.ToDouble(textBox8.Text);
            }

            
            groupBox1.Enabled = false;

            groupBox2.Enabled = true;
            
            LblCash.Text = Toplam.ToString()+" TL"; // Burasoı Ödenecek Toplam Parayı Tutuyor

            textBox6.Focus();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            NetPara += Toplam;
            LblMoney.Text = NetPara.ToString() + "TL";

            LblCash.Text = "0 TL";
            textBox6.Text = "0";
            LblPU.Text = "0 TL";
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;

            Toplam = 0;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

            
        }

        #endregion

        #region CheckBox Event

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
            }

            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
            }

            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
            }

            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Focus();
            }

            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LblMoney.Text = "0";
            NetPara = 0;

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true )
            {
                textBox8.Enabled = true;
                textBox8.Focus();
            }

            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0"; 
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true )

            {
                textBox7.Enabled = true;
                textBox7.Focus();
            }

            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
            }

            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }

        }

        #endregion

        #region Text Events
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                MP = Convert.ToDouble(textBox6.Text);


                if (MP >= Toplam)
                {
                    LblPU.Text = (MP - Toplam).ToString();
                    BtnCancel.Enabled = true;

                }

                else
                {
                    BtnCancel.Enabled = false;
                    LblPU.Text = "0 TL";
                }

            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion
    }
}
