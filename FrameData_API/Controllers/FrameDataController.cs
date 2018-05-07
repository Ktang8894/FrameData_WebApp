using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FrameData_API.Models;

namespace FrameData_API.Controllers
{
    [Produces("application/json")]
    //[Route("api")]
    public class FrameDataController : Controller
    {
        private readonly MvCIContext _context;

        public FrameDataController(MvCIContext context)
        {
            _context = context;
        }

        //// GET: api/FrameData
        //[HttpGet]
        //public IEnumerable<FrameData> GetFrameData()
        //{
        //    return _context.FrameData;
        //}

        // GET: characterList
        [Route("characterList")]
        [HttpGet]
        public IActionResult GetFrameData()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var FrameData = _context.FrameData
                    .OrderBy(c => c.CharacterName)
                    .Select(c => c.CharacterName)
                    .Distinct();

            if (FrameData == null)
            {
                return NotFound();
            }

            return Ok(FrameData);
        }

        // GET: charName
        [HttpGet("{charName}")]
        public IActionResult GetFrameData([FromRoute] string charName, string char1, string char2)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var FrameData = _context.FrameData;

            if (FrameData == null)
            {
                return NotFound();
            }

            if (charName == "all")
            {
                var charList = _context.FrameData
                    .OrderBy(c => c.CharacterName)
                    .Select(c => c.CharacterName)
                    .Distinct();
                return Ok(charList);
            }

            if (char1 == null && char2 == null)
            {
                var selectedChar = _context.FrameData.Where(c => c.CharacterName == charName);
                return Ok(selectedChar);
            }

            if (char1 != null && char2 == null)
            {
                var selectedChar = _context.FrameData.FromSql("EXEC MvCI.SingleCharacterSelected {0}, {1}", charName, char1);
                return Ok(selectedChar);
            }

            return Ok(FrameData);
        }

        // POST: api/FrameData
        [HttpPost]
        public async Task<IActionResult> PostFrameData([FromBody] MvCIContext FrameData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FrameData.Add(FrameData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFrameData", new { id = FrameData.MoveId }, FrameData);
        }

        private bool FrameDataExists(int id)
        {
            return _context.FrameData.Any(e => e.MoveId == id);
        }
    }
}