namespace XFBehaviorsSample.WinPhone.Effects
{
    using System.Windows.Media;
    using Xamarin.Forms.Platform.WinPhone;

    public class BorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var element = (Control as System.Windows.Controls.Control);
            if (element != null)
            {
                element.BorderBrush = new SolidColorBrush(Colors.Red);
                element.BorderThickness = new System.Windows.Thickness(2);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}
