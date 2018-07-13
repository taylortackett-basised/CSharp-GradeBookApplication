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


        //Ranked-grading grades students not based on their individual performance, but rather their performance compared to their 
        //peers.This means the 20% of the students with the highest grade of a class get an A, the next highest 20% get a B, etc.
        //There are many ways to calculate this. I'd recommend figuring out how many students it takes to drop a letter 
        //grade (20% of the total number of students) X, put all the average grades in order, then figure out where the input 
        //grade would fit in the series of grades. Every X students with higher grades than the input grade knocks the letter grade 
        //down until you reach F.


    }

   
}

