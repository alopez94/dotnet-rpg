using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Controllers;
using dotnet_rpg.DTOs.Characters;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface iCharacterService
    {
        Task<ServiceResponse<List<getCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<getCharacterDto>> getCharacterbyID(int id);
        Task<ServiceResponse<List<getCharacterDto>>> addCharacter(addCharacterDto newCharacter);
    }
}