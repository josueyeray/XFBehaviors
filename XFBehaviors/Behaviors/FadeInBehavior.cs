using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFBehaviors.Enums;

namespace XFBehaviors.Behaviors
{
    public class FadeInBehavior : Behavior<View>
    {
        public EventTypeEnumerator OnEvent { get; set; }
        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);

        }

        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
