using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status;
            status = true;

            while (status)

            {

                Console.WriteLine("Enter the measurement type");
                string mea_type = Console.ReadLine();
                Console.WriteLine("Enter the amount");
                string amount = Console.ReadLine();
                double giv_amount = double.Parse(amount);

                if (mea_type == "inch")
                {
                    double fidge_convert = giv_amount * 3.5;
                    Console.WriteLine(giv_amount + "  inches = " + fidge_convert + "  fidge spinners");
                }

                else if (mea_type == "fidge")
                {
                    double inch_convert = giv_amount / 3.5;
                    Console.WriteLine(giv_amount + "  fidget spinners = " + inch_convert + "  inches");
                }
                else if (mea_type == "feet")
                {
                    double memes_cenvert = giv_amount * 5;
                    Console.WriteLine(giv_amount + "  feet =  " + memes_cenvert + "  memes");
                }
                else if (mea_type == "memes")
                {
                    double feet_cenvert = giv_amount / 5;
                    Console.WriteLine(giv_amount + "  memes =  " + feet_cenvert + "  feet");
                }

                Console.WriteLine("Press y to continue n to exit");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    status = true;
                }
                else status = false;

                continue;


            }




        }
    }
}
