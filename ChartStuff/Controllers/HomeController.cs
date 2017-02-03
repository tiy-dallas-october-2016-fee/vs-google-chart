using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ChartStuff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CoolChart()
        {
            var startYear = 2014;
            var endYear = 2016;
            var numberOfYears = endYear - startYear;
            var numberOfMonths = numberOfYears * 12;
            var numberOfSeries = 3;

            var data = new ArrayList();

            for (var i = 0; i < numberOfYears; i++)
            {
                for (var j = 0; j < 12; j++)
                {
                    var rowArray = new object[numberOfSeries + 2];
                    rowArray[0] = startYear + i;
                    rowArray[1] = j;
                    rowArray[2] = j; //data for series 1 would go here
                    rowArray[3] = 4; //data for series 2 would go here
                    rowArray[4] = j + 10; //data for series 3 would go here
                    data.Add(rowArray);
                }
            }

            var output = new
            {
                data = data,
                series = new string [] { "First", "Second", "Third" } //For every series, you need a string name here
            };

            //Map your series data to the above structure




            /*
            data.Add(new object[] { 2014, 0, 1, 9 });
            data.Add(new object[] { 2014, 1, 5, 20 });
            data.Add(new object[] { 2014, 2, 10, 3 });
            data.Add(new object[] { 2014, 3, 6, 15 });
            data.Add(new object[] { 2014, 4, 7, 14 });
            data.Add(new object[] { 2014, 5, 6, 19 });
            data.Add(new object[] { 2014, 6, 2, 2 });
            data.Add(new object[] { 2014, 7, 20, 7 });
            data.Add(new object[] { 2014, 8, 6, 7 });
            data.Add(new object[] { 2014, 9, 4, 21 });
            data.Add(new object[] { 2014, 10, 9, 15 });
            data.Add(new object[] { 2014, 11, 8, 13 });
            data.Add(new object[] { 2015, 0, 7, 10 });
            data.Add(new object[] { 2015, 1, 17, 9 });
            */

            var stuff = new JavaScriptSerializer().Serialize(output);

            ViewBag.DataStuff = stuff;

            return View();
        }
    }
}