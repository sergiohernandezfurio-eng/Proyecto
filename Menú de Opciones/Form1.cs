using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Menú_de_Opciones
{
    public partial class Menu : Form
    {
        FlightPlanList miLista = new FlightPlanList();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void flightPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void introducirDatosDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Identificador";
            label2.Text = "Posición actual";
            label3.Text = "Posición final";
            label4.Text = "Velocidad";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Xi;
            int Yi;
            int Xf;
            int Yf;
            int v;
            try
            {
                xi = Convert.ToInt32(entrada.Text) * 2;
            }
            catch (FormatException)
            {
                MessageBox.Show("Format error");
                salida.Text = "Error";
                return;
            }
            ;

            MessageBox.Show("Plan de vuelo A introducido"); 
        }
    }
}
