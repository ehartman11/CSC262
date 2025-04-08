using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OOP
{

    // Main form class
    public partial class Form1 : Form
    {

        // List to store character objects
        List<Character> savedCharacters = new List<Character>();

        // Instance of Species class to get ability boosts
        Species species = new Species();

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Method to load ability boosts based on selected species
        private void loadAbilityLabels(string selected)
        {
            // Display ability boosts
            var boosts = species.GetAbilityBoosts(selected);
            var keys = boosts.Keys.ToList();

            // Display up to two boosts, if available
            if (keys.Count > 0)
            {
                ability_1_Label.Text = keys[0];
                ability_1_boost_label.Text = boosts[keys[0]].ToString();
            }
            if (keys.Count > 1)
            {
                ability_2_Label.Text = keys[1];
                ability_2_boost_label.Text = boosts[keys[1]].ToString();
            }
            else
            {
                ability_2_Label.Text = "";
                ability_2_boost_label.Text = "";
            }
        }

        // Event handler for species dropdown selection change
        private void speciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check to see if the speciesBox has a selected item, 
            // and if so, get the selected species and its ability boosts
            // Display the boosts in the appropriate labels
            if (speciesBox.SelectedItem != null)
            {
                string displaySpecies = speciesBox.SelectedItem.ToString();
                loadAbilityLabels(displaySpecies);
            }
            else
            {
                ability_1_Label.Text = "";
                ability_1_boost_label.Text = "";
                ability_2_Label.Text = "";
                ability_2_boost_label.Text = "";
            }
        }

        // Clear form fields after saving a character
        private void ClearFormFields()
        {
            nameBox.Clear();
            classComboBox.SelectedIndex = -1;
            speciesBox.SelectedIndex = -1;
            levelBox.Value = 1;
            hitPointsBox.Value = 1;

            strengthBox.Value = 0;
            dexterityBox.Value = 0;
            constitutionBox.Value = 0;
            intelligenceBox.Value = 0;
            wisdomBox.Value = 0;
            charismaBox.Value = 0;

            ability_1_Label.Text = "";
            ability_1_boost_label.Text = "";
            ability_2_Label.Text = "";
            ability_2_boost_label.Text = "";
        }

        // Event handler for save button click
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Instantiate a new character object and set its properties
            Character character = new Character();
            character.Name = nameBox.Text;
            character.Class = classComboBox.Text;
            character.Species = speciesBox.Text;
            character.Level = (int)levelBox.Value;
            character.Hitpoints = (int)hitPointsBox.Value;

            character.Attributes["Strength"] = (int)strengthBox.Value;
            character.Attributes["Dexterity"] = (int)dexterityBox.Value;
            character.Attributes["Constitution"] = (int)constitutionBox.Value;
            character.Attributes["Intelligence"] = (int)intelligenceBox.Value;
            character.Attributes["Wisdom"] = (int)wisdomBox.Value;
            character.Attributes["Charisma"] = (int)charismaBox.Value;

            // Add the character to the saved character list and update the dropdown
            savedCharacters.Add(character);
            savedCharacterBox.Items.Add(character.Name);

            // Clear the form fields
            ClearFormFields();
        }

        // Event handler for view button click
        private void viewButton_Click(object sender, EventArgs e)
        {
            /* Using the name selected in the saved characters dropdown menu, 
               Ensure that the selected name is not null or empty,
               Find the associated character in the saved characters list, 
               Then fill the form's fields with that character object's attributes.
             */
            string selectedName = savedCharacterBox.SelectedItem?.ToString(); 
            if (string.IsNullOrWhiteSpace(selectedName))
            {
                MessageBox.Show("Please select a character from the dropdown.");
                return;
            }

            Character selected = savedCharacters.FirstOrDefault(c => c.Name == selectedName);
            if (selected == null)
            {
                MessageBox.Show("Character not found.");
                return;
            }

            nameBox.Text = selected.Name;
            classComboBox.Text = selected.Class;
            speciesBox.Text = selected.Species;
            levelBox.Value = selected.Level;
            hitPointsBox.Value = selected.Hitpoints;

            strengthBox.Value = selected.Attributes["Strength"];
            dexterityBox.Value = selected.Attributes["Dexterity"];
            constitutionBox.Value = selected.Attributes["Constitution"];
            intelligenceBox.Value = selected.Attributes["Intelligence"];
            wisdomBox.Value = selected.Attributes["Wisdom"];
            charismaBox.Value = selected.Attributes["Charisma"];

            // Load ability boosts for the selected species
            loadAbilityLabels(selected.Species);
        }
    }
}
