using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DecisionatorForms.Views
{
    public partial class DisplayTokenPage : ContentPage
    {
        public DisplayTokenPage(string token)
        {
            InitializeComponent();

            this.Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = token
                    }
                }
            };
        }
    }
}
