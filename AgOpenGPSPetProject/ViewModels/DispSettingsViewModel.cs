using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgOpenGPSPetProject.Abstractions;
using Avalonia.Input;
using CommunityToolkit.Mvvm.Input;

namespace AgOpenGPSPetProject.ViewModels
{
    public partial class DispSettingsViewModel : ViewModelBase
    {
        public DispSettingsViewModel()
        {
            NumberGuideLines = 50;
        }
        public int NumberGuideLines { get => GetValue<int>();set => SetValue(value); }
        [RelayCommand]
        public void NumberGuideLinesOnPointerWheelChanged(PointerWheelEventArgs e)
        {
            if (e.Delta.Y > 0)
            {
                NumberGuideLines += 3;
            }
            else
            {
                NumberGuideLines -= 3;

                if (NumberGuideLines < 1)
                {
                    NumberGuideLines = 1;
                }
            }
        }
    }
}
