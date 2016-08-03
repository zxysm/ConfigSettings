using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSettings
{
    class Config
    {
        public string TranslationLanguageCode { get; set; }
        public bool AutoUpdate { get; set; }
        public bool TransferConfigAndAuthOnUpdate { get; set; }
        public bool StartupWelcomeDelay { get; set; }
        public int AmountOfPokemonToDisplayOnStart { get; set; }
        public bool ShowPokeballCountsBeforeRecycle { get; set; }
        public bool AutomaticallyLevelUpPokemon { get; set; }
        public int AmountOfTimesToUpgradeLoop { get; set; }
        public int GetMinStarDustForLevelUp { get; set; }
    }
}
