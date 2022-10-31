using System.Collections.ObjectModel;
using Lombok.NET;
using MauiImageSteps.Model;

namespace MauiImageSteps.ViewModels {

    [NotifyPropertyChanged]
    public partial class PikachusViewModel {

        [Property(PropertyChangeType.PropertyChanged)]
        private ObservableCollection<Pikachu> pikachuList;

        public PikachusViewModel() {
        }
    }
}
