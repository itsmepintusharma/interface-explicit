using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Explicit
{
    interface Ilegs
    {
        void Display();
    }
    interface IRun
    {
        void Display();
    }

    public class Horse : Ilegs, IRun
    {

        void Ilegs.Display()
        {
            this.ForDisplay();
        }
        public virtual void ForDisplay()
        {
            Console.WriteLine("It has four legs");
        }


        void IRun.Display()
        {
            Console.WriteLine("It can run");
        }
    }


    public class Hen : Horse, IRun
    {
        public override void ForDisplay()
        {
            Console.WriteLine("It has Two legs");
        }
        void IRun.Display()
        {
            Console.WriteLine("It can run");
        }

    }
    
     public class program
    {
        public static void Main()
        {

            Console.WriteLine("horse:");
            Ilegs ilegs = new Horse();
            ilegs.Display();

            IRun run = new Horse();
            run.Display();


            Console.WriteLine("Hen:");
            Ilegs ilegss = new Hen();
            ilegss.Display();

            IRun runs = new Hen();
            runs.Display();

            Console.ReadKey();

        }
    }
  
}
