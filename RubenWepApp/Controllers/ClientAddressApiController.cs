using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RubenWepApp.Models;

namespace RubenWepApp.Controllers
{
    
    public class ClientAddressApiController : ApiController
    {
        private readonly ClientAddressRepo _clientAddressRepo = new ClientAddressRepo(new ClientAddressEntities());
        protected LogMessageFromRepo logMessage = new LogMessageFromRepo();

        [HttpGet]
        public IEnumerable<ClientAddressItem> Get()
        {
            return _clientAddressRepo.GetAll();
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] ClientAddressItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            logMessage = _clientAddressRepo.Add(item);

            if (!logMessage.Success)
            {
                return BadRequest(logMessage.LogMessage);
            }

            return CreatedAtRoute("GetById", new { id = item.ID }, item);
        }


        [HttpGet]
        [Route("api/ClientAddressApi/{id}", Name = "GetById")]
        public IHttpActionResult GetById(int id)
        {
            var item = _clientAddressRepo.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return Json(item);
        }


        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] ClientAddressItem item)
        {
            if (item == null || item.ID != id)
            {
                return BadRequest();
            }

            var getActual = _clientAddressRepo.Find(id);

            if (getActual.ID != id)
            {
                return NotFound();
            }

            logMessage = _clientAddressRepo.Update(item);

            if (!logMessage.Success)
            {
                return BadRequest(logMessage.LogMessage);
            }

            return Ok();
        }


        //[HttpDelete]
        //[AcceptVerbs("DELETE")]
        public IHttpActionResult borrar([FromBody] int id)
        {
            var getActual = _clientAddressRepo.Find(id);

            if (getActual.ID != id)
            {
                return NotFound();
            }

            logMessage = _clientAddressRepo.Remove(getActual.ID);

            if (!logMessage.Success)
            {
                return BadRequest(logMessage.LogMessage);
            }

            return Ok();
        }
    }
}
