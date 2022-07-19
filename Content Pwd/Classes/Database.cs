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

        private static readonly string path = @"C:\Content Pwd\";

        public static void Save()
        {
            Data.selected_id = -1;
            if (id != null)
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                StreamWriter w = new StreamWriter(path + "database.db");

                for (int i = 0; i < id.Length; i++)
                {
                    var s = Data.Encrypt(subject[i]);
                    var c = Data.Encrypt(content[i]);
                    var p = Data.Encrypt(password[i]);

                    var encrypted = Data.Encrypt(s + '|' + c + '|' + p);

                    w.WriteLine(encrypted);
                }

                w.Close();
            }
        }

        public static void Load()
        {
            if (File.Exists(path + "database.db") && new FileInfo(path + "database.db").Length != 0)
            {
                id = null;
                subject = null;
                content = null;
                password = null;

                List<int> id_list = new List<int>();
                List<string> subject_list = new List<string>();
                List<string> content_list = new List<string>();
                List<string> password_list = new List<string>();

                StreamReader r = new StreamReader(path + "database.db");
                string l = r.ReadLine();

                while (l != null)
                {
                    string temp = Data.Decrypt(l);
                    string[] c = temp.Split('|');

                    id_list.Add(id_list.Count);
                    subject_list.Add(Data.Decrypt(c[0]));
                    content_list.Add(Data.Decrypt(c[1]));
                    password_list.Add(Data.Decrypt(c[2]));

                    l = r.ReadLine();
                }

                id = id_list.ToArray();
                subject = subject_list.ToArray();
                content = content_list.ToArray();
                password = password_list.ToArray();

                r.Close();
            }
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

        public static void Update(string s, string c, string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;

            subject[Data.selected_id] = s;
            content[Data.selected_id] = c;
            password[Data.selected_id] = p;

            Save();
        }

        public static void Delete()
        {
            if (id.Length <= 1)
            {
                id = null;
                subject = null;
                content = null;
                password = null;

                File.WriteAllText(path + "database.db", string.Empty);
            }
            else
            {
                List<int> id_list = new List<int>();
                List<string> subject_list = new List<string>();
                List<string> content_list = new List<string>();
                List<string> password_list = new List<string>();

                for (int i = 0; i < id.Length; i++)
                {
                    if (i != Data.selected_id)
                    {
                        id_list.Add(id_list.Count);
                        content_list.Add(subject[i]);
                        content_list.Add(content[i]);
                        password_list.Add(password[i]);
                    }
                }

                id = id_list.ToArray();
                subject = subject_list.ToArray();
                content = content_list.ToArray();
                password = password_list.ToArray();
            }

            Save();
        }
    }
}
