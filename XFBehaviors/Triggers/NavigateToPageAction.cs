namespace XFBehaviors.Triggers
{
    using System;
    using System.Diagnostics;
    using Xamarin.Forms;

    /// <summary>
    /// Allows you to navigate to TargetPage directly from XAML.
    /// TargetPage need to be the full qualified name of the page class you
    /// want to navigate to.
    /// </summary>
    public class NavigateToPageAction : TriggerAction<View>
    {
        private INavigation navService;

        /// <summary>
        /// Class for target page definition
        /// </summary>
        public NavigateToPageBinding TargetPageBinding { get; set; }

        protected override async void Invoke(View sender)
        {
            this.navService = Application.Current.MainPage.Navigation;
            if (this.navService == null)
            {
                Debug.WriteLine("Application.Current.MainPage.Navigation is null");
                return;
            }
            if (TargetPageBinding == null)
            {
                Debug.WriteLine("NavigateToPageAction.TargetPageBinding is null");
                return;
            }
            if (string.IsNullOrEmpty(TargetPageBinding.TargetPage))
            {
                Debug.WriteLine("NavigateToPageAction.TargetPageBinding.TargetPage is null");
                return;
            }
            var targetPageType = Type.GetType(TargetPageBinding.TargetPage);
            var targetPageInstance = (Page)Activator.CreateInstance(targetPageType);
            await this.navService.PushAsync(targetPageInstance);
        }
    }

    /// <summary>
    /// Binding support for TargetPage
    /// </summary>
    public class NavigateToPageBinding : BindableObject
    {
        private static readonly BindableProperty TargetPageProperty = BindableProperty.Create<NavigateToPageBinding, string>(p => p.TargetPage, null);

        /// <summary>
        /// Full qualified name of the target page.
        /// </summary>
        public string TargetPage
        {
            get { return GetValue(TargetPageProperty).ToString(); }
            set { SetValue(TargetPageProperty, value); }
        }
    }
}
