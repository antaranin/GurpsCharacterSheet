﻿﻿using Android.Graphics;
using Android.OS;
using Android.Views;
using GurpsCharacterSheet.Core.ViewModels;
using GurpsCharacterSheet.Droid.Gui;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.RecyclerView;
using Debug = System.Diagnostics.Debug;

namespace GurpsCharacterSheet.Droid.Views
{
	public class SkillsView : MvxFragment<SkillsViewModel>
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView(inflater, container, savedInstanceState);
			// Use this to return your custom view for this Fragment

			//return inflater.Inflate(Resource.Layout.SkillsView, container, false);
			return this.BindingInflate(Resource.Layout.SkillsView, container, false);
		}

		public override void OnViewModelSet()
		{
			base.OnViewModelSet();
			Debug.WriteLine("On view model set, model is not null => " + (ViewModel != null));
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			base.OnViewCreated(view, savedInstanceState);
			Debug.WriteLine("On view created, model is not null => " + (ViewModel != null));
			CreateBindings(View);
		}

		private void CreateBindings(View rootView)
		{
			var recyclerView = rootView.FindViewById<MvxRecyclerView>(Resource.Id.skills_rv);
			recyclerView.ItemTemplateId = Resource.Layout.SkillItem;
			var adapter = new SkillsAdapter((IMvxAndroidBindingContext) this.BindingContext);
			recyclerView.Adapter = adapter;

            var set = this.CreateBindingSet<SkillsView, SkillsViewModel>();
            set.Bind(adapter).For(a => a.ItemsSource).To(vm => vm.DisplaySkills);
			//set.Bind(recyclerView).For(r => r.Enabled).To(vm => vm.Enabled);
			set.Apply();

		}
	}
}
