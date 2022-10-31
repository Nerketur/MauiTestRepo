using Lombok.NET;

namespace MauiImageSteps.ViewModels {

    [NotifyPropertyChanged]
    public partial class PikachuViewModel {

        [Property(PropertyChangeType.PropertyChanged)]
        public string name;
        [Property(PropertyChangeType.PropertyChanged)]
        public string loc;
        [Property(PropertyChangeType.PropertyChanged)]
        public string details;
        [Property(PropertyChangeType.PropertyChanged)]
        public string imgUrl;

        public PikachuViewModel() {
        }
    }
}
