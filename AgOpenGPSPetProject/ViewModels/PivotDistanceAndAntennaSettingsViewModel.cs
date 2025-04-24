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
    public partial class PivotDistanceAndAntennaSettingsViewModel : ViewModelBase
    {
        public PivotDistanceAndAntennaSettingsViewModel()
        {
            PivotDistance = 10;
            AntennaHeight = 330;
            AntennaOffset = 0;
        }
        public int PivotDistance { get => GetValue<int>();set => SetValue(value); }
        public int AntennaHeight { get =>  GetValue<int>();set => SetValue(value); }
        public int AntennaOffset { get=> GetValue<int>();set => SetValue(value); }

        [RelayCommand]
        public void OnPivotDistancePointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                PivotDistance += 3;
            }
            else
            {
                PivotDistance -= 3;
            }
        }
        [RelayCommand]
        public void OnAntennaHeightPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                AntennaHeight += 3;
            }
            else
            {
                AntennaHeight -= 3;
            }
        }
        [RelayCommand]
        public void OnAntennaOffsetPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                AntennaOffset += 3;
            }
            else
            {
                AntennaOffset -= 3;
            }
        }
    }
}
