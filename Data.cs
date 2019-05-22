using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiManeger
{ 
    class Messege
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class TypeMessege : Messege
    {
        public string Type { get; set; }

    }

}
       
