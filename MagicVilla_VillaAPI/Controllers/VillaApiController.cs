using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Logging;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        private readonly ILogging _logger;
        public VillaApiController(ILogging logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.Log("Getting All Villas", "");
            return Ok(VillaStore.villaList);
        }

        [HttpGet("id", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                _logger.Log($"Get Villa Error with id " + id, "warning");
                return BadRequest();
            }

            var villa = VillaStore.villaList.FirstOrDefault(villa => villa.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO newVilla)
        {
            if (VillaStore.villaList.FirstOrDefault(villa => villa.Name.ToLower() == newVilla.Name.ToLower()) != null)
            {
                ModelState.AddModelError("NameValidation", "Villa already exists.");
                return BadRequest();
            }

            if (newVilla == null)
            {
                return BadRequest(newVilla);
            }
            if (newVilla.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            newVilla.Id = VillaStore.villaList.OrderByDescending(villa => villa.Id).FirstOrDefault().Id + 1;

            VillaStore.villaList.Add(newVilla);

            return CreatedAtRoute("GetVilla", new { id = newVilla.Id }, newVilla);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villaToBeRemoved = VillaStore.villaList.FirstOrDefault(villa => villa.Id == id);

            if (villaToBeRemoved == null)
            {
                return NotFound();
            }

            VillaStore.villaList.Remove(villaToBeRemoved);

            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateVilla(int id, [FromBody] VillaDTO updatedVilla)
        {
            if(updatedVilla == null || id != updatedVilla.Id)
            {
                return BadRequest();
            }

            VillaDTO villaToBeUpdated = VillaStore.villaList.FirstOrDefault(villa => villa.Id==id);

            if(villaToBeUpdated == null)
            {
                ModelState.AddModelError("", "Villa does not exist.");
                return NotFound();
            }

            villaToBeUpdated.Name = updatedVilla.Name;
            villaToBeUpdated.SqFt = updatedVilla.SqFt;
            villaToBeUpdated.Occupancy = updatedVilla.Occupancy;

            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchVilla)
        {
            if (patchVilla == null || id == 0)
            {
                return BadRequest();
            }

            VillaDTO villaToBePatched = VillaStore.villaList.FirstOrDefault(villa => villa.Id == id);

            if (villaToBePatched == null)
            {
                ModelState.AddModelError("", "Villa does not exist.");
                return NotFound();
            }

            patchVilla.ApplyTo(villaToBePatched, ModelState);

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
