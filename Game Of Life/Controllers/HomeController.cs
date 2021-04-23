using Game_Of_Life.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Game_Of_Life.Business;
using Game_Of_Life.Extensions;

namespace Game_Of_Life.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var gridModel = new GridModel();

            return View(gridModel);
        }

        [HttpPost]
        public IActionResult Grid(int[][] grid)
        {
            GameLogic gameLogic = new GameLogic();

            GridModel model = new GridModel() {
                Grid = gameLogic.Play(grid),
                Rows = grid.GetRowCount(),
                Columns = grid.GetColumnCount()
            };

            return PartialView("~/Views/Grid/Grid.cshtml", model);
        }

    }
}
