using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };

            layout.Children.Add(new Label { Text = "Enter Name" });
            layout.Children.Add(new Entry());
            layout.Children.Add(new Button { Text = "Ok" });

            this.Content = layout;
        }
    }
}