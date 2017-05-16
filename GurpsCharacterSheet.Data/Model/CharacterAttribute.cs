using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    public class CharacterAttribute: RealmObject
    {
        public int Attribute { get; set; }
        public int Level { get; set; }
        public int CurrentValue { get; set; }

        public MainAttribute GetAttribute()
        {
            return MainAttribute.GetAttributeById(Attribute);
        }

        public void SetAttribute(MainAttribute attribute)
        {
            Attribute = attribute.Id;
        }
    }
}