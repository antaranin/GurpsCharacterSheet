using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GurpsCharacterSheet.Core.IServices;
using GurpsCharacterSheet.Data.Model;

namespace GurpsCharacterSheet.Core.Services
{
    public class DummyCharacterProvider: ICharacterProvider
    {
        private Character _dummyCharacter;

        public DummyCharacterProvider()
        {
            _dummyCharacter = new Character
            {
                Name = "Steve Stevenson",
                Age = 42,
                Id = "Id",
                TotalPoints = 250,
                UnspentPoints = 0,
            };
            var skills = CreateDummyCharacterSkills(CreateDummySkills());
            foreach (var skill in skills)
            {
                _dummyCharacter.Skills.Add(skill);
            }
        }
        public Task<Character> GetCurrentCharacter()
        {
            return Task.Run(() => _dummyCharacter);
        }

        public Task<Character> GetCharacterWithId(string characterId)
        {
            return Task.Run(() => _dummyCharacter);
        }

        private List<CharacterSkill> CreateDummyCharacterSkills(List<Skill> dummySkills)
        {
            var enumerator = 0;
            return dummySkills.Select(skill =>
            {
                enumerator++;
                return new CharacterSkill {Id = enumerator.ToString(), Level = enumerator % 3, Skill = skill};
            }).ToList();
        }

        private List<Skill> CreateDummySkills()
        {
            return new List<Skill>
            {
                new Skill{ Id = "1", Name = "Juggling", Description = "You are awesome at juggling cats!", RelatedAttribute = MainAttribute.DEX.Id},
                new Skill{ Id = "2", Name = "Stabbing", Description = "You are awesome at stabbing people!", RelatedAttribute = MainAttribute.DEX.Id},
                new Skill{ Id = "3", Name = "Running", Description = "I think you can figure out what it does", RelatedAttribute = MainAttribute.HT.Id},
                new Skill{ Id = "4", Name = "Bench pressing", Description = "Only works if you are at the gym!", RelatedAttribute = MainAttribute.STR.Id},
                new Skill{ Id = "5", Name = "Riddles", Description = "Riddle me this batman", RelatedAttribute = MainAttribute.INT.Id},
                new Skill{ Id = "6", Name = "Sliding tile puzzles", Description = "They are much harder than crosswords", RelatedAttribute = MainAttribute.INT.Id},
                new Skill{ Id = "7", Name = "Staring contests", Description = "Nothing like a round of gay chicken", RelatedAttribute = MainAttribute.INT.Id},
            };
        }
    }
}