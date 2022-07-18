using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Pwd.Classes
{
    internal class Database
    {
        public static int selected_id = -1;

        public static int[] id;
        public static string[] subject;
        public static string[] content;
        public static string[] password;

        public static void Create(string s, string c, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
        }

        public static void Read(int i, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
        }

        public static void Update(int i, string s, string c, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
        }

        public static void Delete(int i, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
        }
    }
}
