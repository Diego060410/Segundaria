using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DegreeController : Controller
    {
        private readonly IDegreeRepository degreeRepository;
        private readonly IMapper mapper;

        public DegreeController(IDegreeRepository degreeRepository, IMapper mapper )
        {
            this.degreeRepository = degreeRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var degrees = await degreeRepository.GetAllAsync();
            return Ok(mapper.Map<List<Degree>>(degrees));
        }
    }
}
