using GurpsCharacterSheet.Core.DisplayModel;
using MvvmCross.Core.ViewModels;

namespace GurpsCharacterSheet.Core.ViewModels
{
    public class SkillItemViewModel
        : MvxViewModel
    {
        private DisplaySkill _skill;

        public DisplaySkill Skill
        {
            get => _skill;
            set { SetProperty(ref _skill, value); }
        }

        public SkillItemViewModel(DisplaySkill skill)
        {
            Skill = skill;
        }
    }
}