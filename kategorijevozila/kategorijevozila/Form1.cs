using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kategorijevozila
{
    public partial class Form1 : Form
    {
        private int motorcyclesCount = 0;
        private int carsCount = 0;
        private int trucksCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            
            txtIspis.Clear();
        }
        private void btnObradi_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            int year;
            int numberOfWheels;

            
            if (!int.TryParse(txtGodinaProizvodnje.Text, out year))
            {
                MessageBox.Show("Molimo unesite valjanu godinu proizvodnje.");
                return;
            }
            
            if (!int.TryParse(txtBrojKotaca.Text, out numberOfWheels) || numberOfWheels % 2 != 0 || numberOfWheels < 2)
            {
                MessageBox.Show("Molimo unesite valjan broj kotača (parni i veći od 0).");
                return;
            }
            
            string category;
            if (numberOfWheels == 2)
            {
                category = "Motocikl";
                motorcyclesCount++;
            }
            else if (numberOfWheels == 4)
            {
                category = "Automobil";
                carsCount++;
            }
            else
            {
                category = "Kamion";
                trucksCount++;
            }
            
            txtIspis.AppendText($"Model: {model}, Godina: {year}, Kotača: {numberOfWheels}, Kategorija: {category}\n");
        }
        private void btnIspis_Click(object sender, EventArgs e)
        {
            
            txtIspis.AppendText($"\nUkupan broj vozila:\n");
            txtIspis.AppendText($"Motocikli: {motorcyclesCount}\n");
            txtIspis.AppendText($"Automobili: {carsCount}\n");
            txtIspis.AppendText($"Kamioni: {trucksCount}\n");
        }
    }
}
