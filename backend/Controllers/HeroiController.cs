using Microsoft.AspNetCore.Mvc;
using backend.Repositories.Interfaces;
using backend.Models;
using backend.Services.Interfaces;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroiController : Controller
    {
        private IHeroiService _service;

        public HeroiController(IHeroiService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<HeroiModel>> Get()
        {
            return _service.GetHerois();
        }

        [HttpPost]
        public ActionResult<HeroiModel> Create([FromBody] HeroiModel model)
        {
            var returnModel = _service.Add(model);
            return returnModel;
        }

    }
}
