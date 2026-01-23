using Microsoft.AspNetCore.Mvc;
using MvcCorePracticas.Models;

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
            return View(resultado);
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            TablaMultiplicar tabla = new TablaMultiplicar();
            tabla.Operacion = new List<string>();
            tabla.Resultado = new List<int>();
            List<string> operacion = new List<string>();
            List<int> resultado = new List<int>();
            
            for(int i = 1; i<=10; i++)
            {
               int res = i * numero;
                string ope = numero + "*" + i ;
                operacion.Add(ope);
                resultado.Add(res);
                tabla.Operacion.Add(ope);
                tabla.Resultado.Add(res);
            }
            ViewBag.resultado = resultado;
            ViewBag.operacion = operacion;
            return View(tabla);
        }

        public IActionResult TablaMultiplicar2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar2(int numero)
        {
            List<TabMult> table = new List<TabMult>();
            //table.Operacion = new List<string>();
            //table.Resultado = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                TabMult tab = new TabMult();
                int res = i * numero;
                string ope = numero + "*" + i;
                tab.Operacion = ope;
                tab.Resultado = res;
                table.Add(tab);
            }
            
            return View(table);
        }
    }
}
