﻿using Microsoft.AspNetCore.Mvc;
using MVC.Db;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly AppDbContext _dbConn;
        public AlumnosController(AppDbContext appDb)
        {
            _dbConn = appDb;
        }
        public IActionResult Index()
        {
            List<Alumnos> alumnos = _dbConn.Alumnos.ToList();
            return View(alumnos);
        }

        public IActionResult Create()
        {
            Alumnos alumno = new();
            return View(alumno);
        }
        [HttpPost]
        public IActionResult Create(Alumnos model)
        {
            ModelState.Remove("NombreCompleto");
            if(ModelState.IsValid)
            {
                _dbConn.Alumnos.Add(model);
                _dbConn.SaveChanges();
                return RedirectToAction("Index");
            }
            return View (model);
        }
    }
}
