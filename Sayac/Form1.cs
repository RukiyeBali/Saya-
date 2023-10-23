using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnYap_Click(object sender, EventArgs e) 
        {
            lstSayac.Items.Clear();
            
            int baslangic=Convert.ToInt32(txtBasla.Text); 

            int bitis=Convert.ToInt32(txtBitis.Text);

            for(int i = baslangic; i <= bitis; i++)
            {
                lstSayac.Items.Add(i);
            }
        }
    }
}
