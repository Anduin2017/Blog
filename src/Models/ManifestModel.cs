using Newtonsoft.Json;
using System.Collections.Generic;

namespace Aiursoft.Blog.Models
{
    public class ManifestModel
    {
        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        public string Name { get; set; }

        [JsonProperty("start_url")]
        public string StartUrl { get; set; }

        public List<ManifestIcon> Icons { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("theme_color")]
        public string ThemeColor { get; set; }

        public string Display { get; set; }
        public string Orientation { get; set; }
        public string Description { get; set; }
    }

    public class ManifestIcon
    {
        public string Src { get; set; }
        public string Sizes { get; set; }
        public string Type { get; set; }
    }
}
