﻿using AutomobileTn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AutomobileTn
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application

			var tabbedPage = new TabbedPage
			{
			
			};

            //tabbedPage.Children.Add(new Page1());
            tabbedPage.Children.Add(new MainView());
            tabbedPage.Children.Add(new TweetsView());
            tabbedPage.Children.Add(new VideosView());

            var np = new NavigationPage(tabbedPage);

            MainPage = np;

			//MainPage = new MainView();

			//MainPage = new ContentPage
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			new Label {
			//				XAlign = TextAlignment.Center,
			//				Text = "Welcome to Xamarin Forms!"
			//			}
			//		}
			//	}
			//};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
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
