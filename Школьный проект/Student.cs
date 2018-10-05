using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Школьный_проект
{
    class Student
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }

        public string Surname { get => surname; set => surname = value; }

        public Student(  )
        {
            this.name = "";
            this.surname = "";
        }

        public override string ToString( )
        {
            return surname + ", " + name;
        }
    }
}
