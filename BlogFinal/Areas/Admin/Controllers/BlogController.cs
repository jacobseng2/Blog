using BlogFinal.Data;
using BlogFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogFinal.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> View(int id)
        {
            var post = await _context.Post.FirstOrDefaultAsync(x => x.PostId == id);

            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("CommentId,PostId,Title,Body,UserId")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(View));
            }
            ViewData["PostId"] = new SelectList(_context.Post, "PostId", "PostId", comment.PostId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", comment.UserId);


            return Ok();
        }
    }
}
