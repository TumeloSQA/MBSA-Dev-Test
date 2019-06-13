using MBSA_Dev_Test.DbContexts;
using MBSA_Dev_Test.Models;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSA_Dev_Test.DAL
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly MBSADbContext context;

        public ProjectsRepository(MBSADbContext _context)
        {
            context = _context;
        }

        public IEnumerable<Project> GetProjects()
        {
            var total = context.Projects.ToList().Count();
            var pageSize = 10;

            var page = 1;

            var skip = pageSize * (page - 1);

            var canPage = skip < total;

            return context.Projects.ToList()
                         .Skip(skip)
                         .Take(pageSize)
                         .ToArray();
        }

    }
}
