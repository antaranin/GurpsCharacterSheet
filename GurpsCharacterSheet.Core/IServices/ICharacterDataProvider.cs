using System.Collections.Generic;
using System.Threading.Tasks;
using GurpsCharacterSheet.Core.DisplayModel;

namespace GurpsCharacterSheet.Core.IServices
{
    public interface ICharacterDataProvider
    {
        Task<IList<DisplaySkill>> GetCharacterSkills();
    }
}