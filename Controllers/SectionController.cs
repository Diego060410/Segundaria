using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SectionController : Controller
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IMapper mapper;

        public SectionController(ISectionRepository sectionRepository, IMapper mapper)
        {
            this.sectionRepository = sectionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sections = await sectionRepository.GetAllAsync();
            return Ok(mapper.Map<List<Section>>(sections));
        }   
    }
}
