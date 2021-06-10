using num_finder.tools;
namespace num_finder
{
    public class Level
    {
        public static int levelNumber;


        public void hardShip(string level)
        {
            

            if (level.Equals("0"))
            {
                levelNumber = 10;
                System.Console.WriteLine();
                ColorWritter.ColorMaker($"You got {levelNumber} chances to guess", System.ConsoleColor.Magenta);
                System.Console.WriteLine();
            }
            else if (level.Equals("1"))
            {
                levelNumber = 7;
                System.Console.WriteLine();
                ColorWritter.ColorMaker($"You got {levelNumber} chances to guess", System.ConsoleColor.Magenta);
                System.Console.WriteLine();
            }
            else if (level.Equals("2"))
            {
                levelNumber = 5;
                System.Console.WriteLine();
                ColorWritter.ColorMaker($"You got {levelNumber} chances to guess", System.ConsoleColor.Magenta);
                System.Console.WriteLine();
            }

        }

        

        public int hardShip()
        {
            
            return levelNumber;

        }
    }
}