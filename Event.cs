using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_Labenne_Examen_Advanced
{
    internal class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime date { get; set; }
        public Person[] invited { get; set; }
    }
}
