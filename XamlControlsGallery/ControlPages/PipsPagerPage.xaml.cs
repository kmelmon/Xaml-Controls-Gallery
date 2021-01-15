using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls;

namespace AppUIBasics.ControlPages
{
    public sealed partial class PipsPagerPage : Page
    {
        public List<string> Pictures = new List<string>()
        {
            "Assets/SampleMedia/LandscapeImage1.jpg",
            "Assets/SampleMedia/LandscapeImage2.jpg",
            "Assets/SampleMedia/LandscapeImage3.jpg",
            "Assets/SampleMedia/LandscapeImage4.jpg",
            "Assets/SampleMedia/LandscapeImage5.jpg",
            "Assets/SampleMedia/LandscapeImage6.jpg",
            "Assets/SampleMedia/LandscapeImage7.jpg",
            "Assets/SampleMedia/LandscapeImage8.jpg",
        };
        public PipsPagerPage()
        {
            this.InitializeComponent();
        }

        private void OrientationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TestPipsPager1 == null) return;

            string orientation = e.AddedItems[0].ToString();

            switch (orientation)
            {
                case "Vertical":
                    TestPipsPager1.Orientation = Orientation.Vertical;
                    break;

                case "Horizontal":
                default:
                    TestPipsPager1.Orientation = Orientation.Horizontal;
                    break;
            }
        }

        private void PrevButtonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TestPipsPager1 == null) return;

            string prevButtonVisibility = e.AddedItems[0].ToString();

            switch (prevButtonVisibility)
            {
                case "Visible":
                    TestPipsPager1.PreviousButtonVisibility = PipsPagerButtonVisibility.Visible;
                    break;

                case "VisibleOnPointerOver":
                    TestPipsPager1.PreviousButtonVisibility = PipsPagerButtonVisibility.VisibleOnHover;
                    break;

                case "Collapsed":
                default:
                    TestPipsPager1.PreviousButtonVisibility = PipsPagerButtonVisibility.Collapsed;
                    break;
            }
        }

        private void NextButtonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TestPipsPager1 == null) return;

            string nextButtonVisibility = e.AddedItems[0].ToString();

            switch (nextButtonVisibility)
            {
                case "Visible":
                    TestPipsPager1.NextButtonVisibility = PipsPagerButtonVisibility.Visible;
                    break;

                case "VisibleOnPointerOver":
                    TestPipsPager1.NextButtonVisibility = PipsPagerButtonVisibility.VisibleOnHover;
                    break;

                case "Collapsed":
                default:
                    TestPipsPager1.NextButtonVisibility = PipsPagerButtonVisibility.Collapsed;
                    break;
            }
        }
    }
}