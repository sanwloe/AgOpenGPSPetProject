using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPSPetProject.Abstractions
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private Dictionary<string, object> _properties = [];
        public bool SetValue(object value,[CallerMemberName] string propertyName = null)
        {
            _properties[propertyName] = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
        public T GetValue<T>([CallerMemberName] string propertyName = null)
        {
            if (_properties.TryGetValue(propertyName, out var value))
            {
                return (T)value;
            }
            else
            {
                return (T)default!;
            }
        }
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
