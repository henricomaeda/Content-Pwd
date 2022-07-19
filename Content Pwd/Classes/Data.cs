using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Content_Pwd.Classes
{
    internal class Data
    {
        public static int selected_id = -1;

        public static void Up()
        {
            if (selected_id > 0)
            {
                var s = Database.subject[selected_id - 1];
                var c = Database.content[selected_id - 1];
                var p = Database.password[selected_id - 1];

                Database.subject[selected_id - 1] = Database.subject[selected_id];
                Database.content[selected_id - 1] = Database.content[selected_id];
                Database.password[selected_id - 1] = Database.password[selected_id];

                Database.subject[selected_id] = s;
                Database.content[selected_id] = c;
                Database.password[selected_id] = p;

                Database.Save();
            }
        }

        public static void Down()
        {
            if (selected_id > -1 && selected_id != (Database.id.Length - 1))
            {
                var s = Database.subject[selected_id + 1];
                var c = Database.content[selected_id + 1];
                var p = Database.password[selected_id + 1];

                Database.subject[selected_id + 1] = Database.subject[selected_id];
                Database.content[selected_id + 1] = Database.content[selected_id];
                Database.password[selected_id + 1] = Database.password[selected_id];

                Database.subject[selected_id] = s;
                Database.content[selected_id] = c;
                Database.password[selected_id] = p;

                Database.Save();
            }
        }

        public static string Encrypt(string s)
        {
            try
            {
                string toReturn = string.Empty;
                string publickey = "12345678";
                string secretkey = "87654321";

                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);

                byte[] secretkeyByte = { };
                secretkeyByte = Encoding.UTF8.GetBytes(secretkey);

                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(s);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    toReturn = Convert.ToBase64String(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public static string Decrypt(string s)
        {
            try
            {
                string toReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";

                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);

                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(secretkey);

                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[s.Replace(' ', '+').Length];
                inputbyteArray = Convert.FromBase64String(s.Replace(' ', '+'));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    toReturn = encoding.GetString(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
    }
}
