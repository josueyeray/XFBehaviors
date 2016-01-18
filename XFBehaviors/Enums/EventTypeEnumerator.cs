using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBehaviors.Enums
{
    /// <summary>
    /// Enumerator of event types our behavior could execute on raising.
    /// </summary>
    public enum EventTypeEnumerator
    {
        /// <summary>
        /// View received focus.
        /// </summary>
        Focused,

        /// <summary>
        /// View lost focus.
        /// </summary>
        Unfocused,

        /// <summary>
        /// View add a child.
        /// </summary>
        ChildAdded,

        /// <summary>
        /// View remove a child.
        /// </summary>
        ChildRemoved,

        /// <summary>
        /// Behavior is attached to view.
        /// </summary>
        Attached,

        /// <summary>
        /// Behavior is dettaching from view.
        /// </summary>
        Detaching
    }
}
