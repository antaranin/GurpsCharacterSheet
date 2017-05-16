using System.Diagnostics;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace GurpsCharacterSheet.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public SkillsViewModel SkillsViewModel { get; set; }
        public FirstViewModel()
        {
            Debug.WriteLine("Making First view model");
        }
    }
}
