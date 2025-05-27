using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Segundaria.DataModels;
using Segundaria.Repositories;

namespace Segundaria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParentController : Controller
    {
        private readonly IParentRepository parentRepository;
        private readonly IMapper mapper;

        public ParentController(IParentRepository parentRepository, IMapper mapper)
        {
            this.parentRepository = parentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var parents = await parentRepository.GetAllAsync();
            return Ok(mapper.Map<List<Parent>>(parents));
        }
    }
}
