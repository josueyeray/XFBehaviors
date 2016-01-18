namespace XFBehaviors.Triggers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    /// <summary>
    /// Allows to invoke a command from XAML on non button derived controls.
    /// </summary>
    public class InvokeCommandAction : TriggerAction<View>
    {
        /// <summary>
        /// Class for command definition
        /// </summary>
        public InvokeCommandBinding CommandBinding { get; set; }

        protected override void Invoke(View sender)
        {
            if (CommandBinding == null)
            {
                Debug.WriteLine("InvokeCommandAction.CommandBinding is null");
                return;
            }
            if (CommandBinding.Command == null)
            {
                Debug.WriteLine("InvokeCommandAction.CommandBinding.Command is null");
                return;
            }
            if (!CommandBinding.Command.CanExecute(CommandBinding.CommandParameter))
            {
                Debug.WriteLine("InvokeCommandAction.CommandBinding.Command.CanExecute returns false");
                return;
            }

            CommandBinding.Command.Execute(CommandBinding.CommandParameter);
        }
    }

    /// <summary>
    /// Binding support for command and commandparameter.
    /// </summary>
    public class InvokeCommandBinding : BindableObject
    {
        public static BindableProperty CommandProperty = BindableProperty.Create<InvokeCommandBinding, ICommand>(p => p.Command, null, BindingMode.TwoWay);
        public static BindableProperty CommandParameterProperty = BindableProperty.Create<InvokeCommandBinding, object>(p => p.CommandParameter, null, BindingMode.TwoWay);

        /// <summary>
        /// Command to be invoked.
        /// </summary>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        /// <summary>
        /// Command parameter argument.
        /// </summary>
        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }
    }
}
