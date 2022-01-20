using MovieTrailer.ViewModels.LogIn;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieTrailer.Views.LogIn
{
    public partial class PasswordRecovery : ContentPage
    {
        #region  declaration
        public PasswordRecoveryViewModel vm { get; set; }
        #endregion

        public PasswordRecovery()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            base.BindingContext = vm = new PasswordRecoveryViewModel(Navigation);
        }
    }
}
