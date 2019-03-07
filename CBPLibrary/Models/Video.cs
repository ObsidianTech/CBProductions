using System;

namespace CBPVideoAPI.Models
{
    public class Video
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public bool FeatureFilm { get; set; }
        public string filepath { get; set; }
        public string filename { get; set; }
        public DateTime UploadDate { get; set; }
    }
}