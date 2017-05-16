using System;

namespace GurpsCharacterSheet.Data.Model
{
    public class MainAttribute
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ShortName { get; private set; }
        public int IncreaseCost { get; private set; }

        public static MainAttribute GetAttributeById(int id)
        {
            switch (id)
            {
                    case 1:
                        return STR;
                    case 2:
                        return DEX;
                    case 3:
                        return INT;
                    case 4:
                        return HT;
                    default:
                        throw new Exception("Unexpected attribute id => " + id);
            }
        }


        public static readonly MainAttribute STR =
            new MainAttribute {Id = 1, Name = "Strength", ShortName = "ST", IncreaseCost = 10};

        public static readonly MainAttribute DEX =
            new MainAttribute {Id = 2, Name = "Dexterity", ShortName = "DEX", IncreaseCost = 20};

        public static readonly MainAttribute INT =
                new MainAttribute {Id = 3, Name = "Intelligence", ShortName = "INT", IncreaseCost = 20};

        public static readonly MainAttribute HT =
                new MainAttribute {Id = 4, Name = "Health", ShortName = "HT", IncreaseCost = 10};
    }
}