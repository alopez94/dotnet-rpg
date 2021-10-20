using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class character
    {
        public int Id  { get; set; }
        public string name { get; set; } = "Frodo";
        public int hitPoints { get; set; } = 100;

        public int strengh { get; set; } = 10;

        public int defense { get; set; } = 10;

        public int inteligence { get; set; } = 10;

        public rpgClass Class { get; set; } = rpgClass.knights;


    }
}