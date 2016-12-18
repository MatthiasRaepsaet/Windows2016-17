using OpendeurdagApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace OpendeurdagApp.ViewModels
{
    public class RegisterViewModel : ViewModelBase , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Gebruiker> users { get; set; }
        private Gebruiker user; 
        public RegisterViewModel()
        {
            this.users = new ObservableCollection<Gebruiker>(); // todo insert user data here
        }

        public void GotoRegisterPage() =>
           NavigationService.Navigate(typeof(Views.Registreer), 0);

        public void GotAcountPage(string mail, string pass)
        {
            Debug.WriteLine(mail);
            Debug.WriteLine(pass);

            NavigationService.Navigate(typeof(Views.Acount), user);
        }

        public void GotAcountPage() =>
           checkuser();

        public void checkuser()
        {
            
        }

    }

}
