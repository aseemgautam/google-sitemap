using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace Utils.Sitemap
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class Sitemap {
        private ArrayList map;

        public Sitemap() {
            map = new ArrayList();
        }

        [XmlElement("url")]
        public SitemapLocation[] Locations
        {
            get
            {
                SitemapLocation[] items = new SitemapLocation[map.Count];
                map.CopyTo(items);
                return items;
            }
            set
            {
                if (value == null)
                    return;
                SitemapLocation[] items = (SitemapLocation[]) value;
                map.Clear();
                foreach (SitemapLocation item in items)
                    map.Add(item);
            }
        }

        public string GetSitemapXml() {
            return string.Empty;
        }

        public int Add(SitemapLocation item)
        {
            return map.Add(item);
        }


        public void WriteSitemapToFile(string path) {

            using (FileStream fs = new FileStream(path, FileMode.Create)) {

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();                
                ns.Add("image", "http://www.google.com/schemas/sitemap-image/1.1");                

                XmlSerializer xs = new XmlSerializer(typeof(Sitemap));
                xs.Serialize(fs, this, ns);
            }
        }
    }
}
