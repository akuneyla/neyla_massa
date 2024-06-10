using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neyla_massa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btHasil_Click(object sender, EventArgs e)
        {
            double hasil = 0;
            int Kg, Ons, Kwintal, Ton;

            if (cbDari.SelectedItem == "Kg" && cbKe.SelectedItem == "Ons")
            {
                hasil = int.Parse(txNilai.Text) * 10;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kg" && cbKe.SelectedItem == "Kg")
            {
                hasil = int.Parse(txNilai.Text);
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kg" && cbKe.SelectedItem == "Kwintal")
            {
                hasil = int.Parse(txNilai.Text) / 100;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kg" && cbKe.SelectedItem == "Ton")
            {
                hasil = double.Parse(txNilai.Text) / 1000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ons" && cbKe.SelectedItem == "Ons")
            {
                hasil = int.Parse(txNilai.Text);
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ons" && cbKe.SelectedItem == "Kg")
            {
                hasil = int.Parse(txNilai.Text) / 10;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ons" && cbKe.SelectedItem == "Kwintal")
            {
                hasil = double.Parse(txNilai.Text) / 1000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ons" && cbKe.SelectedItem == "Ton")
            {
                hasil = double.Parse(txNilai.Text) / 10000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kwintal" && cbKe.SelectedItem == "Kwintal")
            {
                hasil = int.Parse(txNilai.Text);
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kwintal" && cbKe.SelectedItem == "Kg")
            {
                hasil = int.Parse(txNilai.Text) * 100;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kwintal" && cbKe.SelectedItem == "Ons")
            {
                hasil = int.Parse(txNilai.Text) * 1000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Kwintal" && cbKe.SelectedItem == "Ton")
            {
                hasil = int.Parse(txNilai.Text) / 10;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ton" && cbKe.SelectedItem == "Ton")
            {
                hasil = int.Parse(txNilai.Text);
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ton" && cbKe.SelectedItem == "Kg")
            {
                hasil = int.Parse(txNilai.Text) * 1000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ton" && cbKe.SelectedItem == "Ons")
            {
                hasil = int.Parse(txNilai.Text) * 10000;
                txHasil.Text = hasil.ToString();
            }
            else if (cbDari.SelectedItem == "Ton" && cbKe.SelectedItem == "Kwintal")
            {
                hasil = int.Parse(txNilai.Text) * 10;
                txHasil.Text = hasil.ToString();
            }
        }

        private void btBersih_Click(object sender, EventArgs e)
        {
            txHasil.Text = "";
            txNilai.Text = "";
            cbDari.Text = "";
            cbKe.Text = "";
        }
    }
}
