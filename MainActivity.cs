using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace HelloAndroid
{
	[Activity (Label = "HelloAndroid", MainLauncher = true)]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += (sender, e) =>  ((Button)sender).Text = string.Format ("{0} clicks!", count++);
						
			var httpReq = (HttpWebRequest)HttpWebRequest.Create (new Uri ("dupa"));

		}
	}
}


