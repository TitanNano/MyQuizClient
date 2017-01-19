﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace MYQuizClient
{
	public partial class App : Application
	{

        public NotificationManager NotificationManager;

		public App()
		{
			InitializeComponent();

            var test = new Networking("https://jsonplaceholder.typicode.com");

            test.dummyRequest();

            MainPage = new NavigationPage(new MYQuizClientPage());


		}

		protected override void OnStart()
		{
            // Handle when your app starts

            //TODO Manager load
            NotificationManager = new NotificationManager();

            try
            {

                NotificationManager.Register();
                MainPage.DisplayAlert("PushNotification Register successful!", "PushNotification should work now ^_^", "Ok");

            }
            catch (System.Exception e)
            {

                MainPage.DisplayAlert("Error", e.Message, "Cancel");
            }

		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}