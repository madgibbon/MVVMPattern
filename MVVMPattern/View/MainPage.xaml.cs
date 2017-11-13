using System;
using System.Collections.Generic;
using MVVMPattern.ViewModel;
using MVVMPattern.Model;

using Xamarin.Forms;

namespace MVVMPattern
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            Person per = MainPageViewModel.GetPerson();
            vm = new MainPageViewModel(per);
            BindingContext = vm;

            InitializeComponent();
        }
    }
}
