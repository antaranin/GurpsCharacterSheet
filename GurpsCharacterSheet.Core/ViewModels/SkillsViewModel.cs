using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GurpsCharacterSheet.Core.DisplayModel;
using GurpsCharacterSheet.Core.IServices;
using MvvmCross.Core.ViewModels;
using MvvmCross.FieldBinding;

namespace GurpsCharacterSheet.Core.ViewModels
{
    public class SkillsViewModel : MvxViewModel
    {

        public INC<bool> Enabled = new NC<bool>();
		public INC<IList<SkillItemViewModel>> DisplaySkills = new NC<IList<SkillItemViewModel>>();

                public SkillsViewModel(ICharacterDataProvider dataProvider)
                {
                    Debug.WriteLine("Creating skills view model");
                    Enabled.Value = false;
/*                    DisplaySkills.Value = new List<SkillItemViewModel>
                    {
                        new SkillItemViewModel(
                            new DisplaySkill {Name = "Skill", Level = 3, RelativeLevel = 13})
                    };*/
                    var skillsTask = dataProvider.GetCharacterSkills();
                    skillsTask.GetAwaiter()
                        .OnCompleted(() =>
                        {
                            Debug.WriteLine("On completed data extraction");
                            DisplaySkills.Value =
                                skillsTask.Result.Select(skill => new SkillItemViewModel(skill)).ToList();
                        });
                }
    }
}