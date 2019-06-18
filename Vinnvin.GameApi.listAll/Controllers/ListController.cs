using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vinnvin.GameApi.listAll.Contracts;
using Vinnvin.GameApi.listAll.Models;

namespace Vinnvin.GameApi.listAll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IListAllService _service;
        public ListController(IListAllService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Game>> ListAll()
        {
            return _service.ListAll().ToList();
        }
    }
}