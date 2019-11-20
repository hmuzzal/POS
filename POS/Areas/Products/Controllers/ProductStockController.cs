using POS.Areas.Products.Models;
using POS.Identity;
using System;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace POS.Areas.Products.Controllers
{
    [Authorize]
    public class ProductStockController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await db.Products.ToListAsync());
        }


    
        public async Task<ActionResult> AddStock(int? id)
        {
          

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();

            }
            TempData["Stock"] = product.Stock;
            product.Stock = 0;

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddStock([Bind(Include = "Id,Code,CategoryId,BrandId,Name,Stock")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.Stock = Convert.ToInt16(TempData["Stock"]) + product.Stock;

                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}