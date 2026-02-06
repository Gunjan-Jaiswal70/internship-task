using Microsoft.AspNetCore.Mvc;
using BlogApiProject.Data;
using BlogApiProject.Models;

namespace BlogApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public BlogController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/blog
        [HttpGet]
        public IActionResult GetAllPosts()
        {
            var posts = _context.Posts.ToList();
            return Ok(posts);
        }

        // POST: api/blog
        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return Ok(post);
        }
    }
}
