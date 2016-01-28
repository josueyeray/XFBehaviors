namespace XFBehaviors.Behaviors
{
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Base;
    using Enums;

    public class ScaleBehavior : AnimationBaseBehavior
    {
        public static BindableProperty FinalScaleProperty = BindableProperty.Create("FinalScale", typeof(double), typeof(ScaleBehavior), 1.0);
        public static BindableProperty IsRelativeProperty = BindableProperty.Create("IsRelative", typeof(bool), typeof(ScaleBehavior), false);

        /// <summary>
        /// Final scale, default: 1
        /// </summary>
        public double FinalScale
        {
            get { return (double)GetValue(FinalScaleProperty); }
            set { SetValue(FinalScaleProperty, value); }
        }

        /// <summary>
        /// Use relative or absolute scaling, default absolute
        /// </summary>
        public bool IsRelative
        {
            get { return (bool)GetValue(IsRelativeProperty); }
            set { SetValue(IsRelativeProperty, value); }
        }

        protected override async Task DoAnimation(View element)
        {
            if (IsRelative)
            {
                await element.RelScaleTo(FinalScale, (uint)Duration, GetEasingMethodFromEnumerator());
            }
            else
            {
                await element.ScaleTo(FinalScale, (uint)Duration, GetEasingMethodFromEnumerator());
            }
        }
    }
}
