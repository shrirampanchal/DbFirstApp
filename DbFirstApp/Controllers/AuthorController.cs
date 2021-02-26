using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        
        [HttpGet]
        public IEnumerable<Author> Get()
        {
           using (var context = new BookStoresDbContext())
            {
                return context.Authors.ToList();
                //return context.Authors.Where(any => any.AuthorId == 1).ToList();
            }           
        }
    }
}
