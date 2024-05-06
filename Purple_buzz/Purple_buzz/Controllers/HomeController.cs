﻿using Microsoft.AspNetCore.Mvc;
using Purple_buzz.DAL;
using Purple_buzz.Models;
using Purple_buzz.ViewModels;

namespace Purple_buzz.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //Service service1 = new Service()
            //{
            //    Name="UI/UX design",
            //    Description="Lorem scsdsdfsd",
            //    PageUrl= "img/services-01.jpg"

            //};
            //Service service2 = new Service()
            //{
            //    Name = "Social Media",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-02.jpg"

            //};
            //Service service3 = new Service()
            //{
            //    Name = "Marketing",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-03.jpg"

            //};
            //Service service4 = new Service()
            //{
            //    Name = "Graphic",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-04.jpg"

            //};
            //Service service5 = new Service()
            //{
            //    Name = "Digital Marketing",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-05.jpg"

            //};
            //Service service6 = new Service()
            //{
            //    Name = "Market Research",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-06.jpg"

            //};
            //Service service7 = new Service()
            //{
            //    Name = "Bizne",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-07.jpg"

            //};
            //Service service8 = new Service()
            //{
            //    Name = "Branding",
            //    Description = "Lorem scsdsdfsd",
            //    PageUrl = "img/services-08.jpg"

            //};
            //List<Service> services = new List<Service>();
            //services.Add(service1);
            //services.Add(service2);
            //services.Add(service3);
            //services.Add(service4);
            //services.Add(service5);
            //services.Add(service6);
            //services.Add(service7);
            //services.Add(service8);
            HomeVM homeVM = new HomeVM()
            {
                Services = _dbContext.Services.ToList()
            };
            //_dbContext.Services.Add(service1);
            //_dbContext.Services.Add(service2);
            //_dbContext.Services.Add(service3);
            //_dbContext.Services.Add(service4);
            //_dbContext.Services.Add(service5);
            //_dbContext.Services.Add(service6);
            //_dbContext.Services.Add(service7);
            //_dbContext.Services.Add(service8);
            //_dbContext.SaveChanges();
            return View(homeVM);
        }
    }
}
