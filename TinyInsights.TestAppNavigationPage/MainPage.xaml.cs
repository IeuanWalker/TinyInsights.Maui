namespace TinyInsights.TestAppNavigationPage
{
    public partial class MainPage : ContentPage
    {
        readonly IInsights _insights;
        public MainPage(IInsights insights)
        {
            _insights = insights;

            InitializeComponent();
        }
    }

}
