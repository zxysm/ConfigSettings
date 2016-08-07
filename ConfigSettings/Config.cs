using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConfigSettings
{
    class Config
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Power
        {
            cp,
            iv
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum Operator
        {
            and,
            or
        }

        public string TranslationLanguageCode { get; set; }
        public bool AutoUpdate { get; set; }
        public bool TransferConfigAndAuthOnUpdate { get; set; }
        public bool UseWebsocket { get; set; }
        public bool StartupWelcomeDelay { get; set; }
        public int AmountOfPokemonToDisplayOnStart { get; set; }
        public bool ShowPokeballCountsBeforeRecycle { get; set; }
        public bool CatchPokemon { get; set; }
        public bool AutomaticallyLevelUpPokemon { get; set; }
        public int AmountOfTimesToUpgradeLoop { get; set; }
        public int GetMinStarDustForLevelUp { get; set; }
        public Power LevelUpByCPorIv { get; set; }
        public float UpgradePokemonCpMinimum { get; set; }
        public float UpgradePokemonIvMinimum { get; set; }
        public Operator UpgradePokemonMinimumStatsOperator { get; set; }
        public bool DisableHumanWalking { get; set; }
        public decimal DefaultAltitude { get; set; }
        public decimal DefaultLatitude { get; set; }
        public decimal DefaultLongitude { get; set; }
        public float WalkingSpeedInKilometerPerHour { get; set; }
        public int MaxSpawnLocationOffset { get; set; }
        public int DelayBetweenPlayerActions { get; set; }
        public int DelayBetweenPokemonCatch { get; set; }
        public bool DumpPokemonStats { get; set; }
        public float EvolveAboveIvValue { get; set; }
        public bool EvolveAllPokemonAboveIv { get; set; }
        public bool EvolveAllPokemonWithEnoughCandy { get; set; }
        public float EvolveKeptPokemonsAtStorageUsagePercentage { get; set; }
        public bool KeepPokemonsThatCanEvolve { get; set; }
        public int KeepMinCp { get; set; }
        public float KeepMinIvPercentage { get; set; }
        public int KeepMinLvl { get; set; }
        public Operator KeepMinOperator { get; set; }
        public bool UseKeepMinLvl { get; set; }
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
        public bool UseSnipeLocationServer { get; set; }
        public string SnipeLocationServer { get; set; }
        public int SnipeLocationServerPort { get; set; }
        public bool GetSniperInfoFromPokezz { get; set; }
        public bool GetOnlyVerifiedSniperInfoFromPokezz { get; set; }
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
        public int TotalAmountOfRevivesToKeep { get; set; }
        public int TotalAmountOfBerriesToKeep { get; set; }
        public int UseGreatBallAboveCp { get; set; }
        public int UseUltraBallAboveCp { get; set; }
        public int UseMasterBallAboveCp { get; set; }
        public float UseGreatBallAboveIv { get; set; }
        public float UseUltraBallAboveIv { get; set; }
        public float UseGreatBallBelowCatchProbability { get; set; }
        public float UseUltraBallBelowCatchProbability { get; set; }
        public float UseMasterBallBelowCatchProbability { get; set; }
        public bool EnableHumanizedThrows { get; set; }
        public int NiceThrowChance { get; set; }
        public int GreatThrowChance { get; set; }
        public int ExcellentThrowChance { get; set; }
        public int CurveThrowChance { get; set; }
        public float ForceGreatThrowOverIv { get; set; }
        public float ForceExcellentThrowOverIv { get; set; }
        public int ForceGreatThrowOverCp { get; set; }
        public int ForceExcellentThrowOverCp { get; set; }
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
        public Dictionary<string, PokemonTransfer> PokemonsTransferFilter { get; set; }
        public PokemonToSnipe PokemonToSnipe { get; set; }
        public string[] PokemonToUseMasterball { get; set; }

        public PokemonTransferT[] ConvertTransferT()
        {
            PokemonTransferT[] PokemonsTransferFilterT = new PokemonTransferT[PokemonsTransferFilter.Count];
            int i = 0;
            foreach (KeyValuePair<string, PokemonTransfer> pkm in PokemonsTransferFilter)
            {
                PokemonsTransferFilterT[i] = new PokemonTransferT(pkm.Key, pkm.Value.KeepMinCp, pkm.Value.KeepMinLvl,
                                                                    pkm.Value.UseKeepMinLvl, pkm.Value.KeepMinIvPercentage,
                                                                    pkm.Value.KeepMinDuplicatePokemon, pkm.Value.Moves,
                                                                    pkm.Value.KeepMinOperator, pkm.Value.MovesOperator);
                i++;
            }
            return PokemonsTransferFilterT;
        }
        public void ConvertTransfer(PokemonTransferT[] PokemonTransferFilterT)
        {
            char[] charSep = new char[] { ',' };
            PokemonsTransferFilter = new Dictionary<string, PokemonTransfer>();
            foreach (PokemonTransferT pkmT in PokemonTransferFilterT)
            {
                PokemonTransfer pkm = new PokemonTransfer();
                pkm.KeepMinCp = pkmT.KeepMinCp;
                pkm.KeepMinLvl = pkmT.KeepMinLvl;
                pkm.UseKeepMinLvl = pkmT.UseKeepMinLvl;
                pkm.KeepMinIvPercentage = pkmT.KeepMinIvPercentage;
                pkm.KeepMinDuplicatePokemon = pkmT.KeepMinDuplicatePokemon;
                pkm.Moves = pkmT.MovesToDisplay.Split(charSep,StringSplitOptions.RemoveEmptyEntries);
                pkm.KeepMinOperator = pkmT.KeepMinOperator;
                pkm.MovesOperator = pkmT.MovesOperator;
                PokemonsTransferFilter.Add(pkmT.Key, pkm);
            }
        }
    }
}
