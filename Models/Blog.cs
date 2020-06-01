using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Bloglist.Models
{
  [BsonIgnoreExtraElements]
  public class Blog
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("title")]
    [JsonProperty("title")]
    public string title { get; set; }
    public string author { get; set; }
    public string url { get; set; }
    public int likes { get; set; }
  }
}