using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiImageSteps.Model;
using MauiImageSteps.Service;

namespace MauiImageSteps.ViewModels
{

    public class PikachuViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public string name;
        public string loc;
        public string details;
        public string imgUrl;

        public string Name {
            get {
                return name;
            }
            set {
                if (name != value) {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        public string Location {
            get { return loc; }
            set {
                if (loc != value) {
                    loc = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Location)));
                }
            }
        }

        public string Details {
            get { return details; }
            set {
                if (details != value) {
                    details = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Details)));
                }
            }
        }
        public string ImageUrl {
            get { return imgUrl; }
            set {
                if (imgUrl != value) {
                    imgUrl = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageUrl)));
                }
            }
        }

        public PikachuViewModel() {
        }
    }
}
