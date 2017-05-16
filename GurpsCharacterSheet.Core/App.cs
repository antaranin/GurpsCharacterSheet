using GurpsCharacterSheet.Core.IServices;
using GurpsCharacterSheet.Core.Services;
using GurpsCharacterSheet.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace GurpsCharacterSheet.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.LazyConstructAndRegisterSingleton<ICharacterProvider, DummyCharacterProvider>();
            Mvx.LazyConstructAndRegisterSingleton<ICharacterDataProvider, CharacterDataProvider>();

            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
