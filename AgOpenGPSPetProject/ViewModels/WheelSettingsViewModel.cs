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
    public partial class WheelSettingsViewModel : ViewModelBase
    {
        public WheelSettingsViewModel()
        {
            Track = 190;
            WheelBase = 330;
        }
        public int Track { get => GetValue<int>(); set => SetValue(value); }
        public int WheelBase { get => GetValue<int>();set => SetValue(value); }

        [RelayCommand]
        public void OnWheelBasePointerWheelChanged(PointerWheelEventArgs e)
        {
            if (e.Delta.Y > 0)
            {
                WheelBase += 3;
            }
            else
            {
                WheelBase -= 3;
                if (WheelBase < 0)
                {
                    WheelBase = 0;
                }
            }
        }
        [RelayCommand]
        public void OnTrackPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                Track += 3;
            }
            else
            {
                Track -= 3;
                if (Track < 0)
                {
                    Track = 0;
                }
            }
        }

    }
}
