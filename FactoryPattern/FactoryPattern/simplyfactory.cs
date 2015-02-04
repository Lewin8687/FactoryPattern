using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FactoryPattern
{
    public abstract class Food
    {
        public abstract void print();
    }

    public class A : Food
    {
        public override void print()
        {
            Console.WriteLine("A");
        }
    }
    public class B : Food
    {
        public override void print()
        {
            Console.WriteLine("B");
        }
    }

    class Factory
    {
        public static Food cook(string str)
        {
            Food fo = null;
            if(str=="a")
            { fo = new A(); }
            else
            { fo = new B(); }
            return fo;
        }
    }
    class simplyfactory
    {
        static void Main(string[] args)
        {
            //Food f = Factory.cook("a");
            //f.print();
            //Food d = Factory.cook("b");
            //d.print();
            //Console.Read();
            
            /*value type and reference type*/
            //int i = 123;
            //object o = i;
            //int c = (int)o;
            //Console.Write(c);
            //Console.Read();

            /*hashtable*/
            //Hashtable hs = new Hashtable();

            //hs.Add(1, "a");
            //hs.Add(2, "b");
            //hs.Add(3, "a");
            //IDictionaryEnumerator ie = hs.GetEnumerator();
            //hs.Contains("a");
            //while (ie.MoveNext())
            //{
            //    string str = ie.Value.ToString();
            //    Console.WriteLine(str);
            //}
            //Console.Read();
        }
    }
}
