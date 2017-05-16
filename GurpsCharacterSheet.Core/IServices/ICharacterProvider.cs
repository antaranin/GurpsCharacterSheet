using System.Threading.Tasks;
using GurpsCharacterSheet.Data.Model;

namespace GurpsCharacterSheet.Core.IServices
{
    public interface ICharacterProvider
    {
        Task<Character> GetCurrentCharacter();

        Task<Character> GetCharacterWithId(string characterId);
    }
}