using Microsoft.AspNetCore.Mvc;
using SimpleBlogAPI.Models;

namespace SimpleBlogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        // Temporary list to store posts
        private static List<Post> _posts = new List<Post>
        {
            new Post 
            { 
                Id = 1, 
                Title = "My First Post", 
                Content = "Welcome to my API!", 
                Author = "Gunjan" 
            }
        };

        // 1. GET: api/posts (Saare posts dekhne ke liye)
        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            return Ok(_posts);
        }

        // 2. POST: api/posts (Naya post add karne ke liye)
        [HttpPost]
        public ActionResult<Post> CreatePost(Post newPost)
        {
            newPost.Id = _posts.Max(p => p.Id) + 1; // Auto ID generator
            _posts.Add(newPost);
            return CreatedAtAction(nameof(GetPosts), new { id = newPost.Id }, newPost);
        }

        // 3. DELETE: api/posts/{id} (Post delete karne ke liye)
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();

            _posts.Remove(post);
            return NoContent();
        }
    }
}