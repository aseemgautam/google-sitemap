# google-sitemap
Class to create google sitemaps dynamically. Supports images. If certain elements are empty or null, they won't be generated.

## USAGE

Create instance of Sitemap class. Use `Add` method add urls.

### Example

```
Sitemap sitemap = new Sitemap();
sitemap.Add(new SitemapLocation
                {
                    ChangeFrequency = SitemapLocation.eChangeFrequency.monthly,
                    Url = url,
                    Images = images //optional
                });
```             

#### Example Output

```
<?xml version="1.0"?>
<urlset xmlns:image="http://www.google.com/schemas/sitemap-image/1.1" xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
  <url>
    <loc>http://91apartments.com/apartments/noida/jaypee-kube</loc>
    <changefreq>monthly</changefreq>
    <image:image>
      <image:loc>http://cdn.91apartments.com/apartments/noida/site-plans/jaypee-kube-layout.jpg</image:loc>
      <image:title>Jaypee Greens Kube Layout/Master Plan</image:title>
    </image:image>
    <image:image>
      <image:loc>http://cdn.91apartments.com/apartments/noida/floor-plans/jaypee-kube-2-bhk-type-a-1087.jpg</image:loc>
      <image:title>Jaypee Greens Kube 2 BHK Type A 1087 Sq. Ft.</image:title>
    </image:image>        
  </url>
</urlset>
```


