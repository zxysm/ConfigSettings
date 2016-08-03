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
        public bool UseIncenseConstantly { get; set; }
        public int UseBerriesMinCp { get; set; }
        public float UseBerriesMinIv { get; set; }
        public float UseBerriesBelowCatchProbability { get; set; }
        public Operator UseBerriesOperator { get; set; }
        public bool UseSnipeOnlineLocationServer { get; set; }
        public bool UseSniptLocationServer { get; set; }
        public string SnipeLocationServer { get; set; }
        public int SnipeLocationServerPort { get; set; }
        public int MinPokeballsToSnipe { get; set; }
        public int MinPokeballsWhileSnipe { get; set; }
        public int MinDelayBetweenSnipes { get; set; }
        public float SnipingScanOffset { get; set; }
        public bool SnipeAtPokestops { get; set; }
        public bool SnipeIgnoreUnknownIv { get; set; }
        public bool UseTransferIvForSnipe { get; set; }
        public bool RenamePokemon { get; set; }
        public bool RenameOnlyAboveIv { get; set; }
        public string RenameTemplate { get; set; }
        public int MaxPokeballsPerPokemon { get; set; }
        public int MaxTravelDistanceInMeters { get; set; }
        public int TotalAmountOfPokeballsToKeep { get; set; }
        public int TotalAmountOfPotionsToKeep { get; set; }
        public int TotalAmountOfRevicesToKeep { get; set; }
        public int TotalAmountOfBerriesToKeep { get; set; }
        public int UseGreatBallAboveCp { get; set; }
        public int UseUltraBallAboceCp { get; set; }
        public int UseMasterBallAboveCp { get; set; }
        public float UseGreatBallAboveIv { get; set; }
        public float UseUltraBallAboveIv { get; set; }
        public float UseGreatBallBelowCatchProbability { get; set; }
        public float UseUltraBallBelowCatchProbability { get; set; }
        public float UseMasterBallBelowCatchProbability { get; set; }
        public bool TransferWeakPokemon { get; set; }
        public bool TransferDuplicatePokemon { get; set; }
        public bool TransferDuplicatePokemonOnCapture { get; set; }
        public float FavoriteMinIvPercentage { get; set; }
        public bool AutoFavoritePokemon { get; set; }
        public bool UsePokemonToNotCatchFilter { get; set; }
        public bool UsePokemonSniperFilterOnly { get; set; }
        public int WebSocketPort { get; set; }
        public ItemRecycler[] ItemRecycleFilter { get; set; }
        public string[] PokemonsNotToTransfer { get; set; }
        public string[] PokemonsToEvolve { get; set; }
        public string[] PokemonsToIgnore { get; set; }
        //PokemonsTransferFilter
        public PokemonToSnipe PokemonToSnipe { get; set; }
        public string[] PokemonToUseMasterball { get; set; }
    }
}
