using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI
{
    public class CustomExpetion : Exception
    {
        public CustomExpetion() :base("empty")
        {
        }
        public CustomExpetion(string message) :base(message)
        {
           
        }
    }
}
