using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xmarin_course
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //NavigationService.NavigateAsync("MainNavigationPage/ToDoItemListPage");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
