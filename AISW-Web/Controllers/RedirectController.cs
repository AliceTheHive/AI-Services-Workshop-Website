﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AISW_Web.Controllers
{
    public class RedirectController : Controller
    {
        public async Task<IActionResult> Index(string tagLabel)
        {
            //var resources = await _context.Resource
            //    .Where(m => m.ShortUrl.ToLower() == tagLabel.ToLower())
            //    .ToListAsync();

            //if (resources.Count > 0)
            //{
            //    return Redirect(resources.FirstOrDefault().TargetUrl);
            //    //return Redirect($"http://www.bing.com/search?q={tag}");
            //}
            //else
            //{
            //    return RedirectToAction(nameof(HomeController.Index), "Home");
            //    //return RedirectToAction("Index", "Home");
            //}

            return null;
        }
    }
}