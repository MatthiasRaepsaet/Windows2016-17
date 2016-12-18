using OpendeurdagApp.Models;
using OpendeurdagApp.Views;
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
using Windows.UI.Popups;

namespace OpendeurdagApp.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {

        public ObservableCollection<Gebruiker> users { get; set; }
        private Gebruiker user; 

        public RegisterViewModel()
        {
            this.users = new ObservableCollection<Gebruiker>() {
                new Gebruiker("jens", "leirens", "jens.leirens@gmail.com","123", "bok", "23a", "dend", "9400", "0472", "4071", "Aalst", "TI"),
                 new Gebruiker("jorit", "vergalle", "jorit@gmail.com","1234", "bok", "23a", "dend", "9400", "0472", "4071", "Aalst", "TI")
            }; // todo insert user data here
            users.ElementAt(0).IsAdmin = true; 

        }

        public void GotoRegisterPage() =>
           NavigationService.Navigate(typeof(Views.Registreer), 0);

        public async void GoToAcountPage(string mail, string pass)
        {
            foreach(Gebruiker g in users)
            {
                if (g.Email.Equals(mail) && g.Paswoord.Equals(pass))
                {
                    user = g;
                }
            }

            if(user != null)
            {
                Shell.SetAdminAnabled(user.IsAdmin); 
                NavigationService.Navigate(typeof(Views.Acount), user); // now go to account page and show user shit

            } else
            {
                //tell user not found 404
                MessageDialog md = new MessageDialog($"de gebruiker met email:{mail} werd niet gevonden controleer passwoord en email en probeer opnieuw ", "404");
                await md.ShowAsync();
            }
           
           
        }

        public void RegisterAndLogIn(Gebruiker user)
        {
            // add user to DB 
            users.Add(user);
            //log user in and go to account page
            GoToAcountPage(user.Email, user.Paswoord); 

        }

    }

}
