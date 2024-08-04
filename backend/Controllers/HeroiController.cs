using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services.Interfaces;
using backend.DTOs;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroiController : Controller
    {
        private IHeroiService _service;
        private IHeroiSuperpoderService _heroiSuperpoderService;
        private ISuperpoderService _superpoderService;

        public HeroiController(IHeroiService service,
                                IHeroiSuperpoderService heroiSuperpoderService,
                                ISuperpoderService superpoderService)
        {
            _service = service;
            _heroiSuperpoderService = heroiSuperpoderService;
            _superpoderService = superpoderService;
        }

        [HttpGet]
        public ActionResult<List<HeroiModel>> Get()
        {
            return _service.GetHerois();
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<PerfilDTO> Get(int id)
        {
            try
            {
                var perfilModel = new PerfilDTO();
                var model = _service.Get(id);
                perfilModel.Heroi = model;
                if (model != null)
                {
                    perfilModel.Heroi = model;
                    var hs = _heroiSuperpoderService.Get(id);
                    perfilModel.Superpoderes = _superpoderService.GetByIds(hs.Select(x => x.SuperpoderId).ToList());
                    return perfilModel;
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
                throw;
            }
        }

        [HttpPost]
        public ActionResult<HeroiModel> Create([FromBody] CadastroHeroiDTO model)
        {
            var homonimo = _service.GetByNomeHeroi(model.Heroi.NomeHeroi);
            if (homonimo != null)
            {
                return BadRequest("NOMEDEHEROI.EXISTENTE");
            }
            var returnModel = _service.Add(model.Heroi); foreach (var hs in model.SuperpoderesIds)
            {
                var HS = new HeroiSuperpoderModel();
                HS.HeroiId = returnModel.id.Value;
                HS.SuperpoderId = hs;
                HS = _heroiSuperpoderService.Add(HS);
            }

            return returnModel;
        }

        [HttpPut]
        public ActionResult<HeroiModel> Update([FromBody] CadastroHeroiDTO model)
        {
            var homonimo = _service.GetByNomeHeroi(model.Heroi.NomeHeroi);
            if (homonimo != null && homonimo.id != model.Heroi.id)
            {
                return BadRequest("NOMEDEHEROI.EXISTENTE");
            }

            var superpoderes = _heroiSuperpoderService.Get(model.Heroi.id.Value);
            var superpoderesIds = superpoderes.Select(s => s.SuperpoderId).ToList();

            var novos = model.SuperpoderesIds.Where(s => !superpoderesIds.Contains(s)).ToList();

            foreach (var n in novos)
            {
                var HS = new HeroiSuperpoderModel();
                HS.HeroiId = model.Heroi.id.Value;

                HS.SuperpoderId = n;
                _heroiSuperpoderService.Add(HS);
            }
            var excluidos = superpoderesIds.Where(s => !model.SuperpoderesIds.Contains(s));

            foreach (var e in excluidos)
            {
                _heroiSuperpoderService.Delete(model.Heroi.id.Value, e);
            }

            return _service.Update(model.Heroi);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {

            return _service.Delete(id) ? Ok() : BadRequest();
        }
    }
}
