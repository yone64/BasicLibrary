using BasicLibrary.Pcl.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicLibrary.Pcl.Common
{
    /// <summary>
    /// INotifyPropertyChangedを実装する基底クラス
    /// </summary>
    public class NotifyObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [NotifyPropertyChangedInvocator]
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value)) return false;
            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}
