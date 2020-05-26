using PropertyChanged;
using System.ComponentModel;

namespace WritingApp
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that gets fired when any child propert changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        /// <summary>
        /// Call this to fire a property changed event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
