using System.Collections.Generic;
using System.Diagnostics;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using GurpsCharacterSheet.Core.DisplayModel;
using GurpsCharacterSheet.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Support.V7.RecyclerView.ItemTemplates;

namespace GurpsCharacterSheet.Droid.Gui
{
	public sealed class SkillsAdapter : MvxRecyclerAdapter
	{
		public SkillsAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
		{
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			Debug.WriteLine("On create view holder");
			Debug.WriteLine("View type => " + viewType);
			Debug.WriteLine("Item template selector => " + ItemTemplateId);
			Debug.Write("Selector layout id => " + ItemTemplateSelector.GetItemLayoutId(viewType));
			base.OnCreateViewHolder(parent, viewType);
			var itemBindingContext = new MvxAndroidBindingContext(parent.Context, BindingContext.LayoutInflaterHolder);
			var view = InflateViewForHolder(parent, viewType, itemBindingContext);
			return new SkillViewHolder(view, itemBindingContext);
		}

		internal class SkillViewHolder : MvxRecyclerViewHolder
		{
			internal TextView SkillNameTv { get; set; }
			internal TextView SkillLevelTv { get; set; }
			internal TextView SkillRelativeLevelTv { get; set; }
			internal SkillViewHolder(View itemView, IMvxAndroidBindingContext context) : base(itemView, context)
			{
				SkillNameTv = itemView.FindViewById<TextView>(Resource.Id.skill_name_tv);
				SkillLevelTv = itemView.FindViewById<TextView>(Resource.Id.skill_level_tv);
				SkillRelativeLevelTv = itemView.FindViewById<TextView>(Resource.Id.skill_relative_level_tv);

                this.DelayBind(() =>
                {
                    var set = this.CreateBindingSet<SkillViewHolder, SkillItemViewModel>();
                    set.Bind(SkillNameTv).For(v => v.Text).To(vm => vm.Skill.Name);
                    set.Bind(SkillLevelTv).For(v => v.Text).To(vm => vm.Skill.Level);
                    set.Bind(SkillRelativeLevelTv)
                        .For(v => v.Text)
                        .To(vm => vm.Skill.RelativeLevel);
                    set.Apply();
                });
			}
		}
	}
}