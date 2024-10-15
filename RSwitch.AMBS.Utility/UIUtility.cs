namespace RSwitch.AMBS.Utility
{
    public static class UIUtility
    {
        public static string DecryptConnectionString(string cipherConnectionString)
        {
            string[] parts = cipherConnectionString.Split(new char[] { ';' });
            int p = -1;

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].TrimStart().ToLower().StartsWith("password="))
                {
                    p = i;
                    break;
                }
            }

            if (p >= 0)
            {
                parts[p] = "Password=" + Cryptography.Decrypt(parts[p].TrimStart().Remove(0, 9));

                string connectionString = "";

                for (int i = 0; i < parts.Length; i++)
                {
                    connectionString += parts[i] + ";";
                }

                return connectionString;
            }
            else
            {
                return cipherConnectionString;
            }
        }

        public static Nullable<DateTime> ToNullableDateTime(String value)
        {
            if (value == null || value.ToString() == "" || value.ToString() == "&nbsp;")
            {
                return null;
            }
            else
            {
                DateTime d;

                if (DateTime.TryParse(value, out d))
                {
                    return d;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}