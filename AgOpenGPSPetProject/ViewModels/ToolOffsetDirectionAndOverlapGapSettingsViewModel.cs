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
    public partial class ToolOffsetDirectionAndOverlapGapSettingsViewModel : ViewModelBase
    {
        public int ToolOffsetDirection { get => GetValue<int>();set => SetValue(value); }
        public int OverlapOrGap { get => GetValue<int>();set => SetValue(value);}

        [RelayCommand]
        public void OnToolOffsetDirectionPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                ToolOffsetDirection += 3;
            }
            else
            {
                ToolOffsetDirection -=3;
                if(ToolOffsetDirection < 0)
                {
                    ToolOffsetDirection = 0;
                }
            }
        }
        [RelayCommand]
        public void OnOverlapOrGapPointerWheelChanged(PointerWheelEventArgs e)
        {
            if(e.Delta.Y > 0)
            {
                OverlapOrGap += 3;
            }
            else
            {
                OverlapOrGap -= 3;
                if(OverlapOrGap < 0)
                {
                    OverlapOrGap = 0;
                }
            }
        }

    }
}
