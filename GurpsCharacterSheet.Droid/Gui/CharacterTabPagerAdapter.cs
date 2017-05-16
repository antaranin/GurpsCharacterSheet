using System;
using System.Collections.Generic;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;
using GurpsCharacterSheet.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace GurpsCharacterSheet.Droid.Views
{
    public class CharacterTabPagerAdapter
        : MvxCachingFragmentStatePagerAdapter
    {
        public CharacterTabPagerAdapter(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public CharacterTabPagerAdapter(Context context, FragmentManager fragmentManager,
            IEnumerable<FragmentInfo> fragments)
            : base(context, fragmentManager, fragments)
        {

        }
    }
}