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
    public class NieuwsViewModel : ViewModelBase
    {
        public ObservableCollection<News> News { get; set; }

        public NieuwsViewModel()
        {
            this.News = new ObservableCollection<News>(DummyDataSource.News);
        }
    }

  
}