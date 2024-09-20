using Models1;
using Models1.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVC.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Admin/Customer
        public ActionResult IndexCustomer()
        {
            var iplCustomer = new CustomerModels();
            var model = iplCustomer.ListAll();
            return View(model);
        }

        // GET: Admin/Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Customer/Create
        [HttpPost]
        public ActionResult Create(Customer collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            try
            {
                if (ModelState.IsValid)
                {
                    var model = new CustomerModels();
                    int res = model.Create(collection.FullName, collection.Email, collection.PhoneNumber, collection.Address, collection.Date); 
                    // TODO: Add update logic here
                    if(res > 0)
                    {

                    return RedirectToAction("IndexCustomer");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công!");
                    }
                }

                return View(collection);
            }
            catch (Exception ex)
            {
                //Sp_Customer_Insert
                Console.WriteLine(ex.ToString());
                return View();
            }
        }
        






        // GET: Admin/Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
