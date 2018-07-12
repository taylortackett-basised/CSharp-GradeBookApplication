using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)                  // adding : base(name) after constructor declaration makes the program execute code in both classes (parent/child)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
