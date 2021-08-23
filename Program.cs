using System;
using System.Threading;
namespace ConsoleApp2
{
  class Program
  {
   static void Main(string[] args)
    
    {
      Console.BackgroundColor = ConsoleColor.Black;

      Console.ForegroundColor = ConsoleColor.Green;


      string abc = "1024";

      int x = Convert.ToInt32(abc);

      Console.WriteLine(x);

      Console.WriteLine("^2 + fr 100 2 1000");


      string b = Console.ReadLine();

      
      
      Console.WriteLine(b);

      int m = Convert.ToInt32(b);

      
       
      m = m * m;

      string srv = m > 100 ? "> 100" : "< 100";
      
      Console.WriteLine(m + " " + srv);

      Console.WriteLine("switch");
      
        string pp = Console.ReadLine();

      int swtch = Convert.ToInt32(pp);

      switch (swtch)

      {
        case 1:


          Console.WriteLine("1");
          break;

        case 5:
        case 7:
        case 9:


          Console.WriteLine("5 or 7 or 9");
          break;

        default:
          Console.WriteLine("no coincidence!");
          break;
      }

      if ((m > 100) && (m < 1000))
      {


        Console.WriteLine("from 101 to 999");



      }

      else

        Console.WriteLine("----------");

      for (int i = 0; i < 2000; i++)

      {
        Console.Write("1 0 1 0 1 1 1 0 1 0 0 ");

        Thread.Sleep(1);

      }























      Console.ReadKey();



    }
  }
}
