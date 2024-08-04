using Microsoft.AspNetCore.Mvc;
using backend.Repositories.Interfaces;
using backend.Models;
using backend.Services.Interfaces;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<HeroiModel> Get(int id)
        {
            try
            {
                var model = _service.Get(id);
                return model == null ? NotFound() : model;
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpPost]
        public ActionResult<HeroiModel> Create([FromBody] HeroiModel model)
        {
            var returnModel = _service.Add(model);
            return returnModel;
        }

        [HttpPut]
        public ActionResult<HeroiModel> Update([FromBody] HeroiModel model)
        {
            return _service.Update(model);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            return _service.Delete(id) ? Ok() : BadRequest();
        }
    }
}
