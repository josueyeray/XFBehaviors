namespace XFBehaviors.Behaviors
{
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Base;

    public class FadeBehavior : AnimationBaseBehavior
    {
        public static BindableProperty FinalOpacityProperty = BindableProperty.Create("FinalOpacity", typeof(double), typeof(FadeBehavior), 1.0);

        /// <summary>
        /// Final opacity, default: 1
        /// </summary>
        public double FinalOpacity
        {
            get { return (double)GetValue(FinalOpacityProperty); }
            set { SetValue(FinalOpacityProperty, value); }
        }

        protected override async Task DoAnimation(View element)
        {
            await element.FadeTo(FinalOpacity, (uint)Duration, GetEasingMethodFromEnumerator());
        }
    }
}
