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
    public partial class TramSettingsViewModel : ViewModelBase
    {
        public TramSettingsViewModel()
        {
            TramWidth = 2400;
        }
        public int TramWidth { get => GetValue<int>();set => SetValue(value); }

        [RelayCommand]
        public void OnTramWidthPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                IncreateTramWidth();
            }
            else
            {
                DecreaseTramWidth();
            }
        }
        private void IncreateTramWidth()
        {
            TramWidth += 3;
        }
        private void DecreaseTramWidth()
        {
            if(TramWidth > 3)
                TramWidth -= 3;
        }
    }
}
