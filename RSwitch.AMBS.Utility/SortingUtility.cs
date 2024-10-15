using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RSwitch.AMBS.Utility
{
    public class SortingUtility<T>
    {
        public SortingUtility()
        {
        }

        public static void Sort(IList<T> list, String property)
        {
            Sort(list, property, Comparator<T>.SortOrder.Ascending);
        }

        public static void Sort(IList<T> list, String property, Comparator<T>.SortOrder sortOrder)
        {
            PropertyInfo propertyInfo = typeof(T).GetProperty(property);
            Comparator<T> cmp = new Comparator<T>(sortOrder);
            cmp.PropertyInfo = propertyInfo;
            ((List<T>)list).Sort(cmp);
        }

        public static void Sort(ArrayList list, System.Reflection.PropertyInfo propertyInfo)
        {
            Comparator cmp = new Comparator();
            cmp.PropertyInfo = propertyInfo;
            list.Sort(cmp);
        }

        public static void Sort(ArrayList list, System.Reflection.PropertyInfo propertyInfo, Comparator.SortOrder so)
        {
            Comparator cmp = new Comparator(so);
            cmp.PropertyInfo = propertyInfo;
            list.Sort(cmp);
        }
    }
    public class Comparator<T> : IComparer<T>
    {
        public SortOrder Order;
        public PropertyInfo PropertyInfo;

        public enum SortOrder
        {
            Ascending = 1,
            Desending = 2
        }

        public Comparator()
        {
            this.Order = SortOrder.Ascending;
        }

        public Comparator(SortOrder so)
        {
            this.Order = so;
        }

        private int Compare(double x, double y)
        {
            if (this.Order == SortOrder.Ascending)
            {
                if (x.CompareTo(y) > 0)
                {
                    return 1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (x.CompareTo(y) > 0)
                {
                    return -1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public int Compare(T x, T y)
        {
            object obj1 = this.PropertyInfo.GetValue(x, null);
            object obj2 = this.PropertyInfo.GetValue(y, null);

            if (obj1 == null || obj2 == null)
            {
                return 1;
            }

            if (this.PropertyInfo.PropertyType == typeof(int) || this.PropertyInfo.PropertyType == typeof(long) || this.PropertyInfo.PropertyType == typeof(double))
            {
                return Compare(Convert.ToDouble(obj1), Convert.ToDouble(obj2));
            }
            else if (this.PropertyInfo.PropertyType == typeof(DateTime))
            {
                if (this.Order == SortOrder.Ascending)
                {
                    if ((Convert.ToDateTime(obj1).CompareTo(Convert.ToDateTime(obj2))) > 0)
                    {
                        return 1;
                    }
                    else if (Convert.ToDateTime(obj1).Date == Convert.ToDateTime(obj2).Date)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if ((Convert.ToDateTime(obj1).CompareTo(Convert.ToDateTime(obj2))) > 0)
                    {
                        return -1;
                    }
                    else if (Convert.ToDateTime(obj1).Date == Convert.ToDateTime(obj2).Date)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            else
            {
                if (this.Order == SortOrder.Ascending)
                {
                    if (obj1.ToString().CompareTo(obj2.ToString()) > 0)
                    {
                        return 1;
                    }
                    else if (obj1 == obj2)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (obj1.ToString().CompareTo(obj2.ToString()) > 0)
                    {
                        return -1;
                    }
                    else if (obj1 == obj2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }

    public class SortingUtility
    {
        public SortingUtility()
        {
        }

        public static void Sort(ArrayList list, System.Reflection.PropertyInfo propertyInfo)
        {
            Comparator cmp = new Comparator();
            cmp.PropertyInfo = propertyInfo;
            list.Sort(cmp);
        }

        public static void Sort(ArrayList list, System.Reflection.PropertyInfo propertyInfo, Comparator.SortOrder so)
        {
            Comparator cmp = new Comparator(so);
            cmp.PropertyInfo = propertyInfo;
            list.Sort(cmp);
        }
    }

    public class Comparator : System.Collections.IComparer
    {
        public SortOrder Order;
        public System.Reflection.PropertyInfo PropertyInfo;

        public enum SortOrder
        {
            Ascending = 1,
            Desending = 2
        }

        public Comparator()
        {
            this.Order = SortOrder.Ascending;
        }

        public Comparator(SortOrder so)
        {
            this.Order = so;
        }

        private int Compare(double x, double y)
        {
            if (this.Order == SortOrder.Ascending)
            {
                if (x.CompareTo(y) > 0)
                {
                    return 1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (x.CompareTo(y) > 0)
                {
                    return -1;
                }
                else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public int Compare(object x, object y)
        {
            object obj1 = this.PropertyInfo.GetValue(x, null);
            object obj2 = this.PropertyInfo.GetValue(y, null);

            if (obj1 != null && obj2 == null)
            {
                return 1;
            }
            else if (obj1 == null && obj2 != null)
            {
                return -1;
            }
            else if (obj1 == null && obj2 == null)
            {
                return 0;
            }

            if (this.PropertyInfo.PropertyType == typeof(int) || this.PropertyInfo.PropertyType == typeof(long) || this.PropertyInfo.PropertyType == typeof(double))
            {
                return Compare(Convert.ToDouble(obj1), Convert.ToDouble(obj2));
            }
            else if (this.PropertyInfo.PropertyType == typeof(DateTime))
            {
                if (this.Order == SortOrder.Ascending)
                {
                    if ((Convert.ToDateTime(obj1).CompareTo(Convert.ToDateTime(obj2))) > 0)
                    {
                        return 1;
                    }
                    else if (Convert.ToDateTime(obj1).Date == Convert.ToDateTime(obj2).Date)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if ((Convert.ToDateTime(obj1).CompareTo(Convert.ToDateTime(obj2))) > 0)
                    {
                        return -1;
                    }
                    else if (Convert.ToDateTime(obj1).Date == Convert.ToDateTime(obj2).Date)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            else
            {
                if (this.Order == SortOrder.Ascending)
                {
                    if (obj1.ToString().CompareTo(obj2.ToString()) > 0)
                    {
                        return 1;
                    }
                    else if (obj1 == obj2)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (obj1.ToString().CompareTo(obj2.ToString()) > 0)
                    {
                        return -1;
                    }
                    else if (obj1 == obj2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
