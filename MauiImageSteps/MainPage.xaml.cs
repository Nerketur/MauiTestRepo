using MauiImageSteps.Service;
using MauiImageSteps.ViewModels;

namespace MauiImageSteps;

public partial class MainPage : ContentPage
{
    private readonly PikachuService service;

    public MainPage(PikachuService pika) {
        InitializeComponent();
        service = pika;
    }
    protected async override void OnAppearing() {
        base.OnAppearing();
        ((PikachusViewModel)BindingContext).PikachuList = await service.GetPikachusAsync();
    }
}

