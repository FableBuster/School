using System;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Champignon.Properties;
using WMPLib;

namespace Champignon
{
    public partial class Form1 : Form
    {
         // Sound files
         WindowsMediaPlayer mainTheme = new WindowsMediaPlayer();
         WindowsMediaPlayer fatalitySound = new WindowsMediaPlayer();
         WindowsMediaPlayer roundHouseKick = new WindowsMediaPlayer();
         WindowsMediaPlayer upperCut = new WindowsMediaPlayer();
         WindowsMediaPlayer saiyanSounds = new WindowsMediaPlayer();
       
        //fields
        private readonly Champignon _fighter;
        private readonly Champignon _marksMan;
        
        public Form1()
        {
            InitializeComponent();
            
            Color color = ColorTranslator.FromHtml("#06B025");

            healthBarLeft.BackColor = color;
            healthBarRight.BackColor = color;
            lblLeftHealth.BackColor = color;
            lblRightHealth.BackColor = color;

        

            //Form background color
            BackColor = Color.DarkSlateGray;

            //Initializing background theme
            mainTheme.URL = "rocky.mp3";
            mainTheme.controls.play();
            

            //initializing champions
            _fighter = new Champignon("Hercules", 200, 10, Roles.Fighter, 1);
            _marksMan = new Champignon("Robin Hood", 200, 10, Roles.Marksman, 1);

            //Initializing left character
            lblNameLeft.Text = _fighter.Naam;
            lblLevelLeft.Text = Convert.ToString(_fighter.Level);
            healthBarLeft.Value = Convert.ToInt32(_fighter.Health);
            lblLeftHealth.Text = _fighter.Health.ToString();


            //Initializing Right character
            lblNameRight.Text = _marksMan.Naam;
            lblLevelRight.Text = Convert.ToString(_marksMan.Level);
            healthBarRight.Value = Convert.ToInt32(_marksMan.Health);
            lblRightHealth.Text = _marksMan.Health.ToString();  
        }

        private void btnLeftAttack_Click(object sender, EventArgs e)
        {
            roundHouseKick.URL = "roundhousekick.mp3";
            lblsuperSaiyan.Text = "";

            try
            {
                roundHouseKick.controls.play();
                double damage = _fighter.AttackDamage;
                _marksMan.ReceiveDamage(damage);
                healthBarRight.Value = (int) _marksMan.Health;
                UpdateInformation();
            }
            catch(Exception)
            {
                Gewonnen();
            }
        }

        private void btnRightAttack_Click(object sender, EventArgs e)
        {
            upperCut.URL = "uppercut.mp3";
            lblsuperSaiyan.Text = "";

            try
            {
                upperCut.controls.play();
                double damage = _marksMan.AttackDamage;
                _fighter.ReceiveDamage(damage);
                healthBarLeft.Value = (int) _fighter.Health;
                UpdateInformation();
            }
            catch (Exception)
            {
                Gewonnen();
            }
         
        }

        private void Gewonnen()
        {
            fatalitySound.URL = "fatality.mp3";
            if (_fighter.Health <= 0)
            {
                saiyanSounds.controls.stop();
                DisableButtons();
                string winnersName = lblNameRight.Text;
                string losersName = lblNameLeft.Text;
                string winnaar = String.Format("Fatality, {0} has won this round. {1} you suck! ", winnersName, losersName);
                lblLeftHealth.Text = 0.ToString();
                healthBarLeft.Value = 0;
                mainTheme.controls.pause();
                fatalitySound.controls.play();
                MessageBox.Show(winnaar, winnersName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainTheme.controls.play();
            }
            else if (_marksMan.Health <= 0)
            {
                saiyanSounds.controls.stop();
                fatalitySound.controls.play();
                DisableButtons();
                string winnersName = lblNameLeft.Text;
                string losersName = lblNameRight.Text;
                string winnaar = String.Format("Fatality, {0} has won this round. {1} you suck! ", winnersName, losersName);
                lblRightHealth.Text = 0.ToString();
                healthBarRight.Value = 0;
                mainTheme.controls.pause();
                fatalitySound.controls.play();
                MessageBox.Show(winnaar, winnersName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mainTheme.controls.play(); 
            }
            
        }

        private void btnLeftLevelUp_Click(object sender, EventArgs e)
        {
            saiyanSounds.URL = "saiyan.mp3";
            saiyanSounds.controls.play();
            pictureBox1.Image = Properties.Resources._219596_large___superSaiyan;
            _fighter.ChangeLevel(2);
            healthBarLeft.Maximum = Convert.ToInt32(_fighter.Health);
            btnLeftLevelUp.Enabled = false;
            string super = String.Format("{0} Transformed\n into supersaiyan!", _fighter.Naam);
            lblsuperSaiyan.Text = super;
            UpdateInformation();
        }

        private void btnRightLevelUp_Click(object sender, EventArgs e)
        {
            saiyanSounds.URL = "saiyan.mp3";
            saiyanSounds.controls.play();
            pictureBox2.Image = Properties.Resources.Annex___Flynn__Errol__Adventures_of_Robin_Hood__The__02_superSaiyan;
            _marksMan.ChangeLevel(2);
            healthBarRight.Maximum = Convert.ToInt32(_marksMan.Health);
            btnRightLevelUp.Enabled = false;
            string super = String.Format("{0} Transformed\n into supersaiyan!", _marksMan.Naam);
            lblsuperSaiyan.Text = super;
            UpdateInformation();
        }

        private void UpdateInformation()
        {
            lblLeftHealth.Text = _fighter.Health.ToString();
            lblLevelLeft.Text = _fighter.Level.ToString();
            healthBarLeft.Text = _fighter.Health.ToString();
            lblRightHealth.Text = _marksMan.Health.ToString();
            lblLevelRight.Text = _marksMan.Level.ToString();
            healthBarRight.Text = _marksMan.Health.ToString();
            if (_fighter.Health <= 150)
            {
                lblLeftHealth.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            }
            if (_marksMan.Health <= 150)
            {
                lblRightHealth.BackColor = ColorTranslator.FromHtml("#E6E6E6");
            }
        }

        private void DisableButtons()
        {
            btnLeftAttack.Enabled = false;
            btnRightAttack.Enabled = false;
            btnLeftLevelUp.Enabled = false;
            btnRightLevelUp.Enabled = false;
        }
    }
}