using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_For_JobApplicants.Models
{
    public class Applications
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Applicants")]
        public int ApplicantId { get; set; }

        public DateTime Creationtime { get; set; }
        public string Status { get; set; }

    }
}
