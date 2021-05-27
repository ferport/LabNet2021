using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPEntityFramework.Logic;
using TPEntityFramework.Entities;
using TPMVC.MVC.Models;

namespace TPMVC.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();

        // GET: Territories
        public ActionResult Index()
        {
            try
            {
                List<Territories> territories = territoriesLogic.GetAll();

                List<TerritoriesView> territoriesViews = territories.Select(t => new TerritoriesView
                {
                    id = t.TerritoryID,
                    description = t.TerritoryDescription,
                }).ToList();

                return View(territoriesViews);
            }
            catch(Exception ex)
            {
                ErrorView.errorMessage = "Error al cargar la lista de territorios";
                return RedirectToAction("Index", "Error");
            }
            
        }

        public ActionResult InsertAndUpdate(string id, string description)
        {
            TerritoriesView territoriesView = new TerritoriesView
            { 
                id = id, 
                description = description 
            };

            return View(territoriesView);
        }

       [HttpPost]
        public ActionResult InsertAndUpdate(TerritoriesView territoriesView)
        {
            if(territoriesLogic.FindId(territoriesView.id) == 0) 
            {
                try
                {
                    Territories territoriesEntity = new Territories
                    {
                        TerritoryID = territoriesView.id,
                        TerritoryDescription = territoriesView.description,
                        RegionID = 1
                    };
                    territoriesLogic.Update(territoriesEntity);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ErrorView.errorMessage = "Error al guardar el territorio";
                    return RedirectToAction("Index", "Error");
                }
            }
            else 
            {
                try
                {
                    territoriesLogic.Add(territoriesView.id, territoriesView.description, 1);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ErrorView.errorMessage = "Error al guardar el territorio";
                    return RedirectToAction("Index", "Error");
                }
            }
        }

        public ActionResult Delete(string id)
        {
            try
            {
                territoriesLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ErrorView.errorMessage = "Error al borrar el territorio";
                return RedirectToAction("Index", "Error");
            }
        }
    }
}