﻿using OpendeurdagApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace OpendeurdagApp.ViewModels
{
    public class NieuwsViewModel : ViewModelBase
    {
        public ObservableCollection<News> News { get; set; }
        public ObservableCollection<News> NewsAalst { get; set; }
        public ObservableCollection<News> NewsGent { get; set; }


        public NieuwsViewModel()
        {
            this.News = new ObservableCollection<News>(BackendDataSource.News);
            this.NewsAalst = new ObservableCollection<News>(BackendDataSource.News.FindAll(s => s.Stad.Equals("Aalst")));
            this.NewsGent = new ObservableCollection<News>(BackendDataSource.News.FindAll(s => s.Stad.Equals("Gent")));
            Debug.WriteLine("done");
        }
    }


}