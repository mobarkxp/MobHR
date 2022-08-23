using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        [MaxLength(50,ErrorMessageResourceType =typeof(Resource.Resource1),ErrorMessageResourceName = "Maxlength")
            ,MinLength(3,ErrorMessageResourceType =typeof(Resource.Resource1),ErrorMessageResourceName ="Minlength")
            ,Required(ErrorMessageResourceType =typeof(Resource.Resource1),ErrorMessageResourceName ="DeptName")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
