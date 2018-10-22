using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAmazingMicroservice.Models;

namespace MyAmazingMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloggingController : ControllerBase
    {
        private readonly BloggingContext _bloggingContext;

        public BloggingController(BloggingContext context)
        {
            _bloggingContext = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult GetAll()
        {
            var model = _bloggingContext.Blogs.ToArray();
            return Ok(model);
        }

      
    }
}
