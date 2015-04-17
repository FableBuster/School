using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Champignon
{
    enum Roles
    {
        Assassin,
        Fighter,
        Mage,
        Support,
        Tank,
        Marksman
    };

    class Champignon
    {
        

        private Roles rol;
        private string naam;
        private double health;
        private double movementSpeed;
        private double attackDamage;
        private static double classicMode;
        private int _level;

        public string Naam
        {
            get
            {
                return naam;
            }
        }

        public double Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public double MovementSpeed
        {
            get
            {
                return movementSpeed;
            }
            set
            {
                movementSpeed = value;
            }
        }

        public double AttackDamage
        {
            get
            {
                return attackDamage;
            }

            set { attackDamage = value; }
        }

        public static double ClassicMode
        {
            get
            {
                return classicMode;
            }
            set { classicMode = value; }
        }


        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }


        public Champignon(string naam, double health, double attackDamage, Roles rol, int level)
        {
            this.naam = naam;
            this.health = health;
            this.attackDamage = attackDamage;
            this.rol = rol;
            MovementSpeed = 150;
            this._level = level;
        }

        public void ChangeLevel(int newLevel)
        {
            this._level = newLevel;
            int vorigLevel = 1;
            if (newLevel > vorigLevel)
            {

                attackDamage += 3.1;
                movementSpeed = movementSpeed * 1.1;

                if (rol == Roles.Fighter || rol == Roles.Assassin)
                {
                    health += 85;
                }

                else
                {
                    health += 55;
                }

                vorigLevel = newLevel;

            }

            if (newLevel <= vorigLevel)
            {

                attackDamage -= 3.1;
                movementSpeed = movementSpeed / 1.1;

                if (rol == Roles.Assassin || rol == Roles.Fighter)
                {
                    health -= 85;
                }
                else
                {
                    health -= 55;
                }
            }
        }

  







    }
}
