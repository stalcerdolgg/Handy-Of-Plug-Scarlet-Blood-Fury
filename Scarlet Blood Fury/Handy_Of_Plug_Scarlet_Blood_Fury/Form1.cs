using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handy_Of_Plug_Scarlet_Blood_Fury
{
    public partial class Form_Login : Form
    {
        // Dictionary to store profiles and their respective passwords
        private Dictionary<string, string> profiles;

        public Form_Login()
        {
            InitializeComponent();
            InitializeProfiles();
        }

        private void InitializeProfiles()
        {
            // Initialize the dictionary with profiles and their passwords
            profiles = new Dictionary<string, string>
            {
                { "Profile1", "qwerty" },
                { "Profile2", "12345" },
                { "Profile3", "qwerty12345" }
            };

            // Add profiles to the ComboBox
            foreach (var profile in profiles.Keys)
            {
                user_comboBox.Items.Add(profile);
            }

            // Optionally set a default selected index
            user_comboBox.SelectedIndex = 0;
        }

        private void user_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can add any actions you want to perform when the selection changes
        }

        private void password_Box_TextChanged(object sender, EventArgs e)
        {
            // You can add any actions you want to perform when the text in the password box changes
        }

        private void login_butt_Click(object sender, EventArgs e)
        {
            // Get the selected profile
            string selectedProfile = user_comboBox.SelectedItem.ToString();

            // Get the entered password
            string enteredPassword = password_Box.Text;

            // Check if the entered password matches the password for the selected profile
            if (profiles.ContainsKey(selectedProfile) && profiles[selectedProfile] == enteredPassword)
            {
                // Create an instance of Form_Admin
                Form_admin adminForm = new Form_admin();

                // Disable the login form
                this.Enabled = false;

                // Show the admin form
                adminForm.ShowDialog();

                // Re-enable the login form after adminForm is closed
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
            }
        }

        private void close_butt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
