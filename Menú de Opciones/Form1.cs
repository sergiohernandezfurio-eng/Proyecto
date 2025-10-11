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
        FlightPlan plan_a;
        FlightPlan plan_b;
        double distancia;
        int tiempo;

        int contadorPlanes = 0; //Contador para los dos planes de vuelo
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
            label6.Text = "";
            label7.Text = "";
            label5.Text = "";
            label8.Text = "";

            xi.Visible = false;
            yi.Visible = false;
            xf.Visible = false;
            yf.Visible = false;
            vtext.Visible = false;
            id.Visible = false;
            textDistancia.Visible = false;
            textTiempo.Visible = false;
            btnIntroducir.Visible = false;
            btnGuardar.Visible = false;
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
            label6.Text = "X";
            label7.Text = "Y";
            label5.Text = "";
            label8.Text = "";

            xi.Visible = true;
            yi.Visible = true;
            xf.Visible = true;
            yf.Visible = true;
            vtext.Visible = true;
            id.Visible = true;
            textDistancia.Visible = false;
            textTiempo.Visible = false;
            btnIntroducir.Visible = true;
            btnGuardar.Visible = false;

            MessageBox.Show("Introduzca el plan de vuelo A.");
        }

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

          

                contadorPlanes++;

                if (contadorPlanes==1)
                {
                    plan_a= new FlightPlan(identificador, Xi, Yi, Xf, Yf, V);
                    miLista.AddFlightPlan(plan_a);
                    MessageBox.Show("Plan de vuelo A introducido correctamente.");
                    xi.Text = "";
                    yi.Text = "";
                    xf.Text = "";
                    yf.Text = "";
                    vtext.Text = "";
                    id.Text = "";
                    MessageBox.Show("Introduzca el plan de vuelo B.");

                }

                else if (contadorPlanes==2)
                {
                    plan_b = new FlightPlan(identificador, Xi, Yi, Xf, Yf, V);
                    MessageBox.Show("Plan de vuelo B introducido correctamente.");
                    xi.Text = "";
                    yi.Text = "";
                    xf.Text = "";
                    yf.Text = "";
                    vtext.Text = "";
                    id.Text = "";
                    miLista.AddFlightPlan(plan_b);
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

        private void distanciaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";
            label7.Text = "";
            label5.Text = "Distancia";
            label8.Text = "Tiempo de ciclo";

            xi.Visible = false;
            yi.Visible = false;
            xf.Visible = false;
            yf.Visible = false;
            vtext.Visible = false;
            id.Visible = false;
            textDistancia.Visible = true;
            textTiempo.Visible = true;
            btnIntroducir.Visible = false;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int ciclos = 2;

                distancia = Convert.ToDouble(textDistancia.Text);
                tiempo = Convert.ToInt32(textTiempo.Text);

                MessageBox.Show("Distancia y tiempo guardados correctamente.");

                while (i < ciclos)
                {
                    miLista.Mover(tiempo);

                    miLista.EscribeConsola();

                    if (plan_a.conflictoProximidad(plan_b, distancia))
                        MessageBox.Show("EXISTE CONFLICTO DE PROXIMIDAD.");

                    i = i + 1;
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Format error");
                textDistancia.Text = "Error";
                textTiempo.Text = "Error";
                return;
            }
            ;
        }

        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSimulacion formSim = new FormSimulacion();
            formSim.SetData(miLista, tiempo);
            formSim.Show();
        }
    }
}
