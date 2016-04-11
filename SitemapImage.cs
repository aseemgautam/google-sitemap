using System.Xml.Serialization;

namespace Utils.Sitemap
{
    [XmlType(Namespace = "http://www.google.com/schemas/sitemap-image/1.1")]
    public class SitemapImage
    {        
        [XmlElement("loc")]
        public string Location { get; set; }

        [XmlElement("caption")]
        public string Caption { get; set; }
        public bool ShouldSerializeCaption() { return !string.IsNullOrEmpty(Caption); }

        [XmlElement("title")]
        public string Title { get; set; }
        public bool ShouldSerializeTitle() { return !string.IsNullOrEmpty(Title); }

        [XmlElement("geo_location")]
        public string GeoLocation { get; set; }
        public bool ShouldSerializeGeoLoacation() { return !string.IsNullOrEmpty(GeoLocation); }
    }
}
