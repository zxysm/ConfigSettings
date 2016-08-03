using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class Config
    {
        public enum Power
        {
            cp,
            iv
        }

        public enum Operator
        {
            and,
            or
        }

        public string TranslationLanguageCode { get; set; }
        public bool AutoUpdate { get; set; }
        public bool TransferConfigAndAuthOnUpdate { get; set; }
        public bool StartupWelcomeDelay { get; set; }
        public int AmountOfPokemonToDisplayOnStart { get; set; }
        public bool ShowPokeballCountsBeforeRecycle { get; set; }
        public bool AutomaticallyLevelUpPokemon { get; set; }
        public int AmountOfTimesToUpgradeLoop { get; set; }
        public int GetMinStarDustForLevelUp { get; set; }
        public Power LevelUpByCPOrIv { get; set; }
        public float UpgradePokemonCpMinimum { get; set; }
        public float UpgradePokemonIvMinimum { get; set; }
        public Operator UpgradePokemonMinimumStatsOperator { get; set; }
        public bool DisableHumanWalking { get; set; }
        public float DefaultAltitude { get; set; }
        public float DefaultLatitude { get; set; }
        public float DefaultLongitude { get; set; }
        public float WalkingSpeedInKilometerPerHour { get; set; }
        public int MaxSpawnLocationOffset { get; set; }
        public int DelayBetweenPlayerActions { get; set; }
        public int DelayBetweenPokemonCatch { get; set; }
        public bool DumpPokemonStats { get; set; }
        public float EvolveAboveIvValue { get; set; }
        public bool EvolveAllPokemonAboveIv { get; set; }
        public bool EvolveAllPokemonWithEnoughCandy { get; set; }
        public float EvolveKeptPokemonAtStorageUsagePercentage { get; set; }
        public bool KeepPokemonsThatCanEvolve { get; set; }
        public int KeepMinCp { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public Operator KeepMinOperator { get; set; }
        public bool PrioritizeIvOverCp { get; set; }
        public int KeepMinDuplicatePokemon { get; set; }
        public bool UseGpxPathing { get; set; }
        public string GpxFile { get; set; }
        public bool VerboseRecycling { get; set; }
        public float RecycleInventoryAtUsagePercentage { get; set; }
        public bool UseEggIncubators { get; set; }
        public bool UseLuckyEggConstantly { get; set; }
        public int UseLuckyEggsMinPokemonAmount { get; set; }
        public bool UseLuckyEggsWhileEvolving { get; set; }

    }
}
