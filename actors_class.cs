using System;

namespace actors
{
    class actor
    {
        private string fName;
        private string lName;
        private DateTime birthDate;
        private int age;
        private int health;
        private int strength;
        private int hunger;
        private int thirst;
        private int bodytemp;
        private int energy;
        private int fatique;



        public actor(int strength, int health, string lName, string fName, DateTime birthDate = default, int age = 0)
        {
            this.strength = strength;
            this.health = health;
            this.lName = lName;
            this.FName = fName;
            this.birthDate = birthDate;
            this.age = age;
        }

        public string FName { get => fName; set => fName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
    }
}
