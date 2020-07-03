using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sharp_sharp.Models;

namespace sharp_sharp.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        public ActionResult index(calc c,string calculate)
        {
            double result = 0.0;
            if (calculate == "divv")
            {
                result = c.WEIGHT / (c.HEIGHT * c.HEIGHT);
                if (result < 18.5)
                c.BMI = "Your BMI is " + result.ToString("#.#") + ". You are underweight";
                else
                    if (result < 25)
                    c.BMI = "Your BMI is " + result.ToString("#.#") + ". You are normal weight";
                else
                    if (result < 30)
                    c.BMI = "Your BMI is " + result.ToString("#.#") + ". You are overweight";
                else
                    if (result > 30)
                    c.BMI = "Your BMI is " + result.ToString("#.#") + ". You are obesed";
            }
            return View(c);
            
        }

    }
}