using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_projekt_Stanulewicz_57379
{
    public partial class f4_userBody : Form
    {
        public f4_userBody()
        {
            InitializeComponent();
        }
        //HEADER START
        private void logoutButton_Click(object sender, EventArgs e)
        {
            f1_StartupBody Open_f1_StarupBody = new f1_StartupBody();
            Open_f1_StarupBody.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }
        private void booksButton_Click(object sender, EventArgs e)
        {
            timerGroup.Visible = true;
            placeholderGroup.Visible = false;
        }
        private void placeholderButton_Click(object sender, EventArgs e)
        {
            placeholderGroup.Visible = true;
            timerGroup.Visible = false;
        }
        //HEADER END




        //TIMER START
        private void closeTimerGroupButton_Click_1(object sender, EventArgs e)
        {
            timerGroup.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                String addStartingTimeQuery = "INSERT INTO `startingtime`(`StartTime`, `Login`) VALUES (@startTime, @login)";
                String addEndingTimeQuery = "INSERT INTO `endingtime`(`EndTime`, `Login`) VALUES (@endTime, @login)";
                if (String.IsNullOrEmpty(startTextbox.Text) || String.IsNullOrEmpty(endTextbox.Text))
                {
                    MessageBox.Show("Proszę wpisać obie wartości");
                }
                else
                {
                    try
                    {
                        using (MySqlCommand addStartingTimeCommand = new MySqlCommand(addStartingTimeQuery, databaseConnection))
                        {
                            using (StreamReader usernameReader = new StreamReader(pathFactory.userString))
                            {
                                string usernameRead = usernameReader.ReadToEnd();
                                addStartingTimeCommand.Parameters.AddWithValue("@startTime", startTextbox.Text);
                                addStartingTimeCommand.Parameters.AddWithValue("@login", usernameRead);

                                databaseConnection.Open();
                                int queryFeedback = addStartingTimeCommand.ExecuteNonQuery();
                                databaseConnection.Close();
                            }
                            
                        }
                        using (MySqlCommand addEndingTimeCommand = new MySqlCommand(addEndingTimeQuery, databaseConnection))
                        {
                            using (StreamReader usernameReader = new StreamReader(pathFactory.userString))
                            {
                                string usernameRead = usernameReader.ReadToEnd();
                                addEndingTimeCommand.Parameters.AddWithValue("@endTime", endTextbox.Text);
                                addEndingTimeCommand.Parameters.AddWithValue("@login", usernameRead);

                                databaseConnection.Open();
                                int queryFeedback = addEndingTimeCommand.ExecuteNonQuery();
                                databaseConnection.Close();
                            }

                        }
                        MessageBox.Show("Czas pracy zarejestrowany!");
                    }
                    catch
                    {
                        MessageBox.Show("Błąd dodawania czasu pracy.");
                    }
                }
            }
        }
        //TIMER END
    }
}
