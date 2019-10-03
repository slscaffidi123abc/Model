using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesID.Pages
{
    public class IndexModel : PageModel

    {
        //Instatiate your list of lists (arrays)
        public List<EmployeesID> MyEmployees { get; set; } = new List<Employees>();

        public string MainTitle { get; set; }
        public string[] Employees1 { get; set; }

       
        public void OnGet()
        {
            //place lists into your lists
            MyEmployees.Add(new Employees
            {
                Employees = 22, 223, 33, 331,
                SLT = "don", "stan", "bill",
                DeptOwner = "mike", "merv", "mel", "linda",
                HRDept = 67, 54, 71, 54,
            });
            MyEmployees.Add(new Employees
                Employees = 22, 223, 33, 331,
                SLT = "don", "stan", "bill",
                DeptOwner = "mike", "merv", "mel", "linda",
                HRDept = 67, 54, 71, 54,
            });
                Employees = 22, 223, 33, 331,
                SLT = "don", "stan", "bill",
                DeptOwner = "mike", "merv", "mel", "linda",
                HRDept = 67, 54, 71, 54,
            });
    Employees = 22, 223, 33, 331,
                SLT = "don", "stan", "bill",
                DeptOwner = "mike", "merv", "mel", "linda",
                HRDept = 67, 54, 71, 54,
            });
                
        Main.Title = " Employee Forecast";
        Employees1 = new string[] {"don","stan","merv","bill"};
        
    

