using AgOpenGPSPetProject.Abstractions;
using CommunityToolkit.Mvvm.Input;

namespace AgOpenGPSPetProject.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable
        public MainWindowViewModel()
        {
            Frame = _configurationMenuView = new();
        }

        public object Frame { get => GetValue<object>(); set => SetValue(value); }

        private ConfigurationMenu _configurationMenuView;
        [RelayCommand]
        public void OpenConfigurationMenuView()
        {
            if(Frame == _configurationMenuView)
            {
                OpenVehicleTypeView();
            }
            else
            {
                Frame = _configurationMenuView;
            }   
        }
        private VehicleTypeView _vehicleTypeView;
        [RelayCommand]
        public void OpenVehicleTypeView()
        {
            Frame = _vehicleTypeView ??= new();
        }
        private AttachmentStyleView _attachmentStyleView;
        [RelayCommand]
        public void OpenAttachmentStyleView()
        {
            Frame = _attachmentStyleView ??= new();
        }
        private WheelSettingsView _wheelSettingsView;
        [RelayCommand]
        public void OpenWheelbaseSettingsView()
        {
            Frame = _wheelSettingsView ??= new();
        }
        private PivotDistanceAndAntennaSettingsView _pivotDistanceAndAntennaSettingsView;
        [RelayCommand]
        public void OpenPivotDistanceAndAntennaSettingsView()
        {
            Frame = _pivotDistanceAndAntennaSettingsView ??= new();
        }
        private WheelUnitsCmView _wheelUnitsCmView;
        [RelayCommand]
        public void OpenWheelUnitsCmView()
        {
            Frame = _wheelUnitsCmView ??= new();
        }
        private ToolHitchPivotOffsetSettingsView _toolHitchPivotOffsetSettingsView;
        [RelayCommand]
        public void OpenToolHitchPivotOffsetSettingsView()
        {
            Frame = _toolHitchPivotOffsetSettingsView ??= new();
        }
        private ToolOffsetDirectionAndOverlapGapSettingsView _toolOffsetDirectionAndOverlapGapSettingsView;
        [RelayCommand]
        public void OpenToolOffsetDirectionAndOverlapGapSettingsView()
        {
            Frame = _toolOffsetDirectionAndOverlapGapSettingsView ??= new();
        }
        private WorkAndSteerSwitchView _workAndSteerSwitchView;
        [RelayCommand]
        public void OpenWorkAndSteerSwitchView()
        {
            Frame = _workAndSteerSwitchView ??= new();
        }
        private TramSettingsView _tramSettingsView;
        [RelayCommand]
        public void OpenTramSettingsView() 
        {
            Frame= _tramSettingsView ??= new();
        }
        private RollSettingsView _rollSettingsView;
        [RelayCommand]
        public void OpenRollSettingsView() 
        {
            Frame = _rollSettingsView ??= new();
        }
        private UTurnSettingsView _turnSettingsView;
        [RelayCommand]
        public void OpenUTurnSettingsView()
        {
            Frame = _turnSettingsView ??= new();
        }
        private DispSettingsView _dispSettingsView;
        [RelayCommand]
        public void OpenDispSettingsView() 
        {
            Frame = _dispSettingsView ??= new();
        }
        private ButtonsSettingView _buttonsSettingView;
        [RelayCommand]
        public void OpenButtonsSettingView() 
        {
            Frame = _buttonsSettingView ??= new();
        }
    }
}
