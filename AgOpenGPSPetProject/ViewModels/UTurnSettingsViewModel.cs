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
    public partial class UTurnSettingsViewModel : ViewModelBase
    {
        public UTurnSettingsViewModel()
        {
            ExtensionLength = 20;
            Smoothing = 14;
            UTurnRadius = 8.10m;
            UTurnDistance = 2.00m;
        }
        public decimal UTurnRadius { get => GetValue<decimal>(); set => SetValue(value); }
        public decimal UTurnDistance { get => GetValue<decimal>(); set => SetValue(value); }
        public int ExtensionLength { get => GetValue<int>(); set => SetValue(value); }
        public int Smoothing { get => GetValue<int>(); set => SetValue(value); }

        [RelayCommand]
        public void OnUTurnRadiusWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                IncreaseUTurnRadius();
            }
            else
            {
                DecreaseUTurnRadius();
            }
        }
        [RelayCommand]
        public void OnUTurnDistanceWheelChanged(PointerWheelEventArgs e)
        {
            if (e.Delta.Y > 0)
            {
                IncreaseUTurnDistance();
            }
            else
            {
                DecreaseUTurnDistance();
            }
        }
        [RelayCommand]
        public void IncreaseExtensionsLength()
        {
            ExtensionLength++;
        }
        [RelayCommand]
        public void DecreaseExtensionsLength()
        {
            if(ExtensionLength > 3)
            {
                ExtensionLength--;
            }
        }
        [RelayCommand]
        public void IncreaseSmooth()
        {
            Smoothing += 2;
        }
        [RelayCommand]
        public void DecreaseSmooth()
        {
            if(Smoothing > 8)
            {
                Smoothing -= 2;
            }
        }
        private void IncreaseUTurnRadius()
        {
            UTurnRadius += 0.60m;
        }
        private void DecreaseUTurnRadius()
        {
            UTurnRadius -= 0.60m;
            if (UTurnRadius < 2)
            {
                UTurnRadius = 2.00m;
            }
        }
        private void IncreaseUTurnDistance()
        {
            UTurnDistance += 0.60m;
        }
        private void DecreaseUTurnDistance()
        {
            UTurnDistance -= 0.60m;
            if (UTurnDistance < 0)
            {
                UTurnDistance = 0.00m;
            }
        }
    }
}
