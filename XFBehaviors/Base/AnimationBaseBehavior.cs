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
        private static readonly BindableProperty DurationProperty = 
            BindableProperty.Create<AnimationBaseBehavior, int>(a => a.Duration, 250);
        private static readonly BindableProperty OnEventProperty = BindableProperty.Create<AnimationBaseBehavior, EventTypeEnumerator>(a => a.OnEvent, EventTypeEnumerator.Attached);
        private static readonly BindableProperty EasingMethodProperty = BindableProperty.Create<AnimationBaseBehavior, EasingMethodEnumerator>(a => a.EasingMethod, EasingMethodEnumerator.Linear);

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
        /// Easing function to apply to animation, default: Linear
        /// </summary>
        public EasingMethodEnumerator EasingMethod
        {
            get { return (EasingMethodEnumerator)GetValue(EasingMethodProperty); }
            set { SetValue(EasingMethodProperty, value); }
        }

        protected override void OnAttachedTo(View element)
        {
            base.OnAttachedTo(element);

            switch (OnEvent)
            {
                case EventTypeEnumerator.Focused:
                    element.Focused += ElementEvent;
                    break;
                case EventTypeEnumerator.Unfocused:
                    element.Unfocused += ElementEvent;
                    break;
                case EventTypeEnumerator.ChildAdded:
                    element.ChildAdded += ElementEvent;
                    break;
                case EventTypeEnumerator.ChildRemoved:
                    element.ChildRemoved += ElementEvent;
                    break;
                case EventTypeEnumerator.Attached:
                    DoAnimation(element);
                    break;
                case EventTypeEnumerator.Detaching:
                    break;
                default:
                    break;
            }
        }

        protected override void OnDetachingFrom(View element)
        {
            base.OnDetachingFrom(element);

            switch (OnEvent)
            {
                case EventTypeEnumerator.Focused:
                    element.Focused -= ElementEvent;
                    break;
                case EventTypeEnumerator.Unfocused:
                    element.Unfocused -= ElementEvent;
                    break;
                case EventTypeEnumerator.ChildAdded:
                    element.ChildAdded -= ElementEvent;
                    break;
                case EventTypeEnumerator.ChildRemoved:
                    element.ChildRemoved -= ElementEvent;
                    break;
                case EventTypeEnumerator.Attached:
                    break;
                case EventTypeEnumerator.Detaching:
                    DoAnimation(element);
                    break;
                default:
                    break;
            }
        }

        protected virtual Task DoAnimation(View element) { return null; }

        protected Easing GetEasingMethodFromEnumerator()
        {
            switch (EasingMethod)
            {
                case EasingMethodEnumerator.BounceIn:
                    return Easing.BounceIn;
                case EasingMethodEnumerator.BounceOut:
                    return Easing.BounceOut;
                case EasingMethodEnumerator.CubicIn:
                    return Easing.CubicIn;
                case EasingMethodEnumerator.CubicOut:
                    return Easing.CubicOut;
                case EasingMethodEnumerator.CubicInOut:
                    return Easing.CubicInOut;
                case EasingMethodEnumerator.Linear:
                    return Easing.Linear;
                case EasingMethodEnumerator.SinIn:
                    return Easing.SinIn;
                case EasingMethodEnumerator.SinOut:
                    return Easing.SinOut;
                case EasingMethodEnumerator.SinInOut:
                    return Easing.SinInOut;
                case EasingMethodEnumerator.SpringIn:
                    return Easing.SpringIn;
                case EasingMethodEnumerator.SpringOut:
                    return Easing.SpringOut;
                default:
                    return Easing.Linear;
            }
        }

        private void ElementEvent(object sender, EventArgs e)
        {
            DoAnimation((sender as View));
        }

    }
}
