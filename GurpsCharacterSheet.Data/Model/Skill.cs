using Realms;

namespace GurpsCharacterSheet.Data.Model
{
    public class Skill: RealmObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RelatedAttribute { get; set; }

        public MainAttribute GetRelatedAttribute()
        {
            return MainAttribute.GetAttributeById(RelatedAttribute);
        }

        public void SetRelatedAttribute(MainAttribute attribute)
        {
            RelatedAttribute = attribute.Id;
        }
    }
}