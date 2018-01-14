using System.Drawing;
using System.IO;
using System.Net;

using Newtonsoft.Json;

namespace ClientSoft.WFTest.Models
{
    public class User
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        public Bitmap GetImage()
        {
            var stream = GetImageStream();
            var image = Image.FromStream(stream);

            return new Bitmap(image, new Size(100, 100));
        }

        [JsonIgnore]
        public string FullName => $"{FirstName} {LastName}";


        #region Non-public methods
        private Stream GetImageStream()
        {
            var downloadedResult = DownloadImage();
            return downloadedResult.GetResponseStream();
        }

        private WebResponse DownloadImage()
        {
            var request = WebRequest.Create(Photo100);
            return request.GetResponse();
        }
        #endregion
    }
}
