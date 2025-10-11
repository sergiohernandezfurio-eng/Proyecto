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

        public void Simular_Load (object sender, EventArgs e)
        {
            //MessageBox.Show("");
            vuelos = new PictureBox[miLista.GetNumero()];
            int i = 0;
            while (i< miLista.GetNumero())
            {
                //representar vuelo en poscición i
                PictureBox p= new PictureBox();
                FlightPlan f= miLista.GetFlightPlan(i);

                //Configurar el picture box

                p.Width = 20;
                p.Height = 20;
                p.ClientSize = new Size(20, 20);

                //ubicación
                p.Location = new Point(Convert.ToInt32(f.GetInitialPosition().GetX()), Convert.ToInt32(f.GetInitialPosition().GetY()));

                // Adjust the image size to 20x20
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                //the file should be in the debug folder
                Bitmap image = new Bitmap("avion2.png");
                p.Image = (Image)image;
                miPanel.Controls.Add(p);
                vuelos[i] = p;

                i++;
            }

        }

    }
}
