using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace ProjectLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"C:\Users\damia\OneDrive\Pulpit\ProjektLINQ\ProjectLINQ\ProjectLINQ\HumanResources.csv";
            var humanResources = LoadHumanResources(csvPath);
            //Display(humanResources);
            //GetData(humanResources);
            //ProjectData(humanResources);
            //Divide(humanResources);
            //OrderData(humanResources);
            DataSetOperation(humanResources);

            
            Console.ReadLine();
        }
        static List<HumanResources> LoadHumanResources(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<HumanResourcesMap>();
                var records = csv.GetRecords<HumanResources>().ToList();
                return records;
            }
        }
        static void Display(IEnumerable<HumanResources> humanResources)
        {
            foreach (var humanResource in humanResources)
            {
                Console.WriteLine(humanResource);
            }
        }
        static void Display(HumanResources humanResources)
        {
            Console.WriteLine(humanResources);
        }
        static void GetData(IEnumerable<HumanResources> humanResources)
        {
            var HighSickLeaveHours = humanResources.Where(human => human.SickLeaveHours > 50 && human.CurrentFlag >0);
            Display(HighSickLeaveHours);
        }
        static void ProjectData(IEnumerable<HumanResources> humanResources)
        {
            var HighSickLeaveHours = humanResources.Where(human =>human.SickLeaveHours > 50 && human.CurrentFlag >0);
            var HighSickLeaveHoursLoginID = HighSickLeaveHours.Select(human => human.LoginID);
            var dtos = HighSickLeaveHours.Select(human => new HumanResourcesDto()
            {
                LoginID = human.LoginID,
                SickLeaveHours = human.SickLeaveHours
            });
            foreach(var dto in dtos)
            {
                Console.WriteLine($"{dto.LoginID}: {dto.SickLeaveHours}");
            }    
        }
        static void Divide(IEnumerable<HumanResources> humanResources)
        {
            var HighSickLeaveHours = humanResources.Where(human =>human.SickLeaveHours > 50 && human.CurrentFlag >0);
            var FirstHighSickLeaveHours = HighSickLeaveHours.Take(5);
            Display(FirstHighSickLeaveHours);
        }
        static void OrderData(IEnumerable<HumanResources> humanResources)
        {
            var HighSickLeaveHours = humanResources.Where(human => human.SickLeaveHours > 50 && human.CurrentFlag > 0);
            var sortedResults = HighSickLeaveHours
                .OrderByDescending(human => human.LoginID)
                .ThenByDescending(human => human.JobTitle)
                .Take(5);
            Display(sortedResults);
        }
        static void DataSetOperation(IEnumerable<HumanResources> humanResources)
        {
            var OneCurrentFlagJobTitle = humanResources.Where(human => human.CurrentFlag == 1)
                .Select(human => human.JobTitle).Distinct();
            Console.WriteLine($"OneCurretntFlagJobTitle: {string.Join(",\n", OneCurrentFlagJobTitle)}");

        }
    }
}
