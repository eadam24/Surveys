using System.Windows.Forms;

namespace Surveys
{
    public partial class Form1 : Form
    {
        private string time;
        private string city;
        private string country;
        private List<string> hobbies = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] CitiesBG = { "Sofia", "Plovdiv", "Burgas" };
            string[] CitiesGermany = { "Munich", "Berlin", "Augsburg" };
            string[] CitiesAustria = { "Vienna", "Linz", "Salzburg" };


            if (Countries.SelectedIndex == 0)
            {
                country = "Bulgaria";
                Cities.Items.Clear();
                foreach (string c in CitiesBG)
                    Cities.Items.Add(c);
            }
            else if (Countries.SelectedIndex == 1)
            {
                country = "Germany";
                Cities.Items.Clear();
                foreach (string c in CitiesGermany)
                    Cities.Items.Add(c);
            }
            else if (Countries.SelectedIndex == 2)
            {
                country = "Austria";
                Cities.Items.Clear();
                foreach (string c in CitiesAustria)
                    Cities.Items.Add(c);
            }
            else
            {
                Cities.Items.Clear();
                Cities.Items.Add("Select a country!");
            }
        }

        private void morningButton_CheckedChanged(object sender, EventArgs e)
        {
            time = "morning";
        }

        private void afternoonButton_CheckedChanged(object sender, EventArgs e)
        {
            time = "afternoon";
        }

        private void eveningButton_CheckedChanged(object sender, EventArgs e)
        {
            time = "evening";
        }




        private void submitButton_Click(object sender, EventArgs e)
        {


            string msg = $"You will go to {city} in {country} during the {time}. Your chosen hobbies are: " + String.Join(", ", hobbies);

            MessageBox.Show(msg);
        }


        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = Cities.SelectedItem.ToString();
        }



        private void Guitar_CheckedChanged(object sender, EventArgs e)
        {
            if (Guitar.Checked)
            {
                chosenHobbies.Items.Add("Guitar");
            }
            else
            {
                chosenHobbies.Items.Remove("Guitar");
            }

        }

        private void Piano_CheckedChanged(object sender, EventArgs e)
        {
            if (Piano.Checked)
            {
                chosenHobbies.Items.Add("Piano");
            }
            else
            {
                chosenHobbies.Items.Remove("Piano");
            }
        }

        private void Gym_CheckedChanged(object sender, EventArgs e)
        {
            if (Gym.Checked)
            {
                chosenHobbies.Items.Add("Gym");
            }
            else
            {
                chosenHobbies.Items.Remove("Gym");
            }
        }

        private void Dancing_CheckedChanged(object sender, EventArgs e)
        {
            if (Dancing.Checked)
            {
                chosenHobbies.Items.Add("Dancing");
            }
            else
            {
                chosenHobbies.Items.Remove("Dancing");
            }
        }

        private void Hiking_CheckedChanged(object sender, EventArgs e)
        {
            if (Hiking.Checked)
            {
                chosenHobbies.Items.Add("Hiking");
            }
            else
            {
                chosenHobbies.Items.Remove("Hiking");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_right_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= chosenHobbies.Items.Count; i++)
            {
                if (chosenHobbies.SelectedIndex == i)
                {
                    hobbies.Add(chosenHobbies.SelectedItem.ToString());
                    listBox1.Items.Add(chosenHobbies.SelectedItem);
                    chosenHobbies.Items.Remove(chosenHobbies.SelectedItem);

                }

            }
        }
        private void button_left_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) 
            {
                var itemToRemove = listBox1.SelectedItem.ToString();

                if (hobbies.Contains(itemToRemove))
                {
                    hobbies.Remove(itemToRemove);
                }

                chosenHobbies.Items.Add(itemToRemove); 
                listBox1.Items.Remove(itemToRemove); 
            }
        }


    }
}
