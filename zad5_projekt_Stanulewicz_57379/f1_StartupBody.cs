using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zad5_projekt_Stanulewicz_57379
{
    public partial class f1_StartupBody : Form
    {
        public f1_StartupBody()
        {
            InitializeComponent();
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.FlatAppearance.BorderSize = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);


                if (String.IsNullOrEmpty(loginTextbox.Text) || String.IsNullOrEmpty(passwordTextbox.Text))
                {
                    MessageBox.Show("Wpisz login i/lub hasło");
                }
                else
                {
                    try
                    {
                        MySqlCommand loginChecker = new MySqlCommand($"SELECT logins.Login, logins.Password FROM logins WHERE logins.Login = @login AND logins.Password = @password");
                        loginChecker.Parameters.AddWithValue("@login", loginTextbox.Text);
                        loginChecker.Parameters.AddWithValue("@password", passwordTextbox.Text);
                        loginChecker.CommandType = CommandType.Text;
                        loginChecker.Connection = databaseConnection;
                        try
                        {
                            databaseConnection.Open();
                            MySqlDataReader sqlDataReader = loginChecker.ExecuteReader();
                            bool querySuccessful = sqlDataReader.HasRows;
                            sqlDataReader.Close();
                            if(querySuccessful == true)
                            {
                                if (loginTextbox.Text.Equals("Admin1") && passwordTextbox.Text.Equals("Admin1"))
                                {
                                    using (StreamWriter usernameWriter = new StreamWriter(pathFactory.userString))
                                    {
                                        usernameWriter.Write(loginTextbox.Text);
                                    }

                                    this.Hide();
                                    f2_AppBody Open_f2_AppBody = new f2_AppBody();
                                    Open_f2_AppBody.ShowDialog();
                                }
                                else
                                {
                                    using (StreamWriter usernameWriter = new StreamWriter(pathFactory.userString))
                                    {
                                        usernameWriter.Write(loginTextbox.Text);
                                    }

                                    this.Hide();
                                    f4_userBody Open_f4_userBody = new f4_userBody();
                                    Open_f4_userBody.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Błędne dane logowania");
                            }  
                        }
                        catch
                        {
                            MessageBox.Show("Nieoczekiwany błąd logowania");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Błędne dane wyszukania bazy danych");
                    }
                    
                }
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            f3_SettingsBody Open_f3_SettingsBody = new f3_SettingsBody();
            Open_f3_SettingsBody.ShowDialog();
        }
    }
}
