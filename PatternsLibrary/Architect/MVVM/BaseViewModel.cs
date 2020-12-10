using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PatternsLibrary.Architect.MVVM
{
    /// <summary>
    /// add <see cref="RaiseOnPropertyChanged()"/> for observe 
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
