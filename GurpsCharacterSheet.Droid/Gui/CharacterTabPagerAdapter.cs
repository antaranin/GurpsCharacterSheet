using System;
using Android.Runtime;
using Android.Support.V4.App;
using MvvmCross.Droid.Support.V4;

namespace GurpsCharacterSheet.Droid.Views
{
    public class CharacterTabPagerAdapter
        : MvxCachingFragmentPagerAdapter
    {
        public CharacterTabPagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public CharacterTabPagerAdapter(FragmentManager fragmentManager) : base(fragmentManager)
        {
        }

        public override int Count => 1;

        public override Fragment GetItem(int position, Fragment.SavedState fragmentSavedState = null)
        {
            return new SkillsView();
        }
    }
}