using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepClan.Models
{
    public class PersonDatabase : List<Person>
    {
        public PersonDatabase()
        {
            Add(new Person() { PersonId = 1, PersonName = "MS" });
            Add(new Person() { PersonId = 2, PersonName = "SA" });
            Add(new Person() { PersonId = 3, PersonName = "VP" });
        }
    }
}
