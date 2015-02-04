using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class shirt
    {
        public abstract void print();
    }
    public class t_shirt:shirt
    {
        public override void print()
        {
            Console.WriteLine("t_shirt");
        }
    }
    public class v_shirt : shirt
    {
        public override void print()
        {
            Console.WriteLine("v_shirt");
        }
    }
    public abstract class Creator
    {
        public abstract shirt factory();
    }
    public class tfactory:Creator
    {
        public override shirt factory()
        {
            return new t_shirt();
        }
    }
    public class vfactory : Creator
    {
        public override shirt factory()
        {
            return new v_shirt();
        }
    }
    class factorypattern
    {
        //static void Main(string[] args)
        //{
        //    Creator a = new tfactory();
        //    shirt t = a.factory();
        //    t.print();

        //    a = new vfactory();
        //    shirt v = a.factory();
        //    v.print();

        //    Console.Read();
        //}
    }
}
