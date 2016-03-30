﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookApp.Models
{
    public class TextObject
    {
        public string type { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }

    public class ComicUrl
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class ComicSeries
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }

    public class Date
    {
        public string type { get; set; }
        public string date { get; set; }
    }

    public class Price
    {
        public string type { get; set; }
        public double price { get; set; }
    }

    public class ComicThumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Image
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

    public class Creator
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string role { get; set; }
    }

    public class Creators
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<Creator> items { get; set; }
        public int returned { get; set; }
    }

    public class Characters
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class ComicStory
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class ComicStories
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<ComicStory> items { get; set; }
        public int returned { get; set; }
    }

    public class ComicEvents
    {
        public int available { get; set; }
        public string collectionURI { get; set; }
        public List<object> items { get; set; }
        public int returned { get; set; }
    }

    public class ComicComic
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public int issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public List<TextObject> textObjects { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public Series series { get; set; }
        public List<object> variants { get; set; }
        public List<object> collections { get; set; }
        public List<object> collectedIssues { get; set; }
        public List<Date> dates { get; set; }
        public List<Price> prices { get; set; }
        public ComicThumbnail thumbnail { get; set; }
        public List<Image> images { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public ComicStories stories { get; set; }
        public ComicEvents events { get; set; }
    }

    public class ComicDataContainer
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ComicComic> results { get; set; }
    }

    public class ComicDataWrapper
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public ComicDataContainer data { get; set; }
    }
}
