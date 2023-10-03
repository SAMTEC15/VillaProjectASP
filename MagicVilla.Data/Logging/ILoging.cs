using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVilla.Data.Logging.Logging
{
    public interface ILoging
    {
        public void Log(string message, string type);
    }
}
