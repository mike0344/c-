using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h8_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oppButton_Click(object sender, EventArgs e)
        {
            try
            {
                double hoogte = double.Parse(oppHeight.Text);
                double breedte = double.Parse(oppWidth.Text);
                oppResult.Text = "Oppervlakte: " + (hoogte * breedte).ToString();
                oppError.Text = "";
            } catch
            {
                oppError.Text = "Error: De invoervelden zijn niet goed ingevoerd! Alleen (komma)getallen!";
            }
          
        }

        private void omtButton_Click(object sender, EventArgs e)
        {
            try
            {
                double hoogte = double.Parse(omtHeight.Text)*2;
                double breedte = double.Parse(omtWidth.Text)*2;
                omtResult.Text = "Omtrek: " + (hoogte + breedte).ToString();
                omtError.Text = "";
            }
            catch
            {
                omtError.Text = "Error: De invoervelden zijn niet goed ingevoerd! Alleen (komma)getallen!";
            }
        }
    }
}
