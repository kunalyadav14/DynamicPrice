using DynamicPrice.Data;
using DynamicPrice.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicPrice.Controllers
{
    public class CexDatumController : Controller
    {
        private readonly DynamicPriceContext _context;

        public CexDatumController(DynamicPriceContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<CexDatum> cexData = _context.CexData.ToList();

            return View(cexData);
        }
    }
}
