using System;
using Android.App;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DecisionatorForms;
using DecisionatorForms.Droid;
using Object = Java.Lang.Object;
using View = Android.Views.View;
using DecisionatorForms.CustomControls;

[assembly: ExportRenderer(typeof(FacebookLoginButton), typeof(FacebookLoginButtonRendererAndroid))]
namespace DecisionatorForms.Droid
{

    public class FacebookLoginButtonRendererAndroid : ButtonRenderer
    {
        private static Activity _activity;

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            _activity = this.Context as Activity;

            if (this.Control != null)
            {
                Android.Widget.Button button = this.Control;
                button.SetOnClickListener(ButtonClickListener.Instance.Value);
            }
        }

        private class ButtonClickListener : Object, IOnClickListener
        {
            public static readonly Lazy<ButtonClickListener> Instance = new Lazy<ButtonClickListener>(() => new ButtonClickListener());

            public void OnClick(View v)
            {
                var myIntent = new Intent(_activity, typeof(FacebookActivity));
                _activity.StartActivityForResult(myIntent, 0);
            }
        }
    }
}