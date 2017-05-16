using System.Collections.Generic;
using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    /// <summary>
    /// A class representing an advantage (or disadvantage) for the character
    /// </summary>
    public class Advantage: RealmObject
    {
        public bool IsBeneficial { get; set; }
        public string Name { get; set; }
        public int IncreaseCost { get; set; }
        public int MaxLevel { get; set; }

        // ReSharper disable once UnassignedGetOnlyAutoProperty
        // Managed by Realm
        public IList<Skill>  RelatedSkills { get; }
    }
}