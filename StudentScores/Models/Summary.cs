using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores.Models
{
    public class Summary
    {
        public int NumberOfStudents { get; set; }
        public int MinGrade { get; set; }
        public int MaxGrade { get; set; }
        public double AvgGrade { get; set; }
    }
}
