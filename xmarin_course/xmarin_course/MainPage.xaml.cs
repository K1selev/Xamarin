using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xmarin_course
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        private async void OnButtonClick(object sender, EventArgs e)
        {
            Debug.WriteLine("Click!");
            var isLightTheme = await DisplayAlert("Выбор темы", "Выборите тему", "Светлая", "Не фильтрованная");
            if (isLightTheme)
            {
                UseLightMode();
            }
            else
            {
                UseDarkMode();
            }
        }

        private void UseLightMode()
        {
            Debug.WriteLine("choose light mode");
            Application.Current.UserAppTheme = OSAppTheme.Light;
            label.Text = "Выбрана светлая тема";
        }

        private void UseDarkMode()
        {
            Debug.WriteLine("choose dark mode");
            Application.Current.UserAppTheme = OSAppTheme.Dark;
            label.Text = "Выбрана темная тема";
        }
    }
}
