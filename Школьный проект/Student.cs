using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Школьный_проект
{
    class Student
    {
        private const string SPACE = " ";

        public string Name { get; set; }

        public string Surname { get; set; }

        public Student(  )
        {
            Name = "";
            Surname = "";
        }

        public override string ToString( ) => Surname + SPACE + Name;
    }
}
