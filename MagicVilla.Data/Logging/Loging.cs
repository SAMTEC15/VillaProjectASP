using MagicVilla.Data.Logging.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla.Data.Logging
{
    public class Loging : ILoging
    {
        // THIS CLASS AND IT INTERFACE IS OPTION, IS ONLY NEED IF WE WISH TO CREATE
        // A LOGGER MESSAGE IN THE ABSENT OF THE INPLICITLY BUILT ONE



        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.WriteLine("Error -" + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        //You use {builder.Services.AddSingleton<ILoging,  ILoging>();} to register it in the program.cs

    }
}
