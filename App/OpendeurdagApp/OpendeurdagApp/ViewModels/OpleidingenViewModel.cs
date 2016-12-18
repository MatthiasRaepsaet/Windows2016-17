using OpendeurdagApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace OpendeurdagApp.ViewModels
{
    public class OpleidingenViewModel : ViewModelBase
    {
        public ObservableCollection<Opleiding> OpleidingenAalst { get; set; }
        public ObservableCollection<Opleiding> OpleidingenGent { get; set; }


        public OpleidingenViewModel()
        {
            this.OpleidingenAalst = new ObservableCollection<Opleiding>(DummyDataSource.Opleidingen.FindAll(s => s.Stad.Equals("Aalst")));
            this.OpleidingenGent = new ObservableCollection<Opleiding>(DummyDataSource.Opleidingen.FindAll(s => s.Stad.Equals("Gent")));
        }
    }


}