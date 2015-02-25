namespace XFBehaviors.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using XFBehaviors.Enums;

    public class AnimationBaseBehavior : Behavior<View>
    {
        private static readonly BindableProperty DurationProperty = BindableProperty.Create<AnimationBaseBehavior, int>(a => a.Duration, 250);
        private static readonly BindableProperty OnEventProperty = BindableProperty.Create<AnimationBaseBehavior, EventTypeEnumerator>(a => a.OnEvent, EventTypeEnumerator.Attached);
        private static readonly BindableProperty WaitToEndProperty = BindableProperty.Create<AnimationBaseBehavior, bool>(a => a.WaitToEnd, false);
        private static readonly BindableProperty EasingMethodProperty = BindableProperty.Create<AnimationBaseBehavior, Easing>(a => a.EasingMethod, Easing.Linear);

        /// <summary>
        /// Animation duration in milliseconds, default: 250ms
        /// </summary>
        public int Duration
        {
            get { return (int)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }

        /// <summary>
        /// Launching event, default: Attached
        /// </summary>
        public EventTypeEnumerator OnEvent
        {
            get { return (EventTypeEnumerator)GetValue(OnEventProperty); }
            set { SetValue(OnEventProperty, value); }
        }

        /// <summary>
        /// Wait until animation ends, default: false
        /// </summary>
        public bool WaitToEnd
        {
            get { return (bool)GetValue(WaitToEndProperty); }
            set { SetValue(WaitToEndProperty, value); }
        }

        /// <summary>
        /// Easing function to apply to animation, default: Linear
        /// </summary>
        public Easing EasingMethod
        {
            get { return (Easing)GetValue(EasingMethodProperty); }
            set { SetValue(EasingMethodProperty, value); }
        }
    }
}
