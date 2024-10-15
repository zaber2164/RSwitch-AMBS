using System.Security.Cryptography;
using System.Text;

namespace RSwitch.AMBS.Utility
{
    public class Cryptography
    {
        private static byte[] IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] Key = new byte[] { 1, 2, 33, 4, 3, 6, 7, 8, 81, 2, 33, 84, 85, 06, 7, 8 };

        public Cryptography()
        {
        }
        public static string Encrypt(string clearData)
        {
            MemoryStream ms = new MemoryStream();
            TripleDES algValue = TripleDES.Create();

            algValue.IV = IV;
            algValue.Key = Key;

            byte[] bytes = Encoding.Unicode.GetBytes(clearData);

            CryptoStream cs = new CryptoStream(ms, algValue.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(bytes, 0, bytes.Length);
            cs.Close();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string cipherData)
        {
            MemoryStream ms = new MemoryStream();
            TripleDES algValue = TripleDES.Create();

            algValue.IV = IV;
            algValue.Key = Key;

            byte[] bytes = Convert.FromBase64String(cipherData);

            CryptoStream cs = new CryptoStream(ms, algValue.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(bytes, 0, bytes.Length);
            cs.Close();

            return Encoding.Unicode.GetString(ms.ToArray());
        }

        public static void Encrypt(string fileIn, string fileOut)
        {
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
            TripleDES algValue = TripleDES.Create();

            algValue.IV = IV;
            algValue.Key = Key;

            CryptoStream cs = new CryptoStream(fsOut, algValue.CreateEncryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);

                if (bytesRead > 0)
                {
                    cs.Write(buffer, 0, bytesRead);
                }

            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }
        public static void Decrypt(string fileIn, string fileOut)
        {
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
            TripleDES algValue = TripleDES.Create();

            algValue.IV = IV;
            algValue.Key = Key;

            CryptoStream cs = new CryptoStream(fsOut, algValue.CreateDecryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);

                if (bytesRead > 0)
                {
                    cs.Write(buffer, 0, bytesRead);
                }

            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }
        public static string Decrypt(Stream fsIn)
        {
            string temp = System.IO.Path.GetTempFileName();
            FileStream msOut = new FileStream(temp, FileMode.OpenOrCreate, FileAccess.Write);
            TripleDES algValue = TripleDES.Create();

            algValue.IV = IV;
            algValue.Key = Key;

            CryptoStream cs = new CryptoStream(msOut, algValue.CreateDecryptor(), CryptoStreamMode.Write | CryptoStreamMode.Read);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                bytesRead = fsIn.Read(buffer, 0, bufferLen);

                if (bytesRead > 0)
                {
                    cs.Write(buffer, 0, bytesRead);
                }

            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();

            StreamReader sr = new StreamReader(temp);
            string data = sr.ReadToEnd();
            sr.Close();

            return data;
        }
        public static string EncryptMD5(string password)
        {
            UTF8Encoding UT = new UTF8Encoding();
            MD5 md = MD5.Create();

            byte[] clearPassword = UT.GetBytes(password);
            byte[] encryptedPassword = md.ComputeHash(clearPassword);

            return Convert.ToBase64String(encryptedPassword);
        }
    }
}
