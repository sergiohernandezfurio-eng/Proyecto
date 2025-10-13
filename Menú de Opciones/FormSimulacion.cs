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
    public partial class FormSimulacion : Form
    {

        FlightPlanList miLista;
        int tiempo;
        Point lastPoint;
        public double distanciaSeguridad; // radio del círculo de seguridad

        public void SetDistancia(double d)
        {
            distanciaSeguridad = d;
        }


        //Picture boxes para representar los vuelos
        PictureBox[] vuelos;

        public FormSimulacion()
        {
            InitializeComponent();
        }

        public void SetData(FlightPlanList f, int c)
        {
            miLista = f;
            tiempo = c;
        }

        private void FormSimulacion_Load_1(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            vuelos = new PictureBox[miLista.GetNumero()];
            int i = 0;
            while (i < miLista.GetNumero())
            {
                //representar vuelo en poscición i
                PictureBox p = new PictureBox();
                FlightPlan f = miLista.GetFlightPlan(i);

                //Configurar el picture box

                p.Width = 40;
                p.Height = 40;
                p.ClientSize = new Size(40, 40);

                //ubicación
                p.Location = new Point(Convert.ToInt32(f.GetInitialPosition().GetX()), Convert.ToInt32(f.GetInitialPosition().GetY()));

                // Adjust the image size to 40x40
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                //the file should be in the debug folder
                Bitmap image = new Bitmap("avion2.png");
                p.Image = (Image)image;
                miPanel.Controls.Add(p);

                p.Tag = i;
                p.Click += new System.EventHandler(this.ShowFlightInfo);

                vuelos[i] = p;


                i=i+1;
            }
            miPanel.Invalidate();

        }
        private void ShowFlightInfo(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            FlightPlan_Information f = new FlightPlan_Information();
            f.setFlightPlan(miLista.GetFlightPlan(i));
            f.ShowDialog();
        }


        private void btnCiclo_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            while (i < miLista.GetNumero())
            {
                //representar vuelo en poscición i
                PictureBox p = new PictureBox();
                FlightPlan f = miLista.GetFlightPlan(i);
                
                //ubicación
                
                vuelos[i].Location = new Point(Convert.ToInt32(f.GetCurrentPosition().GetX()), Convert.ToInt32(f.GetCurrentPosition().GetY()));

                i = i + 1;

            }

        }

        private void miPanel_Paint(object sender, PaintEventArgs e)
        {
            if (miLista == null || vuelos == null) return;

            Graphics g = e.Graphics;
            Pen penLinea = new Pen(Color.Red, 2); // líneas de trayectoria
            Pen penElipse = new Pen(Color.Blue, 2); // círculo de seguridad

            int i = 0;
            while (i < miLista.GetNumero())
            {
                FlightPlan f = miLista.GetFlightPlan(i);

                // 1️⃣ Línea de trayectoria
                Point origen = new Point((int)f.GetInitialPosition().GetX(), (int)f.GetInitialPosition().GetY());
                Point destino = new Point((int)f.GetFinalPosition().GetX(), (int)f.GetFinalPosition().GetY());
                g.DrawLine(penLinea, origen, destino);

                // 2️⃣ Círculo de seguridad
                PictureBox avión = vuelos[i];
                int centroX = avión.Location.X + avión.Width / 2;
                int centroY = avión.Location.Y + avión.Height / 2;
                int radio = (int)distanciaSeguridad;

                g.DrawEllipse(penElipse, centroX - radio, centroY - radio, radio * 2, radio * 2);

                i++;
            }

            penLinea.Dispose();
            penElipse.Dispose();
        }
    }
}
