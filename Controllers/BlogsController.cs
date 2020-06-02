using Bloglist.Models;
using Bloglist.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bloglist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogsController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public ActionResult<List<Blog>> Get() => _blogService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBlog")]
        public ActionResult<Blog> Get(string id)
        {
            var blog = _blogService.Get(id);

            if (blog == null)
            {
                return NotFound();
            }

            return blog;
        }

        [HttpPost]
        public ActionResult<Blog> Create(Blog blog)
        {
            _blogService.Create(blog);

            return CreatedAtRoute("GetBlog", new { id = blog.Id.ToString() }, blog);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Blog blogIn)
        {
            var blog = _blogService.Get(id);

            if (blog == null)
            {
                return NotFound();
            }

            _blogService.Update(id, blogIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var blog = _blogService.Get(id);

            if (blog == null)
            {
                return NotFound();
            }

            _blogService.Remove(blog.Id);

            return NoContent();
        }
    }
}