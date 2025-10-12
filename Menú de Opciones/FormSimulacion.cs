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
            miLista.Mover(tiempo);

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

        }
    }
}
