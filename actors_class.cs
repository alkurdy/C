using System;

// class that implements an actor
namespace actors
{
    class actor
    {
        // Actor instance variables.

        public int actorLevel { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public int ageYears { get; set; }
        public int healthPoints { get; set; }
        public int mainStrength { get; set; }
        public int intelligence { get; set; }
        public int mainDexterity { get; set; }
        public int mainConstitution { get; set; }
        public int mainPerception { get; set; }
        public int actorLuck { get; set; }
        public int hunger { get; set; }
        public int thirst { get; set; }
        public int mainBodyTemp { get; set; }
        public int mainEnergy { get; set; }
        public int mainFatique { get; set; }
        public int mainHygiene { get; set; }


        public actor(){}
        public actor(int strength, int health, string lName, string fName, DateTime birthDate = default, int age = 0)
        {
            this.mainStrength = strength;
            this.healthPoints = health;
            this.lastName = lName;
            this.FName = fName;
            this.birthDate = birthDate;
            this.ageYears = age;
        }

        public string FName { get; set ;}
        public DateTime BirthDate { get; set;}
    }
}
