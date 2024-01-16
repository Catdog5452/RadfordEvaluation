using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationProject
{
    public partial class Form1 : Form
    {
        // Variables
        List<Staff> allStaff;
        bool activeStaffOnly = true;
        DatabaseConnection databaseConnection = new DatabaseConnection();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // This is only needed as my computer using scaling and Visual Studio does not like it
            this.Size = new System.Drawing.Size(1000, 600);
            GetStaff();

        }

        /// <summary>
        /// Get all staff members from the SQL database and add them to a list of Staff objects
        /// </summary>
        private void GetStaff()
        {
            allStaff = databaseConnection.getAllStaff();
            UpdateList();
        }

        /// <summary>
        /// Update the current listview
        /// </summary>
        private void UpdateList()
        {
            List<Staff> filteredStaffMembers = allStaff;

            if (activeStaffOnly)
            {
                filteredStaffMembers = allStaff.Where(s => s.Status == "Active").ToList();
            }

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false; // Optional, set to true if you want to allow multiple selections

            // Add columns
            listView1.Columns.Add("Staff ID", 40);
            listView1.Columns.Add("Staff Type", 80);
            listView1.Columns.Add("Title", 60);
            listView1.Columns.Add("First Name", 80);
            listView1.Columns.Add("Last Name", 80);
            listView1.Columns.Add("Middle Initial", 60);
            listView1.Columns.Add("Home Phone", 80);
            listView1.Columns.Add("Cell Phone", 80);
            listView1.Columns.Add("Office Extension", 60);
            listView1.Columns.Add("IRD Number", 80);
            listView1.Columns.Add("Status", 80);
            listView1.Columns.Add("Manager", 120);

            foreach (Staff staff in filteredStaffMembers)
            {
                ListViewItem item = new ListViewItem(staff.StaffID.ToString());
                item.SubItems.Add(staff.StaffType);
                item.SubItems.Add(staff.Title);
                item.SubItems.Add(staff.FirstName);
                item.SubItems.Add(staff.LastName);
                item.SubItems.Add(staff.MiddleInitial?.ToString() ?? "");
                item.SubItems.Add(staff.HomePhone);
                item.SubItems.Add(staff.CellPhone);
                item.SubItems.Add(staff.OfficeExtension);
                item.SubItems.Add(staff.IRDNumber);
                item.SubItems.Add(staff.Status);

                if (staff.ManagerID.HasValue && staff.StaffType == "Employee")
                {
                    // Find the manager in the list based on ManagerID
                    Staff manager = allStaff.FirstOrDefault(s => s.StaffID == staff.ManagerID.Value);

                    if (manager != null)
                    {
                        item.SubItems.Add($"{manager.FirstName} {manager.LastName}");
                    }
                    else
                    {
                        item.SubItems.Add(""); // Manager not found
                    }
                }
                else
                {
                    item.SubItems.Add(""); // No manager or not an employee
                }

                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Check for changes on whether all staff should be shown or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                activeStaffOnly = false;
            } 
            else 
            {
                activeStaffOnly = true;
            }

            GetStaff();
        }

        /// <summary>
        /// Delete selected staff member (if one is selected) and update list and database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a staff memeber to delete");
            }
            else
            {
                int staffID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                bool isManager = false;

                for (int i = 0; i < allStaff.Count; i++)
                {
                    if(allStaff[i].ManagerID == staffID)
                    {
                        MessageBox.Show("You cannot delete this staff member until they manage no other employees", "Error: Cannot delete staff member");
                        isManager = true;
                    }
                }

                if (!isManager)
                {

                    string successMessage = databaseConnection.DeleteStaffMember(staffID);
               

                    GetStaff();
                    MessageBox.Show(successMessage);
                }
                
            }
        }

        /// <summary>
        /// Add new staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            GetStaff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a staff memeber to edit");
            }
            else
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                Staff selectedStaff = allStaff.SingleOrDefault(s => s.StaffID == id);
                


                var frm = new Form3(selectedStaff);
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }

            
        }

        private  void ExportDataToCSV()
        {
            List<Staff> staffList = allStaff;

            // Group the staff list by Staff Type
            var groupedByStaffType = staffList.GroupBy(s => s.StaffType);

            foreach (var group in groupedByStaffType)
            {
                string csvFileName = $"{group.Key}_Staff.csv";
                using (StreamWriter writer = new StreamWriter(csvFileName))
                {
                    // Write header to CSV
                    writer.WriteLine("StaffID,StaffType,Title,FirstName,LastName,MiddleInitial,HomePhone,CellPhone,OfficeExtension,IRDNumber,Status,ManagerID");

                    // Write data to CSV
                    foreach (Staff staff in group.OrderBy(s => s.FirstName))
                    {
                        writer.WriteLine($"{staff.StaffID},{staff.StaffType},{staff.Title},{staff.FirstName},{staff.LastName}," +
                            $"{staff.MiddleInitial},{staff.HomePhone},{staff.CellPhone},{staff.OfficeExtension},{staff.IRDNumber},{staff.Status},{staff.ManagerID}");
                    }
                }

                Console.WriteLine($"Exported data for {group.Key} to {csvFileName}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportDataToCSV();
        }
    }
}
