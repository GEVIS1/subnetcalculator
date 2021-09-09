using DocoptNet;
using System;

namespace subnetcalculator
{
    class Program
    {
        private const string usage = @"Subnet Mask calulator.

            Usage:
              subnet.exe <ip> [mask]
              subnet.exe 
              subnet.exe 
              subnet.exe 
              subnet.exe (-h | --help)
              subnet.exe --version

            Options:
              -h --help     Show this screen.
              --version     Show version.
              --speed=<kn>  Speed in knots [default: 10].
              --moored      Moored (anchored) mine.
              --drifting    Drifting mine.

            ";

        static void Main(string[] args)
        {
            var arguments = new Docopt().Apply(usage, args, version: "Subnet Mask Calculator 0.1", exit: true);
            foreach (var argument in arguments)
            {
                Console.WriteLine("{0} = {1}", argument.Key, argument.Value);
            }

            Console.ReadKey();
        }
    }
}
