using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ćwiczenia_5.DTO_s.Request;

namespace Ćwiczenia_5.Services
{
    public interface IStudentDbService
    {
        void EnrollStudent(EnrollStudentRequest request);
        void PromoteStudent(int semester, string studies);
    }
}
