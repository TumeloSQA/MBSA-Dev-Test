using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MBSA_Dev_Test.Models;
using MBSA_Dev_Test.DbContexts;
using MBSA_Dev_Test.DAL;
using Newtonsoft.Json;
using System.Web.Http.Results;

namespace MBSA_Dev_Test.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly MBSADbContext _context;

        private readonly IProjectsRepository _projectsRepository;
        public ProjectsController(IProjectsRepository projectsRepository, MBSADbContext dbContext)
        {
            _projectsRepository = projectsRepository;
            _context = dbContext;
        }

        public JsonResult GetProjects()
        {
            var result = _projectsRepository.GetProjects().ToList().ToAsyncEnumerable();

            return Json(result);
        }

    }

}