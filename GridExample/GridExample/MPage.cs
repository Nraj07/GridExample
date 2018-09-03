using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GridExample
{
    public class MPage : ContentPage
    {
        
        static int count = 0;
        public MPage()
        {
            var label = new Label()
            {
                Text = "Label",
                BackgroundColor =   Color.Coral
            };
            var button = new Button()
            {
                Text = "Button",
                BackgroundColor = Color.DarkSalmon
            };

            button.Clicked += Button_Clicked;

            var gridView = new Grid()
            {
                
            };

            var row = new RowDefinition()
            {
                Height = new GridLength(3, GridUnitType.Star)
            };

            var column = new ColumnDefinition()
            {
                Width = new GridLength(1, GridUnitType.Star)
            };
           
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridView.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100) });
            gridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });

            var label1 = new Label { Text = "Top Left", BackgroundColor = Color.DarkGoldenrod  };
            var label2 = new Label { Text = "Top Right", BackgroundColor = Color.DarkOliveGreen };
            var label3 = new Label { Text = "Bottom Left", BackgroundColor = Color.Firebrick };
            var label4 = new Label { Text = "Bottom Right", BackgroundColor = Color.Goldenrod };

            gridView.Children.Add(button, 0, 0);
            gridView.Children.Add(label2, 1, 0);
            gridView.Children.Add(label3, 0, 1);
            gridView.Children.Add(label4, 1, 1);

            /*
            gridView.RowDefinitions.Add(row);
            //gridView.ColumnDefinitions.Add(column);

            gridView.Children.Add(button, 0, 0);
            gridView.Children.Add(label, 0, 1);
            gridView.Children.Add(label1, 0, 2);

            gridView.Children.Add(button, 1, 0);
            gridView.Children.Add(label, 2, 0);

            gridView.Children.Add(label1, 1, 1);
            gridView.Children.Add(label2, 1, 2);

            gridView.Children.Add(button, 2, 1);
            gridView.Children.Add(label, 2, 2);

            */
            Content = gridView;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            count++;
            if(count >1)
            {
                if(count%2 == 0)
                {
                   button.BackgroundColor = Color.Cornsilk;
                }
                else
                {
                   button.BackgroundColor = Color.DarkViolet;
                }
            }
        }
    }
}
