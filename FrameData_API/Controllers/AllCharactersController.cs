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
    public class AllCharactersController : Controller
    {
        private readonly MvCIContext _context;

        public AllCharactersController(MvCIContext context)
        {
            _context = context;
        }

        //// GET: api/AllCharacters
        //[HttpGet]
        //public IEnumerable<AllCharacters> GetAllCharacters()
        //{
        //    return _context.AllCharacters;
        //}

        // GET: characterList
        [Route("characterList")]
        [HttpGet]
        public IActionResult GetAllCharacters()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var allCharacters = _context.AllCharacters
                    .OrderBy(c => c.CharacterName)
                    .Select(c => c.CharacterName)
                    .Distinct();

            if (allCharacters == null)
            {
                return NotFound();
            }

            return Ok(allCharacters);
        }

        // GET: charName
        [HttpGet("{charName}")]
        public IActionResult GetAllCharacters([FromRoute] string charName, string char1, string char2)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var allCharacters = _context.AllCharacters;

            if (allCharacters == null)
            {
                return NotFound();
            }

            if (charName == "all")
            {
                var charList = _context.AllCharacters
                    .OrderBy(c => c.CharacterName)
                    .Select(c => c.CharacterName)
                    .Distinct();
                return Ok(charList);
            }

            if (char1 == null && char2 == null)
            {
                var selectedChar = _context.AllCharacters.Where(c => c.CharacterName == charName);
                return Ok(selectedChar);
            }

            if (char1 != null && char2 == null)
            {
                var selectedChar = _context.AllCharacters.FromSql("EXEC MvCI.SingleCharacterSelected {0}, {1}", charName, char1);
                return Ok(selectedChar);
            }

            return Ok(allCharacters);
        }

        // POST: api/AllCharacters
        [HttpPost]
        public async Task<IActionResult> PostAllCharacters([FromBody] AllCharacters allCharacters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AllCharacters.Add(allCharacters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllCharacters", new { id = allCharacters.MoveId }, allCharacters);
        }

        private bool AllCharactersExists(int id)
        {
            return _context.AllCharacters.Any(e => e.MoveId == id);
        }
    }
}