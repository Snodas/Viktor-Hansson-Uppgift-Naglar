using GruppUppgiftNaglar.Core;
using GruppUppgiftNaglar.Services;

namespace GruppUppgiftNaglar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hs = new List<Hand>();

            var h = new Hand() { Position = Position.Left };

            h.Nails.Add(new Nail());

            hs.Add(h);

            hs = PedikyrService.ClipHands(hs);



            bool programRunning = true;

            while (programRunning == true)
            {
                Console.WriteLine("----Menu----");

                Console.WriteLine("1: New Day");
                Console.WriteLine("2: Trim nails");
                Console.WriteLine("3: Check nails");

                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:


                        break;

                    case 2:


                        break;

                    case 3:


                        break;

                    default:


                        break;
                }
            }
        }
    }
}
