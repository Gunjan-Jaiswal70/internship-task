using Microsoft.AspNetCore.Mvc;
using SimpleBlogAPI.Models;
using SimpleBlogAPI.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBlogAPI.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private static List<Post> _posts = new List<Post>();
        private static int _nextId = 1;

        [HttpGet]
        public IActionResult GetPosts()
        {
            return Ok(_posts); 
        }

        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound(); 
            return Ok(post);
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody] CreatePostDto postDto)
        {
            if (string.IsNullOrEmpty(postDto.Title) || string.IsNullOrEmpty(postDto.Content))
            {
                return BadRequest("Title aur Content dono zaroori hain!"); 
            }
            var newPost = new Post
            {
                Id = _nextId++,
                Title = postDto.Title,
                Content = postDto.Content,
                CreatedAt = DateTime.Now
            };

            _posts.Add(newPost);
            
            return CreatedAtAction(nameof(GetPost), new { id = newPost.Id }, newPost);
        }

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