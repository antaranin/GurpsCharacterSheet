using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    public class CharacterAdvantage: RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }
        public Advantage Advantage { get; set; }
        public int Level { get; set; }
    }
}