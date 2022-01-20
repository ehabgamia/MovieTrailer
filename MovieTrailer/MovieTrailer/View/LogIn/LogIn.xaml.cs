using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Toast;
using Plugin.Toast.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MovieTrailer.PCL.Common;
using MovieTrailer.ViewModels.LogIn;

namespace MovieTrailer.Views.LogIn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        #region  declaration
        SharedPreference _objShared = new SharedPreference();
        public LogInViewModel vm { get; set; }

        #endregion


        public LogIn()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            base.BindingContext = vm = new LogInViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

   
    }
}
