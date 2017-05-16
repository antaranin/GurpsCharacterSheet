using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V4.View;
using GurpsCharacterSheet.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views;

namespace GurpsCharacterSheet.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxCachingFragmentActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var fragments = CreateFragments();

            var viewPager = FindViewById<ViewPager>(Resource.Id.view_pager);
            var adapter = new CharacterTabPagerAdapter(this, SupportFragmentManager, fragments);
            viewPager.Adapter = adapter;
        }

        private MvxCachingFragmentStatePagerAdapter.FragmentInfo[] CreateFragments()
        {
            return new[]
            {
                new MvxCachingFragmentStatePagerAdapter.FragmentInfo("Skills", typeof(SkillsView), typeof(SkillsViewModel))
            };
        }
    }
}
