using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstappMvc.Models;

namespace FirstappMvc.Controllers
{
    [ApiController]
    [Route("api/Clients")]
    public class ClientsController : Controller
    {
        private ClientsContext db;

        public ClientsController(ClientsContext context)
        {
            db = context;
        }

    //    [HttpGet]
    //     public IEnumerable<ClientMessage> Get()
    //     {
    //         return db.ClientMessage.ToList();
    //     }

        [HttpGet]
        public ClientMessage Get()
        {
            ClientMessage clientMessage = db.ClientMessage.OrderBy(x => x.Id).Last();
            return clientMessage;
        }
 
        [HttpGet("{id}")]
        public ClientMessage Get(int id)
        {
            ClientMessage clientMessage = db.ClientMessage.FirstOrDefault(x => x.Id == id);
            return clientMessage;
        }
 
        [HttpPost]
        public IActionResult Post(ClientMessage clientMessage)
        {
            if (ModelState.IsValid)
            {
                db.ClientMessage.Add(clientMessage);
                db.SaveChanges();
                return Ok(clientMessage);
            }
            return BadRequest(ModelState);
        }
 
        [HttpPut]
        public IActionResult Put(ClientMessage clientMessage)
        {
            if (ModelState.IsValid)
            {
                db.Update(clientMessage);
                db.SaveChanges();
                return Ok(clientMessage);
            }
            return BadRequest(ModelState);
        }
 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ClientMessage clientMessage = db.ClientMessage.FirstOrDefault(x => x.Id == id);
            if (clientMessage != null)
            {
                db.ClientMessage.Remove(clientMessage);
                db.SaveChanges();
            }
            return Ok(clientMessage);
        }
    }
}
