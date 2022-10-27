using DynamicPrice.Data;
using DynamicPrice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

namespace DynamicPrice.Controllers
{
    public class DynamicpriceController : Controller
    {
        private readonly DynamicPriceContext _context;

        public DynamicpriceController(DynamicPriceContext context)
        {
            _context = context;
        }
        public IActionResult Index(int pg = 1,string SearchText ="")
        {
            const int pageSize = 20;
            if (pg < 1)
                pg = 1;
            int recsCount = _context.Dynamicprice.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            List<Dynamicprice> dynamicprice; 
            if(SearchText != "" && SearchText != null)
            {
                dynamicprice = _context.Dynamicprice.Where(u => u.Box_Name.Contains(SearchText)).ToList();

            }
            else
                dynamicprice = _context.Dynamicprice.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(dynamicprice);
        }
        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Dynamicprice dynamicprice = _context.Dynamicprice.Where(u => u.BoxId == Id).FirstOrDefault();
            return View(dynamicprice);
        }
        [HttpPost]
        public IActionResult Edit(Dynamicprice dynamicprice)
        {
            _context.Attach(dynamicprice);
            _context.Entry(dynamicprice).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //public IActionResult Edit(Dynamicprice dynamicprice)
        //{
        //    if (dynamicprice.Box_Name == dynamicprice.PredictedPrice_ML.ToString())
        //    {
        //        ModelState.AddModelError("name", "The DisplayOrder annot  exactly match the Name.");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _context.Dynamicprice.Update(dynamicprice);
        //        _context.SaveChanges();
        //        TempData["Success"] = "Category edited Successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
