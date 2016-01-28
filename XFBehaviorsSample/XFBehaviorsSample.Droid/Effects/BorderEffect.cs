namespace XFBehaviorsSample.Droid.Effects
{
    using Android.Graphics.Drawables;
    using System;
    using Xamarin.Forms.Platform.Android;

    public class BorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.SetBackgroundResource(Droid.Resource.Drawable.RedBorder);
        }

        protected override void OnDetached()
        {
        }
    }
}