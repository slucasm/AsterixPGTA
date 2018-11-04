using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaClases;

namespace Asterix
{
    public partial class AircraftInformation : Form
    {
        public AircraftInformation(CAT10 cat10,CAT20 cat20,CAT21 cat21)
        {
            InitializeComponent();
            this.cat10 = cat10;
            this.cat20 = cat20;
            this.cat21 = cat21;
        }

        CAT10 cat10;
        CAT20 cat20;
        CAT21 cat21;

        private void AircraftInformation_Load(object sender, EventArgs e)
        {
            if (cat10 != null)
            {

            }
            else if (cat20 != null)
            {

            }
            else if (cat21 != null)
            {

            }

        }
    }
}
