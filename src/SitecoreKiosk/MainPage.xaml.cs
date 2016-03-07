using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding;

namespace SitecoreKiosk
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            PostFormToSitecore();
        }

        private void PostFormToSitecore()
        {
            var content = BuildJsonRequestContent();

            try
            {
                using (var client = new HttpClient())
                {
                    var result = client.PostAsync(
                        new Uri("http://192.168.1.112/sitecore/api/ssc/PersonSSC-Controllers/person"), content);
                }
            }
            catch (Exception ex)
            {
                //Handle error
                throw;
            }
        }

        private IHttpContent BuildJsonRequestContent()
        {
            IHttpContent content = new HttpStringContent(
                    "{ \"firstname\": \"" + tbFirstName.Text +
                    "\" , \"surname\": \" " + tbLastName.Text +
                    " \", \"id\": \" " + tbEmail.Text +
                    " \",\"email\":   \"" + tbEmail.Text + "\"}",
                    UnicodeEncoding.Utf8,
                    "application/json");

            return content;
        }
    }
}
