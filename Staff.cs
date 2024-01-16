using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationProject
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char? MiddleInitial { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OfficeExtension { get; set; }
        public string IRDNumber { get; set; }
        public string Status { get; set; }
        public int? ManagerID { get; set; }

        public Staff(int staffID, string staffType, string title, string firstName, string lastName,
                 char? middleInitial, string homePhone, string cellPhone, string officeExtension,
                 string irdNumber, string status, int? managerID)
        {
            StaffID = staffID;
            StaffType = staffType;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleInitial;
            HomePhone = homePhone;
            CellPhone = cellPhone;
            OfficeExtension = officeExtension;
            IRDNumber = irdNumber;
            Status = status;
            ManagerID = managerID;
        }

        public Staff(string staffType, string title, string firstName, string lastName,
                 char? middleInitial, string homePhone, string cellPhone, string officeExtension,
                 string irdNumber, string status, int? managerID)
        {
            StaffType = staffType;
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleInitial;
            HomePhone = homePhone;
            CellPhone = cellPhone;
            OfficeExtension = officeExtension;
            IRDNumber = irdNumber;
            Status = status;
            ManagerID = managerID;
        }

        public string GetStaffInformationString()
        {
            return $"StaffID: {StaffID}\n" +
                   $"StaffType: {StaffType}\n" +
                   $"Title: {Title}\n" +
                   $"FirstName: {FirstName}\n" +
                   $"LastName: {LastName}\n" +
                   $"MiddleInitial: {MiddleInitial?.ToString() ?? "N/A"}\n" +
                   $"HomePhone: {HomePhone}\n" +
                   $"CellPhone: {CellPhone}\n" +
                   $"OfficeExtension: {OfficeExtension}\n" +
                   $"IRDNumber: {IRDNumber}\n" +
                   $"Status: {Status}\n" +
                   $"ManagerID: {ManagerID?.ToString() ?? "N/A"}";
        }

        public string GetDisplayText()
        {
            return $"{StaffID} {FirstName} {LastName}";
        }
    }
}
