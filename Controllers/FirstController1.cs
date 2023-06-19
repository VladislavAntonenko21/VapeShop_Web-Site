using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class FirstController : Controller
    {
        private readonly EF_DataContext _dbContext;
        //МЕТОДЫ ОТВЕЧАЮЩИЕ ЗА ОТКРЫТИЕ СТРАНИЦ:
        public FirstController(EF_DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /First/
        public IActionResult Index()
        {
            //return Ok(_dbContext.Liquids?.ToList());
            //var liq_list = _dbContext.Liquids.ToList(); 
            return View();

            //return Ok(_dbContext.Liquids.ToList());
        }
        
        // GET: /First/Liquids/ 
        public IActionResult Liquids()
        {
            var liq_list = _dbContext.Liquids.ToList();
            return View(liq_list);
        }

        // GET: /First/Pods/ 
        public IActionResult Pods()
        {
            var pods_list = _dbContext.Pods.ToList();
            return View(pods_list);
        }

        // GET: /First/Vape/ 
        public IActionResult Vape()
        {
            return View();
        }

        // GET: /First/Accessories/ 
        public IActionResult Accessories()
        {
            return View();
        }

        // GET: /First/Hookah/ 
        public IActionResult Hookah()
        {
            return View();
        }

        // GET: /First/Oneuse/ 
        public IActionResult Oneuse()
        {
            return View();
        }

        // GET: /First/Pixl/ 
        public IActionResult Pixl()
        {
            return View();
        }

        // GET: /First/Authorization/ 
        public IActionResult Authorization()
        {
            return View();
        }
       
    }
}