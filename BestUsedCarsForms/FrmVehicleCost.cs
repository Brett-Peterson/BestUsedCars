using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestUsedCarsForms
{
    public partial class FrmVehicleCost : Form
    {
        public FrmVehicleCost()
        {
            InitializeComponent();
        }

        private void btnUpdateCost_Click(object sender, EventArgs e)
        {
            UpdateVehicleCostAsync();
        }
    }
}
