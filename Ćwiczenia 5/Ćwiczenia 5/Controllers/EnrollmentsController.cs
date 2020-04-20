using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ćwiczenia_5.DTO_s.Request;
using Ćwiczenia_5.DTO_s.Responses;
using Ćwiczenia_5.Models;
using Ćwiczenia_5.Services;

namespace Ćwiczenia_5.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private IStudentDbService _service;

        public EnrollmentsController(IStudentDbService service)
        {
            this._service = service;
        }

        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {
            _service.EnrollStudent(request);
            var response = new EnrollStudentResponse();
            return Ok(response);
        }
    }
}