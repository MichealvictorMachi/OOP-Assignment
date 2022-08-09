using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    //Base Interface Class
    internal interface INyscRules
    {
        public string BelowThirty { get; set; }
        public string NoFighting { get; set; }
        public string NoStealing { get; set; }  
    }
}
