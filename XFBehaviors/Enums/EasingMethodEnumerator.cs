using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBehaviors.Enums
{
    /// <summary>
    /// Enumerator with easing methods.
    /// </summary>
    public enum EasingMethodEnumerator
    {
        /// <summary>
        /// Jumps towards, and then bounces as it settles at the final value.
        /// </summary>
        BounceIn,

        /// <summary>
        /// Leaps to final values, bounces 3 times, and settles.
        /// </summary>
        BounceOut,

        /// <summary>
        /// Starts slowly and accelerates.
        /// </summary>
        CubicIn,

        /// <summary>
        /// Starts quickly and the decelerates.
        /// </summary>
        CubicOut,

        /// <summary>
        /// Accelerates and decelerates. Often a natural-looking choice.
        /// </summary>
        CubicInOut,

        /// <summary>
        /// Linear transformation.
        /// </summary>
        Linear,

        /// <summary>
        /// Smoothly accelerates.
        /// </summary>
        SinIn,

        /// <summary>
        /// Smoothly decelerates.
        /// </summary>
        SinOut,

        /// <summary>
        /// Accelerates in and out.
        /// </summary>
        SinInOut,

        /// <summary>
        /// Moves away and then leaps toward the final value.
        /// </summary>
        SpringIn,

        /// <summary>
        /// Overshoots and then returns.
        /// </summary>
        SpringOut
    }
}
