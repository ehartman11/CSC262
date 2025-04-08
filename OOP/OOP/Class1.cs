using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Species class to manage species and their ability boosts
    public class Species
    {
        // Dictionary to store species and their corresponding ability boosts
        Dictionary<string, Dictionary<string, int>> abilityBoosts = new Dictionary<string, Dictionary<string, int>>()
        {
            ["Dragon-Born"] = new Dictionary<string, int>
            {
                ["Strength"] = 2,
                ["Charisma"] = 1
            },
            ["Hill Dwarf"] = new Dictionary<string, int>
            {
                ["Constitution"] = 2
            },
            ["Mountain Dwarf"] = new Dictionary<string, int>
            {
                ["Constitution"] = 2
            },
            ["High Elf"] = new Dictionary<string, int>
            {
                ["Dexterity"] = 2
            },
            ["Wood Elf"] = new Dictionary<string, int>
            {
                ["Dexterity"] = 2
            },
            ["Eladrin Elf"] = new Dictionary<string, int>
            {
                ["Dexterity"] = 2
            },
            ["Half-Elf"] = new Dictionary<string, int>
            {
                ["Charisma"] = 2,
                ["AnyTwoOthers"] = 1
            },
            ["Half-Orc"] = new Dictionary<string, int>
            {
                ["Strength"] = 2,
                ["Constitution"] = 1
            },
            ["Lightfoot Hafling"] = new Dictionary<string, int>
            {
                ["Dexterity"] = 2
            },
            ["Stout Halfing"] = new Dictionary<string, int>
            {
                ["Dexterity"] = 2
            },
            ["Human"] = new Dictionary<string, int>
            {
                ["Strength"] = 1,
                ["Dexterity"] = 1,
                ["Constitution"] = 1,
                ["Intelligence"] = 1,
                ["Wisdom"] = 1,
                ["Charisma"] = 1
            },
            ["Variant Human"] = new Dictionary<string, int>
            {
                ["AnyTwoDifferent"] = 1
            },
            ["Rock Gnome"] = new Dictionary<string, int>
            {
                ["Intelligence"] = 2
            },
            ["Tiefling"] = new Dictionary<string, int>
            {
                ["Intelligence"] = 1,
                ["Charisma"] = 2
            }
        };

        // Method to get the ability boosts for a given species
        public Dictionary<string, int> GetAbilityBoosts(string species)
        {
            if(!abilityBoosts.ContainsKey(species))
            {
                throw new ArgumentException("Species not found");
            }
            return abilityBoosts[species];
        }
    };

    // Class to represent a character
    public class Character
    {
        // Properties of the character
        public string Name { get; set; }
        public string Class { get; set; }
        public string Species { get; set; }
        public int Level { get; set; }
        public int Hitpoints { get; set; }

        // Dictionary to store character attributes
        public Dictionary<string, int> Attributes { get; set; } = new Dictionary<string, int>();
    }
}
