using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    public class CharacterSkill: RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }
        public Skill Skill { get; set; }
        public int Level { get; set; }
    }
}