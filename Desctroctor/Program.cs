using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desctroctor
{
    public enum States { Odisha, Kolkata, Mp, Bihar, Telengana }
    internal class Program
    {
        public string Selectstae(States s)
        {
            switch (s)
            {
                case States.Odisha:
                    return "You are selected Odisha";
                case States.Kolkata:
                    return "You are selected kolkata";
                case States.Mp:
                    return "You are selected Mp";
                case States.Bihar:
                    return "You are selected Bihar";
                case States.Telengana:
                    return "You are selected Telengana";

                default:
                    return "Please Select a State";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select a state");
            string input = Console.ReadLine();
            States Selectedstate = States.Odisha;
            if (input.ToLower() == "odisha")
            {
                Selectedstate = States.Odisha;
            }
            else if (input.ToLower() == "bihar")
            {
                Selectedstate = States.Bihar;
            }
            else if (input.ToLower() == "mp")
            {
                Selectedstate = States.Mp;
            }
            else if (input.ToLower() == "telengana")
            {
                Selectedstate = States.Telengana;
            }
            else
            {
                Console.WriteLine("Select a valid state");
            }
            Program program = new Program();
            var response = program.Selectstae(Selectedstate);
            Console.WriteLine(response);
        }

    }
}

