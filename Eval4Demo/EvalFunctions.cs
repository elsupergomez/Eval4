using System;

namespace Eval4.Demo
{
    /// <summary>
    /// Summary description for EvalFunctions.
    /// </summary>
    public class EvalFunctions 
    {
        public int aNumber = 5;

        public string[] anArray
        {
            get
            {
                // http://en.wikipedia.org/wiki/Piphilology
                return "How I want a drink alcoholic of course after the heavy lectures involving quantum mechanics".Split(' ');
            }
        }

        public string Description
        {
            get
            {
                return "This module contains all the common functions";
            }
        }

        public string Name
        {
            get
            {
                return "EvalFunctions";
            }
        }

        public System.Type systemType
        {
            get
            {
                return this.GetType();
            }
        }

        public double Sin(double v)
        {
            return System.Math.Sin(v);
        }

        public double Cos(double v)
        {
            return System.Math.Cos(v);
        }

        public DateTime Now()
        {
            return System.DateTime.Now;
        }

        public string Trim(string str)
        {
            return str.Trim();
        }

        public string LeftTrim(string str)
        {
            return str.TrimStart();
        }

        public string RightTrim(string str)
        {
            return str.TrimEnd();
        }

        public string PadLeft(string str, int wantedlen, string addedchar)
        {
            while ((str.Length < wantedlen))
            {
                str = (addedchar + str);
                // Warning!!! Optional parameters not supported
            }
            return str;
        }

        public double Mod(double x, double y)
        {
            return (x % y);
        }

        public object If(bool cond, object TrueValue, object FalseValue)
        {
            if (cond)
            {
                return TrueValue;
            }
            else
            {
                return FalseValue;
            }
        }

        public string Lower(string value)
        {
            return value.ToLower();
        }

        public string Upper(string value)
        {
            return value.ToUpper();
        }

        public string WCase(string value)
        {
            if ((value.Length == 0))
            {
                return "";
            }
            return (value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower());
        }

        public DateTime Date(int year, int month, int day)
        {
            return new DateTime(year, month, day);
        }

        public int Year(DateTime d)
        {
            return d.Year;
        }

        public int Month(DateTime d)
        {
            return d.Month;
        }

        public int Day(DateTime d)
        {
            return d.Day;
        }

        string Replace(string Base, string search, string repl)
        {
            return Base.Replace(search, repl);
        }

        public string Substr(string s, int from, int len)
        {
            if ((s == null))
            {
                return String.Empty;
            }
            // Warning!!! Optional parameters not supported
            from--;
            if ((from < 1))
            {
                from = 0;
            }
            if ((from >= s.Length))
            {
                from = s.Length;
            }
            if ((from + len) > s.Length)
            {
                len = (s.Length - from);
            }
            return s.Substring(from, len);
        }

        public int Len(string str)
        {
            return str.Length;
        }

        public double Abs(double val)
        {
            if ((val < 0))
            {
                return (val * -1);
            }
            else
            {
                return val;
            }
        }

        public int Int(double value)
        {
            return (int)(value);
        }

        public int Trunc(double value, int prec)
        {
            value = (value - (0.5 / System.Math.Pow(10, prec)));
            // Warning!!! Optional parameters not supported
            return (int)(System.Math.Round(value, prec));
        }

        public double Round(double value)
        {
            return System.Math.Round(value);
        }

        public string Chr(int c)
        {
            return "" + (char)(c);
        }

        public string ChCR()
        {
            return "\r";
        }

        public string ChLF()
        {
            return "\n";
        }

        public string ChCRLF()
        {
            return "\r\n";
        }

        public double Exp(double Base, double pexp)
        {
            return System.Math.Pow(Base, pexp);
        }

        public string[] Split(string s, string delimiter)
        {
            return s.Split(delimiter[0]);
            // Warning!!! Optional parameters not supported
        }

        System.DBNull DbNull()
        {
            return System.DBNull.Value;
        }

        public bool FileExists(string f)
        {
            return FileInfo(f).Exists;
        }

        public System.IO.FileInfo FileInfo(string f)
        {
            string altFilename = (System.Windows.Forms.Application.StartupPath + ("\\Data\\Scripts\\" + f));
            System.IO.FileInfo fi;
            fi = new System.IO.FileInfo(altFilename);
            if ((fi.Exists == false))
            {
                fi = new System.IO.FileInfo(f);
            }
            return fi;
        }

        public double Sqrt(double v)
        {
            return System.Math.Sqrt(v);
        }

        public double Power(double v, double e)
        {
            return System.Math.Pow(v, e);
        }

        public System.Type SystemType
        {
            get
            {
                return this.GetType();
            }
        }

    }
}
