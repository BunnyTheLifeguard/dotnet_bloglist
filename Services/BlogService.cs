using Bloglist.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Bloglist.Services
{
    public class BlogService
    {
        private readonly IMongoCollection<Blog> _blogs;

        public BlogService(IBloglistDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _blogs = database.GetCollection<Blog>(settings.BloglistCollectionName);
        }

        public List<Blog> Get() => _blogs.Find(blog => true).ToList();

        public Blog Get(string id) => _blogs.Find<Blog>(blog => blog.Id == id).FirstOrDefault();

        public Blog Create(Blog blog)
        {
            _blogs.InsertOne(blog);
            return blog;
        }

        public void Update(string id, Blog blogIn) =>
            _blogs.ReplaceOne(blog => blog.Id == id, blogIn);

        public void Remove(Blog blogIn) => _blogs.DeleteOne(blog => blog.Id == blogIn.Id);

        public void Remove(string id) => _blogs.DeleteOne(blog => blog.Id == id);
    }
}