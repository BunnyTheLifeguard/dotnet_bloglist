namespace Bloglist.Models
{
    public class BloglistDatabaseSettings : IBloglistDatabaseSettings
    {
        public string BloglistCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBloglistDatabaseSettings
    {
        string BloglistCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}