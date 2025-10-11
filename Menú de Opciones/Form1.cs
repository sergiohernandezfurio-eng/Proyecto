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
            label6.Text = "";
            label7.Text = "";
        }

        private void flightPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void introducirDatosDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Identificador";
            label2.Text = "Posición inicial";
            label3.Text = "Posición final";
            label4.Text = "Velocidad";
            label5.Text = "";
            label6.Text = "X";
            label7.Text = "Y";
        }

        int contadorPlanes = 0; //Contador para los dos planes de vuelo
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                double Xi;
                double Yi;
                double Xf;
                double Yf;
                double V;

                string identificador = id.Text;

                Xi = Convert.ToDouble(xi.Text);
                Yi = Convert.ToDouble(yi.Text);
                Xf = Convert.ToDouble(xf.Text);
                Yf = Convert.ToDouble(yf.Text);

                V = Convert.ToDouble(vtext.Text);

                FlightPlan plan = new FlightPlan(identificador, Xi, Yi, Xf, Yf, V);

                contadorPlanes++;

                if (contadorPlanes==1)
                {
                    MessageBox.Show("Plan de vuelo A introducido correctamente.");
                    xi.Text = "";
                    yi.Text = "";
                    xf.Text = "";
                    yf.Text = "";
                    vtext.Text = "";
                    id.Text = "";
                }

                else if (contadorPlanes==2)
                {
                    MessageBox.Show("Plan de vuelo B introducido correctamente.");
                    xi.Text = "";
                    yi.Text = "";
                    xf.Text = "";
                    yf.Text = "";
                    vtext.Text = "";
                    id.Text = "";

                    contadorPlanes = 0;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Format error");
                xi.Text = "Error";
                yi.Text = "Error";
                xf.Text = "Error";
                yf.Text = "Error";
                vtext.Text = "Error";
                return;
            }
            ;

        }
    }
}
