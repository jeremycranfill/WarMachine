using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarMachine.ViewModels;
using WarMachine.Models;
using WarMachine.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WarMachine.Controllers
{
    public class AddModelController : Controller
    {

        private readonly ModelDbContext context;
        public AddModelController(ModelDbContext dbContext) { context = dbContext; } 
            
            
            // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Model()
        {

            var ViewModel = new AddModelViewModel();
            
            return View(ViewModel);


        }


        [HttpPost]
        public IActionResult Model(AddModelViewModel model)
        {

            string ViewName = model.AddType;

            return RedirectToAction(ViewName);


        }


        public IActionResult AddUnit()
        {

            return View();


        }



        [HttpPost]
        public IActionResult AddUnit(AddUnitViewModel model)
        {

            if (ModelState.IsValid)
                {


                UnitModel newUnit = new UnitModel();


                newUnit.ARM = model.ARM;
                newUnit.CMD = model.CMD;
                newUnit.DEF = model.DEF;
                newUnit.FA = model.FA;
                newUnit.MAT = model.MAT;
                newUnit.MaxUnit = model.MaxUnit;
                newUnit.MinUnit = model.MinUnit;
                newUnit.PointCost = model.PointCost;
                newUnit.RAT = model.RAT;
                newUnit.SPD = model.SPD;
                newUnit.STR = model.STR;
                context.Units.Add(newUnit);
                context.SaveChanges();
                return Redirect("/");
                              

                 }



            return View(model);



        }


        public IActionResult AddSolo()
        {

            return View();


        }

        [HttpPost]
        public IActionResult AddSolo(AddSoloViewModel model)
        {

            if (ModelState.IsValid)
            {


                UnitModel newUnit = new UnitModel();


                newUnit.ARM = model.ARM;
                newUnit.CMD = model.CMD;
                newUnit.DEF = model.DEF;
                newUnit.FA = model.FA;
                newUnit.MAT = model.MAT;
               newUnit.PointCost = model.PointCost;
                newUnit.RAT = model.RAT;
                newUnit.SPD = model.SPD;
                newUnit.STR = model.STR;
                context.Units.Add(newUnit);
                context.SaveChanges();
                return Redirect("/");


            }

            return View(model);



        }








        public IActionResult Spell()
        {
            return View();

        }



        public IActionResult Ability()
        {
            

            return View();

        }


        public IActionResult Weapon()
        {


            return View();

        }




    }

}
