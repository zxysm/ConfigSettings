using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class PokemonTransfer
    {
        public string Name { get; set; }
        public int KeepMinCp { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public int KeepMinDuplicatePokemon { get; set; }
        public string[] Moves { get; set; }
        public ConfigSettings.Config.Operator KeepMinOperator { get; set; }
    }
}
