﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MYQuizClient
{
    public partial class LoginView : ContentPage
    {

        private App App { get { return (MYQuizClient.App)Application.Current; } }

        public LoginView()
        {
            InitializeComponent();
        }

        //Event called by TextChanged from en_pincode.
        public void entry_Completed(object sender, EventArgs e)
        {
            App.navigateTo(App.frageSeite);
        }
    }
}
