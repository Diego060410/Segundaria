using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentController( IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await studentRepository.GetAllAsync();
            return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
