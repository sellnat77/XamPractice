using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Facebook;

[assembly: MetaData("com.facebook.sdk.ApplicationId", Value = "@string/app_id")]
namespace DecisionatorForms.Droid
{
    [Activity(Label = "FacebookActivity")]
    public class FacebookActivity : Activity, Session.IStatusCallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            // Open a FB Session and show login if necessary
            Session.OpenActiveSession(this, true, this);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Relay the result to our FB Session
            Session.ActiveSession.OnActivityResult(this, requestCode, (int)resultCode, data);
        }

        public void Call(Session session, SessionState state, Exception exception)
        {
            // Make a request for 'Me' information about the current user
            if (session.IsOpened)
            {
                Intent mainIntent = new Intent(this, typeof(MainActivity));
                mainIntent.PutExtra("facebookToken", session.AccessToken);
                SetResult(Result.FirstUser, mainIntent);
                Finish();
            }

        }
    }
}