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

    public class FadeInBehavior : AnimationBaseBehavior
    {
        private static readonly BindableProperty FinalOpacityProperty = BindableProperty.Create<FadeInBehavior, double>(a => a.FinalOpacity, 1);

        /// <summary>
        /// Final opacity, default: 1
        /// </summary>
        public double FinalOpacity
        {
            get { return (double)GetValue(FinalOpacityProperty); }
            set { SetValue(FinalOpacityProperty, value); }
        }

        protected override void OnAttachedTo(View element)
        {
            base.OnAttachedTo(element);
        }

        protected override void OnDetachingFrom(View element)
        {
            base.OnDetachingFrom(element);
        }

        private async Task DoAnimation(View element)
        {
            if (WaitToEnd)
            {
                await element.FadeTo(FinalOpacity, (uint)Duration, EasingMethod);
            }
            else
            {
                element.FadeTo(FinalOpacity, (uint)Duration, EasingMethod);
            }
        }
    }
}
