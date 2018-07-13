using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public override char GetLetterGrade(double averageGrade)
        {
            return base.GetLetterGrade(averageGrade);
        }

        public InvalidOperationException error = new InvalidOperationException("Ranking-grading requires a minimum of 5 students to work.");

        public RankedGradeBook(string name) : base(name)
        {
            
            Type = Enums.GradeBookType.Ranked;
            
        }

        


    }

   
}

