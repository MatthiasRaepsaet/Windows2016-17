using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace OpendeurdagApp.ViewModels
{
    public class ViewModelBaseCostum : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public DataTemplate Template { get; set; }

        public ViewModelBaseCostum()
        {
            Template = GetTemplate();
        }

        private DataTemplate GetTemplate()
        {
            string s = GetType().Name;
            return (DataTemplate)App.Current.Resources[s];
        }
    }
}