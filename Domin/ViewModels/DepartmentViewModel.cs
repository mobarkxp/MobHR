using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.ViewModels
{
    public class DepartmentViewModel
    {
       public List<Department> departments = new List<Department>();
        public Department? newDepartment { get; set; }
    }
}
