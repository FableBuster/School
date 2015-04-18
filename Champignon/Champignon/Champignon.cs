using System;



namespace Champignon
{
    //Character professions
    internal enum Roles
    {
        Assassin,
        Fighter,
        Mage,
        Support,
        Tank,
        Marksman
    };

    internal class Champignon
    {

        //fields
        private readonly Roles rol;
        private double health;
        //Constructor
        public Champignon(string naam, double health, double attackDamage, Roles rol, int level)
        {
            
            Naam = naam;
            this.health = health;
            AttackDamage = attackDamage;
            this.rol = rol;
            MovementSpeed = 150;
            Level = level;
        }

        //Properties
        public string Naam { get; private set; }

        public double Health
        {
            get { return health; }
            set { health = Math.Round(value, 2); }
        }

        public double MovementSpeed { get; set; }
        public double AttackDamage { get; set; }
        public static double ClassicMode { get; set; }
        public int Level { get; set; }


        //Change level method
        public void ChangeLevel(int newLevel)
        {
            Level = newLevel;
            var vorigLevel = 1;
            if (newLevel > vorigLevel)
            {
                AttackDamage += 3.1;
                MovementSpeed = MovementSpeed*1.1;

                if (rol == Roles.Fighter || rol == Roles.Assassin)
                {
                    health += 85;
                }

                else
                {
                    health += 55;
                }

                Level = newLevel;
            }

            if (newLevel <= vorigLevel)
            {
                AttackDamage -= 3.1;
                MovementSpeed = MovementSpeed/1.1;

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

        public void ReceiveDamage(double AttackDamage)
        {
            Health = Health - AttackDamage;
        }

    
    }
}