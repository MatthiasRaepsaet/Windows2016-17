using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public class Opleiding : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string opleidingName;

        public string OpleidingName
        {
            get { return opleidingName; }
            set { opleidingName = value; RaisePropertyChanged(); }
        }


        private String opleidingDescription;

        public String OpleidingDescription
        {
            get { return opleidingDescription; }
            set { opleidingDescription = value; }
        }

        private String opleidingImage;

        public String OpleidingImage
        {
            get { return opleidingImage; }
            set { opleidingImage = value; RaisePropertyChanged(); }
        }

        private String stad;

        public String Stad
        {
            get { return stad; }
            set { stad = value; RaisePropertyChanged(); }
        }

    }
}
