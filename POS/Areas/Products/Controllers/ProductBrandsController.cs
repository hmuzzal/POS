using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POS.Areas.Products.Models;
using POS.Identity;

namespace POS.Areas.Products.Controllers
{
    public class ProductBrandsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products/ProductBrands
        public async Task<ActionResult> Index()
        {
            return View(await db.ProductBrands.ToListAsync());
        }

        // GET: Products/ProductBrands/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductBrand productBrand = await db.ProductBrands.FindAsync(id);
            if (productBrand == null)
            {
                return HttpNotFound();
            }
            return View(productBrand);
        }

        // GET: Products/ProductBrands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/ProductBrands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Brand")] ProductBrand productBrand)
        {
            if (ModelState.IsValid)
            {
                db.ProductBrands.Add(productBrand);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(productBrand);
        }

        // GET: Products/ProductBrands/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductBrand productBrand = await db.ProductBrands.FindAsync(id);
            if (productBrand == null)
            {
                return HttpNotFound();
            }
            return View(productBrand);
        }

        // POST: Products/ProductBrands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Brand")] ProductBrand productBrand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productBrand).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(productBrand);
        }

        // GET: Products/ProductBrands/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductBrand productBrand = await db.ProductBrands.FindAsync(id);
            if (productBrand == null)
            {
                return HttpNotFound();
            }
            return View(productBrand);
        }

        // POST: Products/ProductBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProductBrand productBrand = await db.ProductBrands.FindAsync(id);
            db.ProductBrands.Remove(productBrand);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
