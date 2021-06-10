using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDapp.Models
{
    public class MainContents
    {
        [JsonProperty("ability-scores")]
        public string abilityScores { get; set; }
        public string alignments { get; set; }
        public string backgrounds { get; set; }
        public string classes { get; set; }
        public string conditions { get; set; }
        [JsonProperty("damage-types")]
        public string damageTypes { get; set; }
        [JsonProperty("equipment-categories")]
        public string equipmentCategories { get; set; }
        public string equipment { get; set; }
        public string features { get; set; }
        public string languages { get; set; }
        [JsonProperty("magic-items")]
        public string magicItems { get; set; }
        [JsonProperty("magic-schools")]
        public string magicSchools { get; set; }
        public string monsters { get; set; }
        public string proficiencies { get; set; }
        public string races { get; set; }
        public string rules { get; set; }
        [JsonProperty("rule-sections")]
        public string ruleSections { get; set; }
        public string skills { get; set; }
        public string spells { get; set; }
        [JsonProperty("starting-equipment")]
        public string startingEquipment { get; set; }
        public string subclasses { get; set; }
        public string subraces { get; set; }
        public string traits { get; set; }
        [JsonProperty("weapon-properties")]
        public string weaponProperties { get; set; }
    }
}
