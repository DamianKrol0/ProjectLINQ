using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ProjectLINQ
{
    internal class HumanResourcesMap : ClassMap<HumanResources>
    {
        public HumanResourcesMap()
        {
            Map(m=>m.BusinessEntityID).Name(nameof(HumanResources.BusinessEntityID));
            Map(m=>m.NationalIDNumber).Name(nameof(HumanResources.NationalIDNumber));
            Map(m=>m.LoginID).Name(nameof(HumanResources.LoginID));
            Map(m=>m.OrganizationNode).Name(nameof(HumanResources.OrganizationNode));
            Map(m=>m.OrganizationLevel).Name(nameof(HumanResources.OrganizationLevel));
            Map(m=>m.JobTitle).Name(nameof(HumanResources.JobTitle));
            Map(m=>m.BirthDate).Name(nameof(HumanResources.BirthDate));
            Map(m=>m.MaritalStatus).Name(nameof(HumanResources.MaritalStatus));
            Map(m=>m.Gender).Name(nameof(HumanResources.Gender));
            Map(m=>m.HireDate).Name(nameof(HumanResources.HireDate));
            Map(m=>m.SalariedFlag).Name(nameof(HumanResources.SalariedFlag));
            Map(m=>m.VacationHours).Name(nameof(HumanResources.VacationHours));
            Map(m=>m.SickLeaveHours).Name(nameof(HumanResources.SickLeaveHours));
            Map(m=>m.CurrentFlag).Name(nameof(HumanResources.CurrentFlag));
            Map(m=>m.rowguid).Name(nameof(HumanResources.rowguid));
            
        }
        
    }
}
