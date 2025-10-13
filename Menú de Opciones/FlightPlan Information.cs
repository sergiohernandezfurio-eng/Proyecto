using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú_de_Opciones
{
    public partial class FlightPlan_Information : Form
    {
        FlightPlan vuelo;
        public FlightPlan_Information()
        {
            InitializeComponent();
        }
        public void setFlightPlan(FlightPlan v)
        {
            this.vuelo = v;
        }
        private void FlightPlan_Information_Load(object sender, EventArgs e)
        {
            Xbox.Text = Convert.ToString(vuelo.GetCurrentPosition().GetX());
            Ybox.Text = Convert.ToString(vuelo.GetCurrentPosition().GetY());
            Vbox.Text = Convert.ToString(vuelo.GetVelocidad());
            flightNumberBox.Text = vuelo.GetId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
