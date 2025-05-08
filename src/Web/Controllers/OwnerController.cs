using application.Interfaces;
using domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _service;

        public OwnerController(IOwnerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => 
        
        Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var owner = _service.GetById(id);
            if (owner == null) return NotFound();
            return Ok(owner);
        }

        [HttpPost]
        public IActionResult Add(Owner owner)
        {
            _service.Add(owner);
            return CreatedAtAction(nameof(GetById), new { id = owner.Id }, owner);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Owner owner)
        {
            if (id != owner.Id) return BadRequest();
            _service.Update(owner);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
