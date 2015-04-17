using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champignon
{
    public partial class Form1 : Form
    {
        private Champignon _Fighter;
        private Champignon _marksMan;

        public Form1()
        {
            InitializeComponent();
            _Fighter = new Champignon("Hercules", 100, 10, Roles.Fighter, 1);
            _marksMan = new Champignon("Robin Hood", 100, 10, Roles.Marksman, 1);

            //Initializing left character
            lblNameLeft.Text = _Fighter.Naam;
            lblLevelLeft.Text = Convert.ToString(_Fighter.Level);
            healthBarLeft.Value = Convert.ToInt32(_Fighter.Health);


            //Initializing Right character
            lblNameRight.Text = _marksMan.Naam;
            lblLevelRight.Text = Convert.ToString(_marksMan.Level);
            healthBarRight.Value = Convert.ToInt32(_marksMan.Health);

        }

        private void btnLeftAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnRightAttack_Click(object sender, EventArgs e)
        {

        }
    }
}
