using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // TODO - Our new GradeBook program needs some spec'd out requirements.
    // We need an electronic GradeBook to read the scores if an individual student
    // and then compute some simple statistics from the scores.
    // The grades are entered as floating point numbers from 0 to 100, and
    // the statistics should show us the highest grade, the lowest grade, and
    // the average grade.
    class Program
    {
        static void Main(string[] args)
        {
            // TODO- create a new grade book object to put test data into
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            // TODO - now we're going to eliminate the original gradebook in
            GradeBook book2 = book;
            book2.AddGrade(75);

        }
    }
}
