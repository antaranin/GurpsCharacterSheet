using GurpsCharacterSheet.Core.DisplayModel;
using MvvmCross.Core.ViewModels;
using MvvmCross.FieldBinding;

namespace GurpsCharacterSheet.Core.ViewModels
{
    public class SkillItemViewHolder
        : MvxViewModel
    {
        private DisplaySkill _skill;

        public DisplaySkill Skill
        {
            get => _skill;
            set { SetProperty(ref _skill, value); }
        }

        public SkillItemViewHolder(DisplaySkill skill)
        {
            Skill = skill;
        }
    }
}