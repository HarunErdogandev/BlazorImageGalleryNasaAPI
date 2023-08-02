namespace İmageGallery.Models
{
    public class Collection
    {
        public string version { get; set; }
        public string href { get; set; }
        public List<Item> items { get; set; }
        public Metadata metadata { get; set; }
        public List<Link> links { get; set; }

    }
}
