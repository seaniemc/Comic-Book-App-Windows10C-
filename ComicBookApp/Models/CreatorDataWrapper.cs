using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookApp.Models
{
    public class CreatorThumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
        public string small { get; set; }
        public string large { get; set; }
        public string extraLarge { get; set; }
    }

    public class CreatorComics
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class CreatorSeries
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class CreatorStories
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class CreatorEvents
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class CreatorUrl
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class CreatorCreator
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffix { get; set; }
        public string fullName { get; set; }
        public string modified { get; set; }
        public CreatorThumbnail thumbnail { get; set; }
        public string resourceURI { get; set; }
        public CreatorComics comics { get; set; }
        public CreatorSeries series { get; set; }
        public CreatorStories stories { get; set; }
        public CreatorEvents events { get; set; }
        public List<Url> urls { get; set; }
    }

    public class CreatorDataContainer
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<CreatorCreator> results { get; set; }
    }

    public class CreatorDataWrapper
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public CreatorDataContainer data { get; set; }
    }
}
