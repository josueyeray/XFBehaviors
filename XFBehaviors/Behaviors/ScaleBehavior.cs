namespace XFBehaviors.Behaviors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using XFBehaviors.Base;
    using XFBehaviors.Enums;

    public class ScaleBehavior : AnimationBaseBehavior
    {
        public static BindableProperty FinalScaleProperty = BindableProperty.Create<ScaleBehavior, double>(a => a.FinalScale, 1);
        public static BindableProperty IsRelativeProperty = BindableProperty.Create<ScaleBehavior, bool>(a => a.IsRelative, false);

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
