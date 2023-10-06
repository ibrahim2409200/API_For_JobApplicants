using API_For_JobApplicants.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_For_JobApplicants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ApplicationController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;   
        }

        [HttpGet]
        [Route("GetApplicants")]
        public List<Applicants> GetApplicants()
        {
            return applicationDbContext.Applicants.ToList();
        }

        [HttpPost]
        [Route("AddApplicants")]
        public string AddApplicants(Applicants applicants)
        {
            string response = string.Empty;
            applicationDbContext.Applicants.Add(applicants);
            applicationDbContext.SaveChanges();
            return "Applicant Added";
        }

        [HttpPut]
        [Route("UpdateApplicant")]
        public string UpdateApplicant(Applicants applicants)
        {
            applicationDbContext.Entry(applicants).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            applicationDbContext.SaveChanges();
            return "Applicant Updated";
        }

        [HttpDelete]
        [Route("DeleteApplicants")]
        public string DeleteApplicant(int id)
        {
            Applicants applicants = applicationDbContext.Applicants.Where(x => x.Id == id).FirstOrDefault();
            if(applicants == null)
            {
                return "Not Found";
            }
            applicationDbContext.Applicants.Remove(applicants);
            applicationDbContext.SaveChanges();
            return "USer Deleted";             
        }

        [HttpGet]
        [Route("GetJobs")]
        public List<Jobs> GetJobs()
        {
            return applicationDbContext.Jobs.ToList();
        }

        [HttpPost]
        [Route("AddJobs")]
        public string AddJobs(Jobs jobs)
        {
            string response = string.Empty;
            applicationDbContext.Jobs.Add(jobs);
            applicationDbContext.SaveChanges();
            return "Job Added";
        }

        [HttpGet]
        [Route("GetApplications")]
        public List<Applications> GetApplications()
        {
            return applicationDbContext.Applications.ToList();
        }

        [HttpPost]
        [Route("AddApplications")]
        public string AddApplicationss(Applications applications)
        {
            string response = string.Empty;
            applicationDbContext.Applications.Add(applications);
            applicationDbContext.SaveChanges();
            return "Application Added";
        }
    }
}
