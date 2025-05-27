using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMapper mapper;

        public CourseController(ICourseRepository courseRepository, IMapper mapper)
        {
            this.courseRepository = courseRepository;  
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var courses = await courseRepository.GetAllAsync();
            return Ok(mapper.Map<List<Course>>(courses));
        }
    }
}
