using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// yabo class yajia class
    /// </summary>
    public abstract class yabo
    {
        public abstract void print();
    }
    public class hunanyabo:yabo
    {
        public override void print()
        {
            Console.WriteLine("hunanyabo");
        }
    }
    public class shanghaiyabo : yabo
    {
        public override void print()
        {
            Console.WriteLine("shanghaiyabo");
        }
    }
    public abstract class yajia
    {
        public abstract void print();
    }
    public class hunanyajia:yajia
    {
        public override void print()
        {
            Console.WriteLine("hunanyajia");
        }
    }
    public class shanghaiyajia : yajia
    {
        public override void print()
        {
            Console.WriteLine("shanghaiyajia");
        }
    }
    /// <summary>
    /// factory
    /// </summary>
    public abstract class absfactory
    {
        public abstract yabo createyabo();
        public abstract yajia createyajia();
    }
    public class hunanfactory:absfactory
    {
        public override yabo createyabo()
        {
            return new hunanyabo();
        }
        public override yajia createyajia()
        {
            return new hunanyajia();
        }
    }
    public class shanghaifactory : absfactory
    {
        public override yabo createyabo()
        {
            return new shanghaiyabo();
        }
        public override yajia createyajia()
        {
            return new shanghaiyajia();
        }
    }
    class abstractfactory
    {
        //static void Main(string[] args)
        //{
        //    absfactory hunan = new hunanfactory();
        //    yabo hnyabo = hunan.createyabo();
        //    hnyabo.print();

        //    hunan = new shanghaifactory();
        //    Console.Read();
        //}
    }
}
