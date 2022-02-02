using System;

// class that implements an actor
namespace actors
{
    class actor
    {
        // Actor instance variables.
        private int actorLevel;
        private string fName;
        private string lName;
        private DateTime birthDate;
        private int ageYears;
        private int healthPoints;
        private int mainStrength;
        private int intelligence;
        private int mainDexterity;
        private int mainConstitution;
        private int mainPerception;
        private int actorLuck;
        private int hunger;
        private int thirst;
        private int mainBodyTemp;
        private int mainEnergy;
        private int mainFatique;
        private int mainHygiene;


        public actor(){}
        public actor(int strength, int health, string lName, string fName, DateTime birthDate = default, int age = 0)
        {
            this.mainStrength = strength;
            this.healthPoints = health;
            this.lName = lName;
            this.FName = fName;
            this.birthDate = birthDate;
            this.ageYears = age;
        }

        public string FName { get; set ;}
        public DateTime BirthDate { get; set;}
    }
}
