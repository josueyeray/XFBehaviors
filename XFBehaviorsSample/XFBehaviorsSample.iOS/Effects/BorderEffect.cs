namespace XFBehaviorsSample.iOS.Effects
{
    using Xamarin.Forms.Platform.iOS;

    public class BorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.Layer.BorderColor = new CoreGraphics.CGColor(1, 0, 0);
            Control.Layer.BorderWidth = 2;
        }

        protected override void OnDetached()
        {
        }
    }
}
