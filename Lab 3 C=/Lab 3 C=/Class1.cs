using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_C_
{
    class Rhombus
    {
        public Point a;
        public Point b;
        public Point c;
        public Point d;
        public Rhombus(Point a, Point b, Point c, Point d)
        {
            this.a = a; this.b = b;
            this.c = c; this.d = d;
        }
        public Rhombus()
        {
            this.a.X = 0; this.a.Y = 0;
            this.b.X = 0; this.b.Y = 0;
            this.c.X = 0; this.c.Y = 0;
            this.d.X = 0; this.d.Y = 0;
        }
        public double GetArea()
        {
            double diagonal1 = Math.Sqrt(Math.Pow((c.X - a.X), 2) + Math.Pow((c.Y- a.Y), 2));
            double diagonal2 = Math.Sqrt(Math.Pow((d.X - b.X), 2) + Math.Pow((d.Y - b.Y), 2));
            return 0.5 * diagonal1 * diagonal2;
        }
        public double Length(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }
        public bool IsRhombus()
        {
            double ab = Length(a, b);
            double bc = Length(b, c);
            double cd = Length(c, d);
            double da = Length(d, a);
            if (ab == bc && bc == cd && cd == da)
            {
                int res = (a.X-c.X)*(b.X-d.X)+(a.Y-c.Y)*(b.Y-d.Y);
                if (a.X == b.X && b.X == c.X && c.X == d.X && a.Y == b.Y && b.Y == c.Y && c.Y == d.Y)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input is dot, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                else if (res == 0)
                {
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The given points do not form a rhombus, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The given points do not form a rhombus, try again");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        static public Rhombus operator +(Rhombus obj,double num)
        {
            obj.a.X += (int)num;
            obj.b.X += (int)num;
            obj.c.X += (int)num;
            obj.d.X += (int)num;
            return obj;
        }
        static public Rhombus operator +(double num, Rhombus obj)
        {
            obj.a.X += (int)num;
            obj.b.X += (int)num;
            obj.c.X += (int)num;
            obj.d.X += (int)num;
            return obj;
        }
        static public Rhombus operator +(Rhombus fst,Rhombus snd) 
        {
            int min = int.MaxValue;
            bool res = false;
            if (snd.a.X > 1 && snd.a.X < min)
            {
                min = snd.a.X;
                res = true;
            }
            if (snd.b.X > 1 && snd.b.X < min)
            {
                min = snd.b.X;
                res = true;
            }
            if (snd.c.X > 1 && snd.c.X < min)
            {
                min = snd.c.X;
                res = true;
            }
            if (snd.d.X > 1 && snd.d.X < min)
            {
                min = snd.d.X;
                res = true;
            }
            if (snd.a.Y > 1 && snd.a.Y < min)
            {
                min = snd.a.Y;
                res = true;
            }
            if (snd.b.Y > 1 && snd.b.Y < min)
            {
                min = snd.b.Y;
                res = true;
            }
            if (snd.c.Y > 1 && snd.c.Y < min)
            {
                min = snd.c.Y;
                res = true;
            }
            if (snd.d.Y > 1 && snd.d.Y < min)
            {
                min = snd.d.Y;
                res = true;
            }
            if(res) 
            { 
                fst.a.X += min;
                fst.b.X += min;
                fst.c.X += min;
                fst.d.X += min;
                fst.a.Y += min;
                fst.b.Y += min;
                fst.c.Y += min;
                fst.d.Y += min;
                return fst;
            }
            else
            {
                return fst;
            }
        }
        static public bool operator >(Rhombus fst, Rhombus snd)
        {
            if (fst.GetArea() > snd.GetArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator <(Rhombus fst, Rhombus snd)
        {
            if (fst.GetArea() < snd.GetArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public Rhombus operator --(Rhombus rhombus) 
        {
            rhombus.a.X -= 1;
            rhombus.b.X -= 1;
            rhombus.c.X -= 1;
            rhombus.d.X -= 1;
            rhombus.a.Y -= 1;
            rhombus.b.Y -= 1;
            rhombus.c.Y -= 1;
            rhombus.d.Y -= 1;
            return rhombus;
        }
        static public bool operator &(Rhombus a,Rhombus b)
        {
            if(a.a.X != 0 && a.a.Y != 0 && a.b.X != 0 && a.b.Y != 0 &&
           a.c.X != 0 && a.c.Y != 0 && a.d.X != 0 && a.d.Y != 0 &&
           b.a.X != 0 && b.a.Y != 0 && b.b.X != 0 && b.b.Y != 0 &&
           b.c.X != 0 && b.c.Y != 0 && b.d.X != 0 && b.d.Y != 0)
                return true; else return false;
        }
        public void Print()
        {
            Console.WriteLine("Rhombus coordinates:");
            Console.WriteLine("A({0},{1})", a.X, a.Y);
            Console.WriteLine("B({0},{1})", b.X, b.Y);
            Console.WriteLine("C({0},{1})", c.X, c.Y);
            Console.WriteLine("D({0},{1})", d.X, d.Y);
        }
    };

}
