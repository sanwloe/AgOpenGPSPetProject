using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgOpenGPSPetProject.Abstractions;
using AgOpenGPSPetProject.Helpers;
using AgOpenGPSPetProject.Models;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.Input;

namespace AgOpenGPSPetProject.ViewModels
{
    public partial class VehicleTypeViewModel : ViewModelBase
    {
        public VehicleTypeViewModel()
        {
            VehicleOpacity = 1;
            VehicleCompanies = [];
            CheckedVehicleType = VehicleType.Harvester;
        }
        public VehicleType CheckedVehicleType 
        { 
            get => GetValue<VehicleType>();
            set
            {
                if (SetValue(value))
                {
                    VehicleCompanies = GetData(value);
                    SetVehiclePhotoFromAbove(value);
                }
            }
        }
        public ObservableCollection<Bitmap> VehicleCompanies { get => GetValue<ObservableCollection<Bitmap>>(); set => SetValue(value); }
        public Bitmap VehiclePhotoFromAbove { get => GetValue<Bitmap>(); set => SetValue(value); }
        public double VehicleOpacity 
        { 
            get => GetValue<double>();
            set
            {
                if(SetValue(value))
                {
                    RaisePropertyChanged(nameof(IntVehicleOpacity));
                }
            }
        }
        public bool NoImagesIsEnabled 
        {
            get => GetValue<bool>();
            set
            {
                if (SetValue(value))
                {
                    if(value)
                    {
                        VehicleCompanies.Clear();
                        VehiclePhotoFromAbove = ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/btnImages/TriangleVehicle.png");
                    }
                    else
                    {
                        var type = CheckedVehicleType;
                        CheckedVehicleType = type;
                    }
                }
            }
        }
        public int IntVehicleOpacity { get => Convert.ToInt32(Math.Round(VehicleOpacity * 100,0)); }
        [RelayCommand]
        public void HarvesterWasChecked()
        {
            CheckedVehicleType = VehicleType.Harvester;
        }
        [RelayCommand]
        public void TractorWasChecked()
        {
            CheckedVehicleType = VehicleType.Tractor;
        }
        [RelayCommand]
        public void ArticulatorWasChecked()
        {
            CheckedVehicleType = VehicleType.Articulator;
        }
        [RelayCommand]
        public void UpVehicleOpacity()
        {
            if(VehicleOpacity < 1.0)
            {
                VehicleOpacity += 0.2;
            }
        }
        [RelayCommand]
        public void DownVehicleOpacity()
        {
            if(VehicleOpacity >= 0.4)
            {
                VehicleOpacity -= 0.2;
            }
        }
        [RelayCommand]
        public void HandleNoImageTapped()
        {
            NoImagesIsEnabled = !NoImagesIsEnabled;
        }
        private ObservableCollection<Bitmap> GetData(VehicleType vehicleType)
        {
            if (vehicleType == VehicleType.Harvester)
            {
                return [ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/AoG.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Case.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Claas.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/JohnDeere.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/NewHolland.png")
                ];
            }
            else if(vehicleType == VehicleType.Tractor)
            {
                return [
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/JCB.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Case.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Massey.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Ursus.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Fendt.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/AoG.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Claas.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/NewHolland.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Valtra.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Steyr.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Deutz.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Same.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/JohnDeere.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Kubota.png")
                    ];
            }
            else if( vehicleType == VehicleType.Articulator)
            {
                return [
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/AoG.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Challenger.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Case.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/JohnDeere.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/NewHolland.png"),
                    ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Brands/Holder.png")
                    ];
            }
            return [];
        }
        private void SetVehiclePhotoFromAbove(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Articulator:
                    VehiclePhotoFromAbove = ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Vehicle/z_ArticulatedFront.png");
                    break;
                case VehicleType.Harvester:
                    VehiclePhotoFromAbove = ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Vehicle/z_Harvester.png");
                    break;
                case VehicleType.Tractor:
                    VehiclePhotoFromAbove = ImageHelper.LoadFromResource("avares://AgOpenGPSPetProject/Assets/Vehicle/z_Tractor.png");
                    break;
                default:
                    break;
            }
        }
    }
}
