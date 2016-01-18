namespace XFBehaviorsSample.ViewModels
{
    using System.Windows.Input;
    using Xamarin.Forms;

    /// <summary>
    /// Test viewmodel.
    /// </summary>
    public class MainViewModel
    {
        private int called = 0;
        private Command myCommand;

        public MainViewModel()
        {
            this.myCommand = new Command(MyCommandExecute);
        }

        /// <summary>
        /// My Command
        /// </summary>
        public Command MyCommand => this.myCommand;

        private void MyCommandExecute()
        {
            this.called++;
        }
    }
}
