using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    public class HumanResources
    {
        public int BusinessEntityID { get; set; }
        public int NationalIDNumber { get; set; } 
        public string LoginID { get; set; }
        public string OrganizationNode { get; set; }    
        public string OrganizationLevel { get; set; }
        public string JobTitle { get; set; }    
        public DateTime BirthDate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public DateTime HireDate { get; set; }    
        public int SalariedFlag { get; set; }
        public int VacationHours { get; set; }   
        public int SickLeaveHours { get; set; }
        public int CurrentFlag { get; set; }
        public string rowguid { get; set; }
        

        public override string ToString()
        {
            return $"{BusinessEntityID,-3} | " +
                $"{NationalIDNumber,-10} | " +
                $"{LoginID,-29} | " +
                $"{OrganizationNode,-10} | " +
                $"{OrganizationLevel,-4} | " +
                $"{JobTitle,-40} | " +
                $"{BirthDate.ToShortDateString() ,-10} | " +
                $"{MaritalStatus,-1} | " +
                $"{Gender,-1} | " +
                $"{HireDate.ToShortDateString(),-10} | " +
                $"{SalariedFlag,-1} | " +
                $"{VacationHours,-2} | " +
                $"{SickLeaveHours,-2} | " +
                $"{CurrentFlag,-1} | " + 
                $"{rowguid,-1}  ";

               
        }

    }
}
