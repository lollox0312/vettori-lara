using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vettori_lara
{
    internal class Vettore
    {  public double X { get; set; }
        public double Y { get; set; }
       
        public Vettore(double x, double y)
        { X=x;
          Y=y; 
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", X, Y);
        }

        public static  Vettore Parse(string s)
        { string[] parts=s.Split(';');
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);
            Vettore vec=new Vettore(a, b);
            return vec;
        }
        public static bool TryParse(string c, out Vettore k)
        {
            try{
                k = Vettore.Parse(c);
                return true;
            }
            catch
            {
                k = null;
                return false; 
            }
        }
        public static Vettore operator*(Vettore v,double d)
        {   Vettore s= new Vettore (v.X+d, v.Y+d);
            return s;
        }
        public static Vettore operator *( double d,Vettore v)
        {
            Vettore s = new Vettore(v.X + d, v.Y + d);
            return s;
        }
        public static Vettore operator +(Vettore v, Vettore w)
        {
            Vettore s = new Vettore(v.X + w.X, v.Y + w.Y);
            return s;
        }
        public static Vettore operator -(Vettore v, Vettore w)
        {
            Vettore s = new Vettore(v.X - w.X, v.Y - w.Y);
            return s;
        }

        public static Vettore operator /(double t, Vettore v)
        {
            Vettore s = 1/t * v; 
            return s;
        }
        public static bool operator == (Vettore v1, Vettore v2)
        {
            if (object.ReferenceEquals(v1, null))
                return object.ReferenceEquals(v2, null);
            else if (object.ReferenceEquals(v2, null))
                return false;
            else return v1.X==v2.X && v1.Y==v2.Y;
        }
        public static bool operator!=(Vettore v1,Vettore v2)
        {
            return!(v1==v2);
        }

    }
}
