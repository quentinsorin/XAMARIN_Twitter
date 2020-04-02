using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_Module4.Utils

{
    [ContentProperty(nameof(Source))]
    public class ImageFromResources : IMarkupExtension
    {
        public String Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source==null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source, typeof(ImageFromResources).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
