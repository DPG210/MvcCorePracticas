using Microsoft.AspNetCore.Mvc;

namespace MvcCorePracticas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SumarNumerosGet(int num1, int num2)
        {
            int resultado = num1 + num2;
            ViewData["resultado"] = "El resultado de " + num1 + " + " + num2 + " es " + resultado;
            return View();
        }
        public IActionResult SumarNumerosPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumerosPost(int num1, int num2)
        {
            int resultado = num1 + num2;
            ViewData["resultado"] = "El resultado de " + num1 + " + " + num2 + " es " + resultado;
            return View();
        }
        public IActionResult ConjeturaCollatz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            int num = numero;
            List<int> resultado = new List<int>();
            resultado.Add(num);
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }
                resultado.Add(num);
            }
            ViewData["conjetura"] = resultado;
            return View();
        }
    }
}
