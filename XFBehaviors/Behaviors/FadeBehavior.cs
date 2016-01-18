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

    public class FadeBehavior : AnimationBaseBehavior
    {
        public static BindableProperty FinalOpacityProperty = BindableProperty.Create<FadeBehavior, double>(a => a.FinalOpacity, 1);

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
