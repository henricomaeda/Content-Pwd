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
        public static int[] id;
        public static string[] subject;
        public static string[] content;
        public static string[] password;

        public static void Load()
        {

        }

        public static void Save()
        {

        }

        public static void Create(string s, string c, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;

            List<int> id_list = new List<int>();
            List<string> subject_list = new List<string>();
            List<string> content_list = new List<string>();
            List<string> password_list = new List<string>();

            if (id != null)
            {
                for (int i = 0; i < id.Length; i++)
                {
                    id_list.Add(id[i]);
                    subject_list.Add(subject[i]);
                    content_list.Add(content[i]);
                    password_list.Add(password[i]);
                }
            }
            
            id_list.Add(id_list.Count);
            subject_list.Add(s);
            content_list.Add(c);
            password_list.Add(p);

            id = id_list.ToArray();
            subject = subject_list.ToArray();
            content = content_list.ToArray();
            password = password_list.ToArray();

            Save();
        }

        public static void Read(int i, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
        }

        public static void Update(int i, string s, string c, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;

            Save();
        }

        public static void Delete(int i, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;

            Save();
        }
    }
}
