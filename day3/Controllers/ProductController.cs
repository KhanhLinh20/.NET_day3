using day3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace day3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ASPEntities ctx = new ASPEntities();
        public async Task<ActionResult> Index()
        {
            var products = await ctx.demoASP1.ToListAsync();
            return View(products);
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(demoASP1 p)
        {
            ctx.demoASP1.Add(p);
            await ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}