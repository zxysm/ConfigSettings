using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class PokemonTransfer
    {
        public int KeepMinCp { get; set; }
        public int KeepMinLvl { get; set; }
        public bool UseKeepMinLvl { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public int KeepMinDuplicatePokemon { get; set; }
        public string[] Moves { get; set; }
        public string MovesToDisplay { get; set; }
        public ConfigSettings.Config.Operator KeepMinOperator { get; set; }

        public override string ToString()
        {
            return "KeepMinCp: " + KeepMinCp + ", KeepMinDuplicatePokemon: " + KeepMinDuplicatePokemon;
        }
    }
}
