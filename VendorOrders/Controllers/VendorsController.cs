using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VendorOrders.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View("Index");
    }
  }
}