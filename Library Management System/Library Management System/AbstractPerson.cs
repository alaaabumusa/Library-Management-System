using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AbstractPerson(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void DisplayInfo();
    }

}
