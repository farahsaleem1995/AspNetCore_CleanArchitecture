using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.Mvc.Controllers
{
  public class CoursesController : Controller
  {
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService)
    {
      _courseService = courseService;
    }
    // GET: /<controller>/
    public async Task<IActionResult> Index()
    {
      var model = await _courseService.GetCourses();
      return View(model);
    }
  }
}
