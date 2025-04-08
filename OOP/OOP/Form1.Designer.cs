namespace OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.hitPointsLabel = new System.Windows.Forms.Label();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.hitPointsBox = new System.Windows.Forms.NumericUpDown();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.strengthBox = new System.Windows.Forms.NumericUpDown();
            this.wisdomBox = new System.Windows.Forms.NumericUpDown();
            this.dexterityBox = new System.Windows.Forms.NumericUpDown();
            this.charismaBox = new System.Windows.Forms.NumericUpDown();
            this.constitutionBox = new System.Windows.Forms.NumericUpDown();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.speciesBox = new System.Windows.Forms.ComboBox();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.ability_score_label = new System.Windows.Forms.Label();
            this.ability_1_Label = new System.Windows.Forms.Label();
            this.ability_2_boost_label = new System.Windows.Forms.Label();
            this.ability_1_boost_label = new System.Windows.Forms.Label();
            this.ability_2_Label = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.intelligenceBox = new System.Windows.Forms.NumericUpDown();
            this.savedCharacterBox = new System.Windows.Forms.ComboBox();
            this.savedCharacterLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hitPointsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.classComboBox.Location = new System.Drawing.Point(302, 31);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 0;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(300, 15);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(299, 95);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level";
            // 
            // hitPointsLabel
            // 
            this.hitPointsLabel.AutoSize = true;
            this.hitPointsLabel.Location = new System.Drawing.Point(299, 135);
            this.hitPointsLabel.Name = "hitPointsLabel";
            this.hitPointsLabel.Size = new System.Drawing.Size(52, 13);
            this.hitPointsLabel.TabIndex = 6;
            this.hitPointsLabel.Text = "Hit Points";
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLabel.Location = new System.Drawing.Point(233, 197);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(51, 13);
            this.attributesLabel.TabIndex = 7;
            this.attributesLabel.Text = "Attributes";
            // 
            // hitPointsBox
            // 
            this.hitPointsBox.Location = new System.Drawing.Point(302, 153);
            this.hitPointsBox.Name = "hitPointsBox";
            this.hitPointsBox.Size = new System.Drawing.Size(120, 20);
            this.hitPointsBox.TabIndex = 8;
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(301, 111);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(120, 20);
            this.levelBox.TabIndex = 9;
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(100, 239);
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(120, 20);
            this.strengthBox.TabIndex = 10;
            // 
            // wisdomBox
            // 
            this.wisdomBox.Location = new System.Drawing.Point(302, 297);
            this.wisdomBox.Name = "wisdomBox";
            this.wisdomBox.Size = new System.Drawing.Size(120, 20);
            this.wisdomBox.TabIndex = 12;
            // 
            // dexterityBox
            // 
            this.dexterityBox.Location = new System.Drawing.Point(100, 297);
            this.dexterityBox.Name = "dexterityBox";
            this.dexterityBox.Size = new System.Drawing.Size(120, 20);
            this.dexterityBox.TabIndex = 13;
            // 
            // charismaBox
            // 
            this.charismaBox.Location = new System.Drawing.Point(302, 355);
            this.charismaBox.Name = "charismaBox";
            this.charismaBox.Size = new System.Drawing.Size(120, 20);
            this.charismaBox.TabIndex = 14;
            // 
            // constitutionBox
            // 
            this.constitutionBox.Location = new System.Drawing.Point(100, 355);
            this.constitutionBox.Name = "constitutionBox";
            this.constitutionBox.Size = new System.Drawing.Size(120, 20);
            this.constitutionBox.TabIndex = 15;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(100, 222);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(47, 13);
            this.strengthLabel.TabIndex = 16;
            this.strengthLabel.Text = "Strength";
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(100, 281);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(48, 13);
            this.dexterityLabel.TabIndex = 17;
            this.dexterityLabel.Text = "Dexterity";
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(100, 339);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(62, 13);
            this.constitutionLabel.TabIndex = 18;
            this.constitutionLabel.Text = "Constitution";
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(299, 339);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(50, 13);
            this.charismaLabel.TabIndex = 19;
            this.charismaLabel.Text = "Charisma";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(299, 281);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(45, 13);
            this.wisdomLabel.TabIndex = 20;
            this.wisdomLabel.Text = "Wisdom";
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(299, 222);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.intelligenceLabel.TabIndex = 21;
            this.intelligenceLabel.Text = "Intelligence";
            // 
            // speciesBox
            // 
            this.speciesBox.FormattingEnabled = true;
            this.speciesBox.Items.AddRange(new object[] {
            "Dragon-Born",
            "Hill Dwarf",
            "Mountain Dwarf",
            "High Elf",
            "Wood Elf",
            "Eladrin Elf",
            "Half-Elf",
            "Half-Orc",
            "Lightfoot Hafling",
            "Stout Hafling",
            "Human",
            "Variant Human",
            "Rock Gnome",
            "Tiefling"});
            this.speciesBox.Location = new System.Drawing.Point(302, 71);
            this.speciesBox.Name = "speciesBox";
            this.speciesBox.Size = new System.Drawing.Size(121, 21);
            this.speciesBox.TabIndex = 22;
            this.speciesBox.SelectedIndexChanged += new System.EventHandler(this.speciesBox_SelectedIndexChanged);
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(299, 55);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(45, 13);
            this.speciesLabel.TabIndex = 23;
            this.speciesLabel.Text = "Species";
            // 
            // ability_score_label
            // 
            this.ability_score_label.AutoSize = true;
            this.ability_score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ability_score_label.Location = new System.Drawing.Point(100, 118);
            this.ability_score_label.Name = "ability_score_label";
            this.ability_score_label.Size = new System.Drawing.Size(109, 13);
            this.ability_score_label.TabIndex = 24;
            this.ability_score_label.Text = "Ability Score Increase";
            // 
            // ability_1_Label
            // 
            this.ability_1_Label.AutoSize = true;
            this.ability_1_Label.Location = new System.Drawing.Point(100, 135);
            this.ability_1_Label.Name = "ability_1_Label";
            this.ability_1_Label.Size = new System.Drawing.Size(45, 13);
            this.ability_1_Label.TabIndex = 25;
            this.ability_1_Label.Text = "ability_1";
            // 
            // ability_2_boost_label
            // 
            this.ability_2_boost_label.AutoSize = true;
            this.ability_2_boost_label.Location = new System.Drawing.Point(181, 160);
            this.ability_2_boost_label.Name = "ability_2_boost_label";
            this.ability_2_boost_label.Size = new System.Drawing.Size(77, 13);
            this.ability_2_boost_label.TabIndex = 26;
            this.ability_2_boost_label.Text = "ability_2_boost";
            // 
            // ability_1_boost_label
            // 
            this.ability_1_boost_label.AutoSize = true;
            this.ability_1_boost_label.Location = new System.Drawing.Point(181, 135);
            this.ability_1_boost_label.Name = "ability_1_boost_label";
            this.ability_1_boost_label.Size = new System.Drawing.Size(77, 13);
            this.ability_1_boost_label.TabIndex = 27;
            this.ability_1_boost_label.Text = "ability_1_boost";
            // 
            // ability_2_Label
            // 
            this.ability_2_Label.AutoSize = true;
            this.ability_2_Label.Location = new System.Drawing.Point(100, 160);
            this.ability_2_Label.Name = "ability_2_Label";
            this.ability_2_Label.Size = new System.Drawing.Size(45, 13);
            this.ability_2_Label.TabIndex = 29;
            this.ability_2_Label.Text = "ability_2";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(100, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(100, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(223, 404);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 34;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(303, 239);
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(120, 20);
            this.intelligenceBox.TabIndex = 36;
            // 
            // savedCharacterBox
            // 
            this.savedCharacterBox.FormattingEnabled = true;
            this.savedCharacterBox.Location = new System.Drawing.Point(304, 406);
            this.savedCharacterBox.Name = "savedCharacterBox";
            this.savedCharacterBox.Size = new System.Drawing.Size(121, 21);
            this.savedCharacterBox.TabIndex = 37;
            // 
            // savedCharacterLabel
            // 
            this.savedCharacterLabel.AutoSize = true;
            this.savedCharacterLabel.Location = new System.Drawing.Point(301, 390);
            this.savedCharacterLabel.Name = "savedCharacterLabel";
            this.savedCharacterLabel.Size = new System.Drawing.Size(92, 13);
            this.savedCharacterLabel.TabIndex = 38;
            this.savedCharacterLabel.Text = "Saved Characters";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(158, 20);
            this.nameBox.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.savedCharacterLabel);
            this.Controls.Add(this.savedCharacterBox);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ability_2_Label);
            this.Controls.Add(this.ability_1_boost_label);
            this.Controls.Add(this.ability_2_boost_label);
            this.Controls.Add(this.ability_1_Label);
            this.Controls.Add(this.ability_score_label);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.speciesBox);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.constitutionBox);
            this.Controls.Add(this.charismaBox);
            this.Controls.Add(this.dexterityBox);
            this.Controls.Add(this.wisdomBox);
            this.Controls.Add(this.strengthBox);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.hitPointsBox);
            this.Controls.Add(this.attributesLabel);
            this.Controls.Add(this.hitPointsLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hitPointsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label hitPointsLabel;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.NumericUpDown hitPointsBox;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.NumericUpDown strengthBox;
        private System.Windows.Forms.NumericUpDown wisdomBox;
        private System.Windows.Forms.NumericUpDown dexterityBox;
        private System.Windows.Forms.NumericUpDown charismaBox;
        private System.Windows.Forms.NumericUpDown constitutionBox;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.ComboBox speciesBox;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label ability_score_label;
        private System.Windows.Forms.Label ability_1_Label;
        private System.Windows.Forms.Label ability_2_boost_label;
        private System.Windows.Forms.Label ability_1_boost_label;
        private System.Windows.Forms.Label ability_2_Label;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.NumericUpDown intelligenceBox;
        private System.Windows.Forms.ComboBox savedCharacterBox;
        private System.Windows.Forms.Label savedCharacterLabel;
        private System.Windows.Forms.TextBox nameBox;
    }
}

