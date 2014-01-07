using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            Double dRadius = 0.0;
            Double dVolume = 0.0;
            String strUserResponse = String.Empty;

            //Obtain the radius of the sphere
            Console.Write("Enter the radius of the sphere: ");
            strUserResponse = Console.ReadLine();
            dRadius = Convert.ToDouble(strUserResponse);

            //Calculate volume
            dVolume = (4.0/3.0) * Math.PI * (dRadius * dRadius * dRadius);

            //Inform user of the outcome
            Console.WriteLine("Volume: " + dVolume.ToString());
            Console.ReadLine();
        }
    }
}
