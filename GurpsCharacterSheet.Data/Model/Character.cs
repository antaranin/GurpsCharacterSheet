using System.Collections.Generic;
using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    public class Character: RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public int TotalPoints { get; set; }
        public int UnspentPoints { get; set; }
        public int Age { get; set; }
        public IList<CharacterAttribute> Attributes { get; }
        public IList<CharacterAdvantage> Advantages { get; }
        public IList<CharacterAdvantage> Disadvanatages { get; }
        public IList<CharacterSkill> Skills { get; }

    }
}