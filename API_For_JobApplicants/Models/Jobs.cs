using System.ComponentModel.DataAnnotations;

namespace API_For_JobApplicants.Models
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }

        public string JobTitle { get; set; }
    }
}
