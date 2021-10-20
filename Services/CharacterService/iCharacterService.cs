using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface iCharacterService
    {
        List<character> GetAllCharacters();
        character getCharacterbyID(int id);
        List<character> addCharacter(character newCharacter);
    }
}