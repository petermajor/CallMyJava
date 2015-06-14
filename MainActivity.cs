using Android.App;
using Android.Widget;
using Android.OS;

namespace CallMyJava
{
	[Activity (Label = "CallMyJava", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			var counter = new ClickCounter ();

			button.Click += delegate {

				var count = counter.Clicked();
				button.Text = string.Format ("{0} clicks!", count);
			};
		}
	}
}


/*
using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace JNIDemo
{
	[Activity(Label = "JNI Test", MainLauncher = true)]
	public class Activity1 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.MyButton);
			
			button.Click += delegate {
				StartActivity (new Intent (this, Java.Lang.Class.ForName ("mono.samples.jnitest.MyActivity")));
			};
		}
	}
}
 */