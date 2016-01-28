namespace XFBehaviors.Behaviors
{
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Base;
    using Enums;

    public class RotateBehavior : AnimationBaseBehavior
    {
        public static BindableProperty FinalAngleProperty = BindableProperty.Create("FinalAngle", typeof(double), typeof(RotateBehavior), 45.0);
        public static BindableProperty IsRelativeProperty = BindableProperty.Create("IsRelative", typeof(bool), typeof(RotateBehavior), false);
        public static BindableProperty AxisProperty = BindableProperty.Create("Axis", typeof(RotationAxisEnumerator), typeof(RotateBehavior), RotationAxisEnumerator.Z);

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
                    await element.RotateXTo(FinalAngle, (uint)Duration, GetEasingMethodFromEnumerator());
                    break;
                case RotationAxisEnumerator.Y:
                    await element.RotateYTo(FinalAngle, (uint)Duration, GetEasingMethodFromEnumerator());
                    break;
                case RotationAxisEnumerator.Z:
                    if (IsRelative)
                    {
                        await element.RelRotateTo(FinalAngle, (uint)Duration, GetEasingMethodFromEnumerator());
                    }
                    else
                    {
                        await element.RotateTo(FinalAngle, (uint)Duration, GetEasingMethodFromEnumerator());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
