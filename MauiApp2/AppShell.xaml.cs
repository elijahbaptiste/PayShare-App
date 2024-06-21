namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Calendar), typeof(Calendar));
            Routing.RegisterRoute(nameof(Feed), typeof(Feed));
            Routing.RegisterRoute(nameof(FriendsPage), typeof(FriendsPage));
        }
    }
}
