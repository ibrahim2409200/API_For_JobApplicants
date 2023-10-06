using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_For_JobApplicants.Models
{
    public class Applicants
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public int ContactNo { get; set; }

        public string ProfessionTitle { get; set; }

        [ForeignKey("Jobs")]
        public int JobID { get; set; }

        //public Jobs Jobs { get; set; }
    }
}
