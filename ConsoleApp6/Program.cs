using System;
public class Ejemplo_05_11a 
{ 
    public static int Main(string[] args) 
    {
        int x, y;
        try
        {
            x = Convert.ToInt32(args[0]);
        }
        catch (FormatException)
        {
            Environment.Exit(2);
        }
        try
        {
            y = Convert.ToInt32(args[0]);
        }
        catch (FormatException)
        {
            Environment.Exit(2);
        }

        switch (args[1])
            {
                case "+":
                    Console.WriteLine(Convert.ToInt32(args[0]) + (Convert.ToInt32(args[2]))); return 0;
                case "-":
                    Console.WriteLine(Convert.ToInt32(args[0]) - (Convert.ToInt32(args[2]))); return 0;
                case "*":
                    Console.WriteLine(Convert.ToInt32(args[0]) * (Convert.ToInt32(args[2]))); return 0;
                case "/":
                    Console.WriteLine(Convert.ToInt32(args[0]) / (Convert.ToInt32(args[2]))); return 0;
                default: Environment.Exit(1); break;
            }

          return 0;
    } 
}