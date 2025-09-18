﻿namespace InsureYouAI.Entitites
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public string MainCoverImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
