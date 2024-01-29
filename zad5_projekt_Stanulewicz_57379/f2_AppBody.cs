using MySql.Data.MySqlClient;
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

namespace zad5_projekt_Stanulewicz_57379
{
    public partial class f2_AppBody : Form
    {
        public f2_AppBody()
        {
            InitializeComponent();
        }
        //HEADER START
        private void manageButton_Click(object sender, EventArgs e)
        {
            userSettingsGroup.Visible = true;
            placeholderGroup.Visible = false;
            timerGroup.Visible = false;
        }
        private void placeholderButton_Click(object sender, EventArgs e)
        {
            placeholderGroup.Visible = true;
            userSettingsGroup.Visible = false;
            timerGroup.Visible = false;
        }
        private void booksButton_Click(object sender, EventArgs e)
        {
            timerGroup.Visible = true;
            userSettingsGroup.Visible = false;
            placeholderGroup.Visible = false;

            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                MySqlCommand displayUsersQuery = new MySqlCommand($"SELECT logins.Login FROM logins");
                displayUsersQuery.CommandType = CommandType.Text;
                displayUsersQuery.Connection = databaseConnection;
                databaseConnection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(displayUsersQuery);
                DataTable userTable = new DataTable();
                dataAdapter.Fill(userTable);
                try
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach(DataRow row in userTable.Rows)
                    {
                        for (int i = 0; i < userTable.Columns.Count; i++)
                        {
                            stringBuilder.Append(row[i].ToString());
                            if(i < userTable.Columns.Count - 1)
                            {
                                stringBuilder.Append("\t");
                            }
                        }
                        stringBuilder.AppendLine();
                    }
                    userListTextbox.Text = stringBuilder.ToString();
                }
                catch
                {
                    MessageBox.Show("Nieoczekiwany błąd wczytywania użytkowników");
                }
            }
        }
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
        //HEADER END


       


        //USER MANAGE START
        private void closeManageGroup_Click(object sender, EventArgs e)
        {
            userSettingsGroup.Visible = false;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                String addUserQuery = "INSERT INTO `logins`(`Login`, `Password`) VALUES (@username, @password)";

                if(String.IsNullOrEmpty(usernameTextbox.Text) && String.IsNullOrEmpty(passwordTextbox.Text))
                {
                    MessageBox.Show("Wypełnij dane");
                }
                else
                {
                    try
                    {
                        using (MySqlCommand addUserCommand = new MySqlCommand(addUserQuery, databaseConnection))
                        {
                            addUserCommand.Parameters.AddWithValue("@username", usernameTextbox.Text);
                            addUserCommand.Parameters.AddWithValue("@password", passwordTextbox.Text);

                            databaseConnection.Open();
                            int queryFeedback = addUserCommand.ExecuteNonQuery();
                            databaseConnection.Close();
                        }
                        MessageBox.Show("Użytkownik dodany!");
                    }
                    catch
                    {
                        MessageBox.Show("Błąd dodawania użytkownika");
                    }
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                String deleteUserQuery = "DELETE FROM logins WHERE Login = @username AND Password = @password";

                if (String.IsNullOrEmpty(usernameTextbox.Text) && String.IsNullOrEmpty(passwordTextbox.Text))
                {
                    MessageBox.Show("Wypełnij dane");
                }
                else
                {
                    try
                    {
                        using (MySqlCommand deleteUserCommand = new MySqlCommand(deleteUserQuery, databaseConnection))
                        {
                            deleteUserCommand.Parameters.AddWithValue("@username", usernameTextbox.Text);
                            deleteUserCommand.Parameters.AddWithValue("@password", passwordTextbox.Text);

                            databaseConnection.Open();
                            int queryFeedback = deleteUserCommand.ExecuteNonQuery();
                            databaseConnection.Close();
                        }
                        MessageBox.Show("Użytkownik usunięty!");
                    }
                    catch
                    {
                        MessageBox.Show("Błąd usuwania użytkownika");
                    }
                }
            }
        }
        //MANAGE USER END





        //TIMER MENU START
        private void closeBooksGroupButton_Click(object sender, EventArgs e)
        {
            timerGroup.Visible = false;
        }

        private void findUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            PathFactory pathFactory = new PathFactory();
            using (StreamReader streamReader = new StreamReader(pathFactory.connString))
            {
                string connection = streamReader.ReadToEnd();
                string connectionString = connection;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                
                MySqlCommand startingTimeQuery = new MySqlCommand($"SELECT startingtime.StartTime FROM `startingtime` INNER JOIN logins ON startingtime.Login = logins.Login WHERE logins.Login = @login");
                startingTimeQuery.Parameters.AddWithValue("@login", findUsernameTextbox.Text);
                startingTimeQuery.CommandType = CommandType.Text;
                startingTimeQuery.Connection = databaseConnection;
                databaseConnection.Open();

                MySqlDataAdapter startDataAdapter = new MySqlDataAdapter(startingTimeQuery);
                DataTable startingTimeTable = new DataTable();
                startDataAdapter.Fill(startingTimeTable);
                StringBuilder stringBuilderStart = new StringBuilder();
                foreach (DataRow row in startingTimeTable.Rows)
                {
                    for (int i = 0; i < startingTimeTable.Columns.Count; i++)
                    {
                        stringBuilderStart.Append(row[i].ToString());
                        if (i < startingTimeTable.Columns.Count - 1)
                        {
                            stringBuilderStart.Append("\t");
                        }
                    }
                    stringBuilderStart.AppendLine();
                }
                startingTimeTextbox.Text = stringBuilderStart.ToString();
                
                

                MySqlCommand endingTimeQuery = new MySqlCommand($"SELECT endingtime.EndTime FROM `endingtime` INNER JOIN logins ON endingtime.Login = logins.Login WHERE logins.Login = @login");
                endingTimeQuery.Parameters.AddWithValue("@login", findUsernameTextbox.Text);
                endingTimeQuery.CommandType = CommandType.Text;
                endingTimeQuery.Connection = databaseConnection;

                MySqlDataAdapter endDataAdapter = new MySqlDataAdapter(endingTimeQuery);
                DataTable timeTable = new DataTable();
                endDataAdapter.Fill(timeTable);
                StringBuilder stringBuilderEnd = new StringBuilder();
                foreach (DataRow row in timeTable.Rows)
                {
                    for (int i = 0; i < timeTable.Columns.Count; i++)
                    {
                        stringBuilderEnd.Append(row[i].ToString());
                        if (i < timeTable.Columns.Count - 1)
                        {
                            stringBuilderEnd.Append("\t");
                        }
                    }
                    stringBuilderEnd.AppendLine();
                }
                finishTimeTextbox.Text = stringBuilderEnd.ToString();
            }
        }
        //TIMER MENU END
    }
}
