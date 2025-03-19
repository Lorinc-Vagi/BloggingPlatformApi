namespace BloggingPlatformApi.Entities
{
    public class Blog
    {
        //       Blog entitás:
        //- [ ] `id`: azonosító
        //- [ ] `title`
        //- [ ] `content`
        //- [ ] `category`
        //- [ ] `tags`
        //- [ ] `createdAt`
        //- [ ] `udatedAt`
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
