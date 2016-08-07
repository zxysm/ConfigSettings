using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class PokemonTransferComparer : IEqualityComparer<PokemonTransferT>
    {
        public bool Equals(PokemonTransferT x, PokemonTransferT y)
        {
            return x.Key == y.Key;
        }

        public int GetHashCode(PokemonTransferT obj)
        {
            return obj.Key.GetHashCode();
        }
    }
    class PokemonTransferT
    {
        public string Key { get; set; }
        public int KeepMinCp { get; set; }
        public int KeepMinLvl { get; set; }
        public bool UseKeepMinLvl { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public int KeepMinDuplicatePokemon { get; set; }
        public string MovesToDisplay { get; set; }
        public ConfigSettings.Config.Operator KeepMinOperator { get; set; }
        public ConfigSettings.Config.Operator MovesOperator { get; set; }
        public PokemonTransferT(string Key, int KeepMinCp, int KeepMinLvl, 
                                bool UseKeepMinLvl, float KeepMinIvPercentage,
                                int KeepMinDuplicatePokemon, string[] Moves, 
                                Config.Operator KeepMinOperator, Config.Operator MovesOperator)
        {
            this.Key = Key;
            this.KeepMinCp = KeepMinCp;
            this.KeepMinLvl = KeepMinLvl;
            this.UseKeepMinLvl = UseKeepMinLvl;
            this.KeepMinIvPercentage = KeepMinIvPercentage;
            this.KeepMinDuplicatePokemon = KeepMinDuplicatePokemon;
            this.MovesToDisplay = string.Join(",", Moves);
            this.KeepMinOperator = KeepMinOperator;
            this.MovesOperator = MovesOperator;
        }
        public PokemonTransferT()
        {
            this.Key = "";
            this.KeepMinCp = 0;
            this.KeepMinLvl = 0;
            this.UseKeepMinLvl = false;
            this.KeepMinIvPercentage = 0;
            this.KeepMinDuplicatePokemon = 0;
            this.MovesToDisplay = "";
            this.KeepMinOperator = Config.Operator.or;
            this.MovesOperator = Config.Operator.or;
        }
    }
    class PokemonTransfer
    {
        public int KeepMinCp { get; set; }
        public int KeepMinLvl { get; set; }
        public bool UseKeepMinLvl { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public int KeepMinDuplicatePokemon { get; set; }
        public string[] Moves { get; set; }
        public ConfigSettings.Config.Operator KeepMinOperator { get; set; }
        public ConfigSettings.Config.Operator MovesOperator { get; set; }
        public PokemonTransfer()
        {
            this.KeepMinCp = 0;
            this.KeepMinLvl = 0;
            this.UseKeepMinLvl = false;
            this.KeepMinIvPercentage = 0;
            this.KeepMinDuplicatePokemon = 0;
            this.KeepMinOperator = Config.Operator.or;
            this.MovesOperator = Config.Operator.or;
        }
    }
}
