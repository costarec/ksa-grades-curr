using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // members of this class that store state or data

        // members of this class that do things - actions - methods

        // here is the replacement for the default ctor 
        public GradeBook()
        {
            // create the collection of grades
            grades = new List<float>();
        }

        // Add a grade to this gradebook 
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        // never assigned to and will always have an initial value of null
        List<float> grades;
    }
}

