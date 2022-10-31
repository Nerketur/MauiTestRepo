using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MauiImageSteps.Model;
using MauiImageSteps.Service;

namespace MauiImageSteps.ViewModels {

    public class PikachusViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Pikachu> pikachuList;

        public ObservableCollection<Pikachu> Pikachus {
            get {
                return pikachuList;
            }
            set { 
                if (pikachuList != value) {
                    pikachuList = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Pikachus)));
                }
            }
        }

        public PikachusViewModel() {
        }
    }
}
