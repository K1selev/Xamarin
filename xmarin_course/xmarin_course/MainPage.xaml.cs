using System;
using System.Diagnostics;
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
            var isLightTheme = await DisplayAlert("Выбор темы", "", "Светлая", "Темная");
            if (isLightTheme)
            {
                UseLightMode();
            }
            else
            {
                UseDarkMode();
            }
        }

        private async void AddButtonClick(object sender, EventArgs e)
        {
            InputField.IsVisible = !InputField.IsVisible;
            if (InputField.IsVisible)
            {
                ButtonAdd.Text = "Скрыть";
            } else
            {
                ButtonAdd.Text = "Добавить";
            }
        }

        private async void SettingsButtonClick(object sender, EventArgs e)
        {
            ButtonTheme.IsVisible = !ButtonTheme.IsVisible;
            slider.IsVisible = !slider.IsVisible;
            label.IsVisible = !label.IsVisible;
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
            label.Text = "Вы на темной стороне";
        }

        private async void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
        }

        private async void HandleEnterPressed(object sender, EventArgs args)
        {
            Debug.WriteLine("Enter pressed");
            FlexLayout newTODOCell = new FlexLayout();
            newTODOCell.JustifyContent = FlexJustify.SpaceBetween;
            newTODOCell.HeightRequest = 40;
            newTODOCell.AlignItems = FlexAlignItems.Center;

            Label newTODO = new Label();
            newTODO.Text = InputField.Text;
            CheckBox newToDoCheckBox = new CheckBox();
            newToDoCheckBox.IsChecked = false;

            newTODOCell.Children.Add(newToDoCheckBox);
            newTODOCell.Children.Add(newTODO);

            ToDoList.Children.Add(newTODOCell);
            InputField.Text = "";
        }


    }
}
