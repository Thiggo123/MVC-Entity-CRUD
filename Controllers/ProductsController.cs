using MVC_Treinando.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Treinando.Controllers
{
    public class ProductsController : Controller
    {

        UnitofWork.UnitofWork _uow;



        public ProductsController()
        {
            _uow = new UnitofWork.UnitofWork();
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(_uow.ProductRepository.findAll());
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View(_uow.ProductRepository.findById(id));
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Products product)
        {
            try
            {
                // TODO: Add insert logic here
                _uow.ProductRepository.Add(product);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_uow.ProductRepository.findById(id));
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products products)
        {
            try
            {
                // TODO: Add update logic here
                _uow.ProductRepository.Edit(products);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_uow.ProductRepository.findById(id));
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Products products)
        {
            try
            {
                // TODO: Add delete logic here
                _uow.ProductRepository.Remove(_uow.ProductRepository.findById(id));
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
