using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.DTOs.Characters;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        
        private readonly iCharacterService _characterService;

        public CharacterController(iCharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]

        public async Task<ActionResult<ServiceResponse<List<getCharacterDto>>>> Get()
        {

            return Ok(await _characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<getCharacterDto>>> GetSingle(int id)
        {

            return Ok(await _characterService.getCharacterbyID(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<getCharacterDto>>>> AddCharacter(addCharacterDto newCharacter)
        {
          
            return Ok(await _characterService.addCharacter(newCharacter));
        }
    }
}