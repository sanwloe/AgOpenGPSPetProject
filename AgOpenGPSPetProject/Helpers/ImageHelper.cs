using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace AgOpenGPSPetProject.Helpers
{
    public static class ImageHelper
    {
        public static Bitmap LoadFromResource(Uri resourceUri)
        {
            return new Bitmap(AssetLoader.Open(resourceUri));
        }
        public static Bitmap LoadFromResource(string uri)
        {
            return new Bitmap(AssetLoader.Open(new Uri(uri)));
        }
    }
}
