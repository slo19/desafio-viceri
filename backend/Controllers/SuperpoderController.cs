using Microsoft.AspNetCore.Mvc;
using backend.Repositories.Interfaces;
using backend.Models;
using backend.Services.Interfaces;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperpoderController : Controller
    {
        private ISuperpoderService _service;

        public SuperpoderController(ISuperpoderService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<SuperpoderModel>> Get(string token)
        {
            return _service.Get(token);
        }

        [HttpPost]
        public ActionResult<SuperpoderModel> Add([FromBody] SuperpoderModel model)
        {
            return _service.Add(model);
        }
    }
}
