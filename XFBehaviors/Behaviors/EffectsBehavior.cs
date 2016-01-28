namespace XFBehaviors.Behaviors
{
    using Xamarin.Forms;

    public class EffectsBehavior : Behavior<View>
    {
        public static BindableProperty EffectsGroupNameProperty = BindableProperty.Create("EffectsGroupName", typeof(string), typeof(EffectsBehavior), string.Empty);
        public static BindableProperty EffectNameProperty = BindableProperty.Create("EffectName", typeof(string), typeof(EffectsBehavior), string.Empty);

        /// <summary>
        /// Defines the effects group applied to this effect.
        /// </summary>
        public string EffectsGroupName
        {
            get { return GetValue(EffectsGroupNameProperty).ToString(); }
            set { SetValue(EffectsGroupNameProperty, value); }
        }

        /// <summary>
        /// Defines the effect name.
        /// </summary>
        public string EffectName
        {
            get { return GetValue(EffectNameProperty).ToString(); }
            set { SetValue(EffectNameProperty, value); }
        }

        protected override void OnAttachedTo(View element)
        {
            base.OnAttachedTo(element);
            if (!string.IsNullOrWhiteSpace(EffectsGroupName) && !string.IsNullOrWhiteSpace(EffectName))
                element.Effects.Add(Effect.Resolve(string.Format("{0}.{1}", EffectsGroupName, EffectName)));
        }
    }
}
