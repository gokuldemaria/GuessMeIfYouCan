
using System;
using num_finder.tools;
namespace num_finder
{
    public class Get // getting the data from the user such as starting and ending values.
    {
        private int START;
        private int END;

        public int start
        {
            get
            {
                return START;
            }
        }

        public int end
        {
            get
            {
                return END;
            }
        }


        public void getStart()
        {
            System.Console.Write("ENTER UR STARTING NUMBER :");
            int start = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            if (start > 0)
            {
                this.START = start;
                return;
            }
            else
            {
                ColorWritter.ColorMaker("The input must be a number greater than 0 !!", ConsoleColor.DarkCyan);
                System.Console.WriteLine("Please provide a valid input!");
                System.Console.WriteLine();
                getStart();
            }

        }

        public void getEnd()
        {
            System.Console.Write("ENTER UR ENDING RANGE :");
            int end = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            if (end > this.START + 200)
            {
                this.END = end;
                //System.Console.WriteLine($"{this.END} id the end");
            }
            else
            {
                ColorWritter.ColorMaker("The difference between starting and ending numbers must be 200!!", ConsoleColor.DarkCyan);
                System.Console.WriteLine("Please provide a valid Ending Number!");
                System.Console.WriteLine();
                getEnd();
            }


        }

        public void go()
        {
            System.Console.WriteLine($"We Generated A Number Between {this.START}, {this.end}");
            System.Console.WriteLine("To Win You Need To Guess The Number!!");
            System.Console.WriteLine("_______________________________________________________________________________________________");
            Operate op = new Operate();
            op.process(this.START, this.END);
        }
    }
}