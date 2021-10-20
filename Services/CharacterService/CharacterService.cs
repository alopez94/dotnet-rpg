using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Controllers;
using dotnet_rpg.DTOs.Characters;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : iCharacterService
    {
        private static List<character> characters = new List<character> {
            new character(),
            new character {Id=1, name = "sam"}
        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;

        }

        public async Task<ServiceResponse<List<getCharacterDto>>> addCharacter(addCharacterDto newCharacter)
        {
            var ServiceResponse = new ServiceResponse<List<getCharacterDto>>();
            characters.Add(_mapper.Map<character>(newCharacter));
            ServiceResponse.Data = characters.Select(c => _mapper.Map<getCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<getCharacterDto>>> GetAllCharacters()
        {
            var ServiceResponse = new ServiceResponse<List<getCharacterDto>>();
            ServiceResponse.Data = characters.Select(c => _mapper.Map<getCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<getCharacterDto>> getCharacterbyID(int id)
        {

            var ServiceResponse = new ServiceResponse<getCharacterDto>();
            ServiceResponse.Data = _mapper.Map<getCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
            return ServiceResponse;
        }
    }
}