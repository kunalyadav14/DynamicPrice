using DynamicPrice.Data;
using DynamicPrice.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicPrice.Controllers
{
    public class DynamicpriceController : Controller
    {
        private readonly DynamicPriceContext _context;

        public DynamicpriceController(DynamicPriceContext context)
        {
            _context = context;
        }
        public IActionResult Index( int pg =1)
        {
            const int pageSize = 20;
            if(pg < 1)
                pg = 1;
            int recsCount = _context.Dynamicprice.Count();
            var pager =new Pager(recsCount,pg,pageSize);
            int recSkip =(pg -1)* pageSize;
            List<Dynamicprice> dynamicprice = _context.Dynamicprice.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(dynamicprice);
        }
    }
}
