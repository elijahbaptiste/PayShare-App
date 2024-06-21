namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        } 
        
        private void CalendarClicked(object sender, EventArgs e)
        {
            CalendarButton.Text = "Successfully Clicked";
        }

        private void FeedClicked(object sender, EventArgs e) { 
        
        }

        private void FriendsClicked(object sender, EventArgs e) { 
        
        }
    }

}
