using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public class News : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(); }
        }

        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; RaisePropertyChanged(); }
        }
    }
}
