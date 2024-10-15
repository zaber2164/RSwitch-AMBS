namespace RSwitch.AMBS.Utility
{
    public class DBUtility
    {
        public static Nullable<bool> ToNullableBoolean(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else if (value.ToString().ToLower() == "false" || value.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ToBoolean(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "" || value.ToString().ToLower() == "false" || value.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Nullable<DateTime> ToNullableDateTime(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToDateTime(value.ToString());
            }
        }

        public static Nullable<DateTime> ToNullableDateTime(string value)
        {
            if (value == null || value.ToString() == "")
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

        public static DateTime ToDateTime(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return new DateTime();
            }
            else
            {
                return Convert.ToDateTime(value.ToString());
            }
        }

        public static DateTime ToDateTime(string value)
        {
            if (value == null || value.ToString() == "")
            {
                return new DateTime();
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
                    return new DateTime();
                }
            }
        }

        public static Nullable<int> ToNullableInt32(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }

        public static int ToInt32(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }

        public static Nullable<long> ToNullableInt64(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToInt64(value);
            }
        }

        public static long ToInt64(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(value);
            }
        }

        public static Nullable<float> ToNullableSingle(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToSingle(value);
            }
        }

        public static float ToSingle(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToSingle(value);
            }
        }

        public static Nullable<double> ToNullableDouble(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }

        public static double ToDouble(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }

        public static double ToDouble(string value)
        {
            if (value == null || value.ToString() == "")
            {
                return 0;
            }
            else
            {
                double d;

                if (double.TryParse(value, out d))
                {
                    return d;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static string ToNullableString(object value)
        {
            if (value == null || value == DBNull.Value || value.ToString() == "")
            {
                return null;
            }
            else
            {
                return value.ToString().Trim();
            }
        }

        public static string ToString(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "";
            }
            else
            {
                return value.ToString().Trim();
            }
        }
    }
}
