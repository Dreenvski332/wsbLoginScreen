using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5_projekt_Stanulewicz_57379
{
    public class PathFactory
    {
        public string connString = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad5_projekt_Stanulewicz_57379\zad5_projekt_Stanulewicz_57379\settings\connection.txt";
        static string pathString = @"S:\WSB\Semestr_VI\Zaawansowane programowanie obiektowe\zad5_projekt_Stanulewicz_57379\zad5_projekt_Stanulewicz_57379\settings\";
        public string sourceString = pathString + "source.txt";
        public string portString = pathString + "port.txt";
        public string usernameString = pathString + "username.txt";
        public string passwordString = pathString + "password.txt";
        public string databaseString = pathString + "database.txt";
        public string userString = pathString + "user.txt";
    }
}
