using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_ornek_6___815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbSayilar1.Items.Clear();
            lbSayilar2.Items.Clear();

            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 != 0)
                {
                    lbSayilar1.Items.Add(i);
                }

                else
                {
                    lbSayilar2.Items.Add(i);
                }
            }
            
        }
    }
}
