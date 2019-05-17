using LunaEpi.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunaEpi.Models.ViewModels
{
    public class EmployeeBlockViewModel
    {
        public IEnumerable<EmployeeBlock> Employees { get; set; }
    }
}