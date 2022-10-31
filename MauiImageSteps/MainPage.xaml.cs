using MauiImageSteps.Model;
using MauiImageSteps.Service;
using MauiImageSteps.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiImageSteps;

public partial class MainPage : ContentPage
{
    private PikachuService service;
    private PikachusViewModel viewModel;

    public MainPage(PikachuService pika, PikachusViewModel pvm) {
        this.service = pika;
        BindingContext = pvm;
        viewModel = pvm;
        InitializeComponent();
    }
    protected async override void OnAppearing() {
        base.OnAppearing();
        viewModel.Pikachus = await service.GetPikachusAsync();

        //vm.LoadData(); 
    }
}

