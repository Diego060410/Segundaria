using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TuitionController : Controller
    {
        private readonly ITuitionRepository tuitionRepository;
        private readonly IMapper mapper;

        public TuitionController(ITuitionRepository tuitionRepository, IMapper mapper)
        {
            this.tuitionRepository = tuitionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tuitions = await tuitionRepository.GetAllAsync();
            return Ok(mapper.Map<List<Tuition>>(tuitions));
        }
    }
}
