using MBSA_Dev_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSA_Dev_Test.DAL
{
    public interface IProjectsRepository
    {
        IEnumerable<Project> GetProjects();
    }
}
