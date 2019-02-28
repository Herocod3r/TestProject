using System;
using Newtonsoft.Json;

namespace SampleApp.Models
{


    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }


    public class Article
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }


        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

    }



}
