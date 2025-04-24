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
    public partial class ToolHitchPivotOffsetSettingsViewModel : ViewModelBase
    {
        public int Offset { get => GetValue<int>(); set => SetValue(value); }
        [RelayCommand]
        public void OnOffsetPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                IncreaseOffset();
            }
            else
            {
                DecreaseOffset();
            }
        }
        private void IncreaseOffset()
        {
            Offset += 3;
        }
        private void DecreaseOffset() 
        {
            if(Offset > 3)
            {
                Offset -= 3;
            }
        }

    }
}
