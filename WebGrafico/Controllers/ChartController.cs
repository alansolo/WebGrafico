using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrafico.Models;

namespace WebGrafico.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Chart()
        {
            return View();
        }

        public JsonResult CargarChart()
        {
            List<ValorGrafica> ListValorGrafica = new List<ValorGrafica>();

            ValorGrafica valor = new ValorGrafica();

            valor = new ValorGrafica();
            valor.Valor = 0.801829679;
            valor.Label = "20/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.550391403;
            valor.Label = "21/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.123960205;
            valor.Label = "22/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.765876051;
            valor.Label = "23/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.108354418;
            valor.Label = "24/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.216476444;
            valor.Label = "25/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.84003446;
            valor.Label = "26/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.485132417;
            valor.Label = "27/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.288778012;
            valor.Label = "28/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.631206621;
            valor.Label = "28/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.495651811;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.532218021;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);
 
            valor = new ValorGrafica();
            valor.Valor = 0.144822337;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.823177638;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.761979719;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.997624505;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            valor = new ValorGrafica();
            valor.Valor = 0.901910106;
            valor.Label = "29/11/2020";
            ListValorGrafica.Add(valor);

            return Json(ListValorGrafica, JsonRequestBehavior.AllowGet);
        }

    }
}