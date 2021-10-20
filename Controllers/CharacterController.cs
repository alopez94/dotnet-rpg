using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<character> characters = new List<character> {
            new character(),
            new character {Id=1, name = "sam"}
        };
        [HttpGet("GetAll")]
       
        public ActionResult<List<character>> Get(){

            return Ok(characters);
        }
        [HttpGet("{id}")]
        public ActionResult<character> GetSingle(int id){

            return Ok(characters.FirstOrDefault(C => C.Id == id));
        }
        [HttpPost]
        public ActionResult<List<character>> AddCharacter(character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        } 
    }
}