namespace İmageGallery.Models
{
    public class Item
    {
        public string href { get; set; }
        public List<Data> data { get; set; }
        public List<Link> links { get; set; }
    }
}