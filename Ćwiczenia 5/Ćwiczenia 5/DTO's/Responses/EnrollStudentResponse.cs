using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ćwiczenia_5.DTO_s.Responses
{
    public class EnrollStudentResponse
    {
        public string LastName { get; set; }
        public int Semester { get; set; }
        public DateTime StartDate { get; set; }
    }
}
