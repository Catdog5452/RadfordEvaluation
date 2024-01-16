using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationProject
{
    public partial class Form3 : Form
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();

        int staffID;

        public Form3(Staff staff)
        {
            InitializeComponent();
            staffID = staff.StaffID;
            PopulateBoxes(staff);
        }

        private void PopulateBoxes(Staff staff)
        {
            // Manager box
            List<Staff> allStaff = databaseConnection.getAllStaff();
            List<Staff> managerStaff = allStaff.Where(s => s.StaffType == "Manager").ToList();

            foreach (Staff manager in managerStaff)
            {
                cbManagers.Items.Add(manager.GetDisplayText());
            }

            if(staff.ManagerID != null)
            {
                Staff manager = allStaff.SingleOrDefault(s => s.StaffID == staff.ManagerID);
                string cbManagerItem = manager.GetDisplayText();
                cbManagers.SelectedItem = cbManagerItem;
            }
            
            // Update the controls with the values from the Staff object
            cbStatus.SelectedItem = staff.Status;
            txtIRD.Text = staff.IRDNumber;
            txtExtension.Text = staff.OfficeExtension;
            txtCell.Text = staff.CellPhone;
            txtHome.Text = staff.HomePhone;
            txtMiddleChar.Text = staff.MiddleInitial?.ToString() ?? "";
            txtLastName.Text = staff.LastName;
            txtFirstName.Text = staff.FirstName;
            cbStaffType.SelectedItem = staff.StaffType;
            txtTitle.Text = staff.Title;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ValidateForm();

            int? managerID = null;

            if (cbManagers.SelectedItem != null)
            {
                // Split the string based on the space character
                string[] parts = cbManagers.SelectedItem.ToString().Split(' ');

                // Extract the first part (the number)
                string numberString = parts[0];

                if (int.TryParse(numberString, out int result))
                {
                    // Conversion successful, set managerID to the result
                    managerID = result;
                }
            }

            Staff staff = new Staff(
                staffID: staffID,
                title: txtTitle.Text,
                staffType: cbStaffType.SelectedItem.ToString(),
                firstName: txtFirstName.Text,
                lastName: txtLastName.Text,
                middleInitial: string.IsNullOrEmpty(txtMiddleChar.Text) ? (char?)null : txtMiddleChar.Text[0],
                homePhone: txtHome.Text,
                cellPhone: txtCell.Text,
                officeExtension: txtExtension.Text,
                irdNumber: txtIRD.Text,
                status: cbStatus.SelectedItem.ToString(),
                managerID: managerID // Assuming managers are listed in cbManagers
            );

            databaseConnection.UpdateStaffMember(staff);
            this.Close();
        }

        private void ValidateForm()
        {
            if (cbStaffType.Text == null)
            {
                MessageBox.Show("Cannot add staff member. Please review form and try again.", "Error: Form incorrectly filled out");
                return;
            }

            if (txtFirstName.Text == null)
            {
                MessageBox.Show("Cannot add staff member. Please review form and try again.", "Error: Form incorrectly filled out");
                return;
            }

            if (txtLastName.Text == null)
            {
                MessageBox.Show("Cannot add staff member. Please review form and try again.", "Error: Form incorrectly filled out");
                return;
            }

            if (txtMiddleChar.Text.Length > 1)
            {
                MessageBox.Show("Cannot add staff member. Please review form and try again.", "Error: Form incorrectly filled out");
                return;
            }

            if (cbStatus.Text == null)
            {
                MessageBox.Show("Cannot add staff member. Please review form and try again.", "Error: Form incorrectly filled out");
                return;
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
