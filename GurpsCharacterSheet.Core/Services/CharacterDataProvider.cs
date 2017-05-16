using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GurpsCharacterSheet.Core.DisplayModel;
using GurpsCharacterSheet.Core.IServices;
using GurpsCharacterSheet.Data.Model;

namespace GurpsCharacterSheet.Core.Services
{
    public class CharacterDataProvider: ICharacterDataProvider
    {
        private readonly ICharacterProvider _characterProvider;
        private Character _currentCharacter;

        public CharacterDataProvider(ICharacterProvider characterProvider)
        {
            _characterProvider = characterProvider;
        }

        public async Task<IList<DisplaySkill>> GetCharacterSkills()
        {
            if(_currentCharacter == null)
                _currentCharacter = await _characterProvider.GetCurrentCharacter();
            return ExtractDisplaySkills(_currentCharacter.Skills);

        }

        //For now only use character skills for this, without attributes
        private IList<DisplaySkill> ExtractDisplaySkills(IList<CharacterSkill> characterSkills)
        {
            return characterSkills.Select(skill => new DisplaySkill
            {
                Level = skill.Level,
                RelativeLevel = skill.Level,
                Name = skill.Skill.Name
            }).ToList();
        }
    }
}