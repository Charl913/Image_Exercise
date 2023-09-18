using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        string[] images = {
            "ImageExercise.Images.castelmezzano-1979546_1280.jpg",
            "ImageExercise.Images.architecture-1868667_1280.jpg",
            "ImageExercise.Images.village-279013_1280.jpg"
        };
        public Exercise()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("ImageExercise.Images.architecture-1868667_1280.jpg");
        }

        public int indexPrevious = 0;

        public int indexNext = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            indexPrevious = indexNext;

            if (indexPrevious < 3 && indexPrevious >= 0)
            {
                image.Source = ImageSource.FromResource(images[indexPrevious]);
            }
            else
            {
                indexPrevious = 2;

                image.Source = ImageSource.FromResource(images[indexPrevious]);
            }

            indexPrevious--;

            indexNext = indexPrevious;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            indexNext = indexPrevious;

            if (indexNext < 3 && indexNext >= 0)
            {
                image.Source = ImageSource.FromResource(images[indexNext]);
            }
            else
            {
                indexNext = 0;
                image.Source = ImageSource.FromResource(images[indexNext]);
            }

            indexNext++;

            indexPrevious = indexNext;
        }
    }
}