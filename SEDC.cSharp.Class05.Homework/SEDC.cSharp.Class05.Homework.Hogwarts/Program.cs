using SEDC.cSharp.Class05.Homework.Hogwarts.Models;
using System;

namespace SEDC.cSharp.Class05.Homework.Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizzard aleksandar = new Wizzard()
            {
                Name = "Aleksandar Dojchinovski",
                PowerLevel = 200,
                Age = 27,
                DateOfAddmission = new DateTime(2004, 07, 19),
                GraduationStatus = true
            };
            Wizzard harry = new Wizzard()
            {
                Name = "Harry Potter",
                PowerLevel = 9999,
                Age = 31,
                DateOfAddmission = new DateTime(2000, 07, 19),
                GraduationStatus = true
            };
            Wizzard lordVoldemort = new Wizzard()
            {
                Name = "Thomas Riddle",
                PowerLevel = 9998,
                Age = 51,
                DateOfAddmission = new DateTime(1970, 07, 19),
                GraduationStatus = true
            };
            Wizzard hermione = new Wizzard()
            {
                Name = "Hermione Granger",
                PowerLevel = 6500,
                Age = 31,
                DateOfAddmission = new DateTime(2000, 07, 19),
                GraduationStatus = true
            };

            Creature goblin = new Creature()
            {
                Name = "Goblin",
                Age = 125,
                PowerLevel = 295,
                IsTamed = false
            };
            Creature dementor = new Creature()
            {
                Name = "Dementor",
                Age = 1500,
                PowerLevel = 10000,
                IsTamed = false
            };
            Creature houseElf = new Creature()
            {
                Name = "Dobby",
                Age = 125,
                PowerLevel = 5900,
                IsTamed = false
            };
            Creature centaur = new Creature()
            {
                Name = "Centaur",
                Age = 125,
                PowerLevel = 2600,
                IsTamed = false
            };

            Wizzard[] wizzardArray = { aleksandar, harry, lordVoldemort, hermione };

            Creature[] creatureArray = { goblin, dementor, houseElf, centaur };

            foreach(Wizzard wizzard in wizzardArray)
            {
                foreach(Creature creature in creatureArray)
                {
                    Console.WriteLine(Duel(wizzard, creature));
                }
            }
            Console.WriteLine();
            foreach(Creature creature in creatureArray)
            {
                if (!creature.IsTamed)
                {
                    Console.WriteLine($"{creature.Name} cannot be tamed by anyone!");
                }
            }

        }

        static string Duel(Wizzard wizzard, Creature creature)
        {
            if (!creature.IsTamed)
            {
                if (creature.Name == "Dobby")
                {
                    return $"You cant tame Dobby, he is a free elf!";
                }
                if (wizzard.PowerLevel > creature.PowerLevel)
                {
                    creature.IsTamed = true;
                    return $"The creature {creature.Name} is now tamed by {wizzard.Name}";
                }
                else
                {
                    return $"The power of wizzard {wizzard.Name} is too low to tame the creature {creature.Name}";
                }
            }
            return $"The creature {creature.Name} is already tamed!";
        }
    }
}
