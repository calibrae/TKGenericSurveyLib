using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TKGenericSurveyLib.Annotations;
using Xamarin.Forms;

namespace TKGenericSurveyLib.view
{
    public class GenericSurveyMediator : INotifyPropertyChanged
    {
        private View _children;

        public View Children
        {
            get { return _children; }
            set
            {
                if (_children == value) return;
                _children = value;
                OnPropertyChanged(nameof(Children));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}