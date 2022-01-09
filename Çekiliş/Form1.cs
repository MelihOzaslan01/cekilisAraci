using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çekiliş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cekilisSay = 1;
        private void adaylarRtxt_TextChanged(object sender, EventArgs e)
        {
            cekilisLbl.Text = adaylarRtxt.Lines.Count().ToString();
            if (adaylarRtxt.Lines.Count()>0)
            {
                numericUpDown1.Maximum = adaylarRtxt.Lines.Count()-1;

            }
            else
            {
                numericUpDown1.Minimum = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstDgw.ColumnCount = 2;
            LstDgw.Columns[0].Name = "Sıra No";
            LstDgw.Columns[1].Name = "Ad Soyad";

        }

        private void baslatBtn_Click(object sender, EventArgs e)
        {
           
            int cekilisSayisi = Convert.ToInt32(numericUpDown1.Text);
            List<string> ListAdaylar = new List<string>(adaylarRtxt.Text.Split('\n'));




            if (adaylarRtxt.Text == "")
            {
                MessageBox.Show("Adayları Girmelisiniz!");
            }
            else
            {
                Random rnd = new Random();

                for (int i = 0; i < cekilisSayisi; i++)
                {
                  int kazananAday= rnd.Next(0,ListAdaylar.Count);
                    LstDgw.Rows.Add(cekilisSay++, ListAdaylar[kazananAday]);
                    ListAdaylar.Remove(ListAdaylar[kazananAday]);






                }
            }
                


                
        }

         private void temizleBtn_Click(object sender, EventArgs e)
        {
            adaylarRtxt.Clear();
            LstDgw.Rows.Clear();
            cekilisSay = 1;
            numericUpDown1.Value = 1;

            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = adaylarRtxt.Lines.Count();
        }
    }
}
