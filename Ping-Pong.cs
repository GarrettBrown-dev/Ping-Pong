using System;

namespace PingPong
{
  public class Display
  {
    public static void Main()
    {
      Console.WriteLine("Pick number, any number!");
      int userNumber;
      string stringUserNumber = Console.ReadLine();
      bool parseSuccess = int.TryParse(stringUserNumber, out userNumber);
      if (parseSuccess)
      {


        for (int i = 1; i <= userNumber; i++)
        {
          if (i % 3 == 0 && i % 5 == 0)
          {
            Console.WriteLine("ping-pong");
          }
          else if (i % 3 == 0)
          {
            Console.WriteLine("ping");
          }
          else if (i % 5 == 0)
          {
            Console.WriteLine("pong");
          }
          else
          {
            Console.WriteLine(i);
          }

        }
      }
      else
      {
        Console.WriteLine("Not a Number");
      }

    }
  }
}
