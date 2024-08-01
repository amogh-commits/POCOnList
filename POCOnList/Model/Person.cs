using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOnList.Model
{
    public class Person
    {
        public int PersonId { get; set; }

        public string PersonName { get; set; }

        public Person(int personId,string personName)
        {
            PersonId = personId;
            PersonName = personName;
        }
    }
}
