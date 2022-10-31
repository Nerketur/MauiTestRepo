using MauiImageSteps.Model;
using MauiImageSteps.Service;
using MauiImageSteps.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
        ((PikachusViewModel)BindingContext).Pikachus = await service.GetPikachusAsync();
    }
}

