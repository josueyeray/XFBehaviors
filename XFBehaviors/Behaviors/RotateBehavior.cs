﻿namespace XFBehaviors.Behaviors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using XFBehaviors.Base;
    using XFBehaviors.Enums;

    public class RotateBehavior : AnimationBaseBehavior
    {
        private static readonly BindableProperty FinalAngleProperty = BindableProperty.Create<RotateBehavior, double>(a => a.FinalAngle, 45);
        private static readonly BindableProperty IsRelativeProperty = BindableProperty.Create<RotateBehavior, bool>(a => a.IsRelative, false);
        private static readonly BindableProperty AxisProperty = BindableProperty.Create<RotateBehavior, RotationAxisEnumerator>(a => a.Axis, RotationAxisEnumerator.Z);

        /// <summary>
        /// Final angle, default: 45
        /// </summary>
        public double FinalAngle
        {
            get { return (double)GetValue(FinalAngleProperty); }
            set { SetValue(FinalAngleProperty, value); }
        }

        /// <summary>
        /// Use relative or absolute scaling, default absolute
        /// </summary>
        public bool IsRelative
        {
            get { return (bool)GetValue(IsRelativeProperty); }
            set { SetValue(IsRelativeProperty, value); }
        }

        /// <summary>
        /// Specify the rotation axis, default Z
        /// </summary>
        public RotationAxisEnumerator Axis
        {
            get { return (RotationAxisEnumerator)GetValue(AxisProperty); }
            set { SetValue(AxisProperty, value); }
        }

        protected override async Task DoAnimation(View element)
        {
            switch (Axis)
            {
                case RotationAxisEnumerator.X:
                    await element.RotateXTo(FinalAngle, (uint)Duration, EasingMethod);
                    break;
                case RotationAxisEnumerator.Y:
                    await element.RotateYTo(FinalAngle, (uint)Duration, EasingMethod);
                    break;
                case RotationAxisEnumerator.Z:
                    if (IsRelative)
                    {
                        await element.RelRotateTo(FinalAngle, (uint)Duration, EasingMethod);
                    }
                    else
                    {
                        await element.RotateTo(FinalAngle, (uint)Duration, EasingMethod);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
