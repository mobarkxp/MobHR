using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entities
{
    public class Job
    {
        public int Id { get; set; }
        [Required,MaxLength(100),MinLength(4)]
        public string? Name { get; set; }
        public Guid DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
        public int AvilableNumber { get; set; }
        public DateTime CreateDate { get; set; } = new DateTime();
        public Boolean JobSataus { get; set; }
    }
}
