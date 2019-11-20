using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using POS.Areas.Address.Models;
using POS.Identity;

namespace POS.Areas.Address.Controllers
{
    public class PoliceStationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Address/PoliceStations
        public async Task<ActionResult> Index()
        {
            var policeStations = db.PoliceStations;
            return View(await policeStations.ToListAsync());
        }

        // GET: Address/PoliceStations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceStation policeStation = await db.PoliceStations.FindAsync(id);
            if (policeStation == null)
            {
                return HttpNotFound();
            }
            return View(policeStation);
        }

        // GET: Address/PoliceStations/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Id");
            return View();
        }

        // POST: Address/PoliceStations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,AddressId")] PoliceStation policeStation)
        {
            if (ModelState.IsValid)
            {
                db.PoliceStations.Add(policeStation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Id");
            return View(policeStation);
        }

        // GET: Address/PoliceStations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceStation policeStation = await db.PoliceStations.FindAsync(id);
            if (policeStation == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Id");
            return View(policeStation);
        }

        // POST: Address/PoliceStations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,AddressId")] PoliceStation policeStation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policeStation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "Id", "Id");
            return View(policeStation);
        }

        // GET: Address/PoliceStations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PoliceStation policeStation = await db.PoliceStations.FindAsync(id);
            if (policeStation == null)
            {
                return HttpNotFound();
            }
            return View(policeStation);
        }

        // POST: Address/PoliceStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PoliceStation policeStation = await db.PoliceStations.FindAsync(id);
            db.PoliceStations.Remove(policeStation);
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
