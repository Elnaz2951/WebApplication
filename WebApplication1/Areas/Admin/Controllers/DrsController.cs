using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Site.Model.layer;
using Site.Model.layer.Context;
using Site.App_Start;
using System.IO;
using Site.Service.layer;
using Site.Views.ViewModels;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class DrsController : Controller
    {
        private SiteContext db = new SiteContext();


        DrsService _DrsService;

        public DrsController()
        {
            _DrsService = new DrsService(db);
        }
        public ActionResult Index()
        {

            var drsList = _DrsService.GetAll().ToList();
            var drsListViewModel = AutoMapperConfig.mapper.Map<List<Drs>, List<DrsViewModel>>(drsList);

            return View(drsListViewModel);
        }








        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrsId,DrExpertise,Name,Family,Phonenumber,Password,Birthdate,RegisterDate,IsActiv")] DrsViewModel drsView)
        {
            if (ModelState.IsValid)
            {




                Drs drs = AutoMapperConfig.mapper.Map<DrsViewModel, Drs>(drsView);
                _DrsService.Add(drs);
                _DrsService.Save();
                return RedirectToAction("Index");
            }
            return View(drsView);
        }










        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drs drs = _DrsService.GetEntity(id.Value);
            if (drs == null)
            {
                return HttpNotFound();
            }
            var drsViewModel = AutoMapperConfig.mapper.Map<Drs, DrsViewModel>(drs);
            return View(drsViewModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrsId,DrExpertise,Name,Family,Phonenumber,Password,Birthdate,RegisterDate,IsActiv")] DrsViewModel drsView)
        {
            if (ModelState.IsValid)
            {
                var drs = AutoMapperConfig.mapper.Map<DrsViewModel, Drs>(drsView);
                _DrsService.Update(drs);
                _DrsService.Save();
                return RedirectToAction("Index");
            }
            return View(drsView);
        }









        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drs drs = _DrsService.GetEntity(id.Value);
            if (drs == null)
            {
                return HttpNotFound();
            }
            var drsView = AutoMapperConfig.mapper.Map<Drs, DrsViewModel>(drs);
            return View(drsView);
        }









        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drs drs = _DrsService.GetEntity(id.Value);
            if (drs == null)
            {
                return HttpNotFound();
            }
            var drsView = AutoMapperConfig.mapper.Map<Drs, DrsViewModel>(drs);
            return View(drsView);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drs drs = _DrsService.GetEntity(id);
            _DrsService.Delete(drs);
            _DrsService.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _DrsService.Dispose();
        }
    }
}
