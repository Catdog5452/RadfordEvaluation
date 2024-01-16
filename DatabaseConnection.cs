using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationProject
{
    class DatabaseConnection
    {
        // Connection string
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kayla\Desktop\University\Post University\Radfords\EvaluationProject\Database1.mdf;Integrated Security=True";

        /// <summary>
        /// Returns all members of staff in the database as a list
        /// </summary>
        /// <returns>List of all staff members as Staff objects</returns>
        public List<Staff> getAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM staff";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Staff staff = new Staff(
                                reader.GetInt32(reader.GetOrdinal("StaffID")),
                                reader.GetString(reader.GetOrdinal("StaffType")),
                                reader.IsDBNull(reader.GetOrdinal("Title")) ? null : reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("FirstName")),
                                reader.GetString(reader.GetOrdinal("LastName")),
                                reader.IsDBNull(reader.GetOrdinal("MiddleInitial")) ? (char?)null : reader.GetString(reader.GetOrdinal("MiddleInitial"))[0],
                                reader.IsDBNull(reader.GetOrdinal("HomePhone")) ? null : reader.GetString(reader.GetOrdinal("HomePhone")),
                                reader.IsDBNull(reader.GetOrdinal("CellPhone")) ? null : reader.GetString(reader.GetOrdinal("CellPhone")),
                                reader.IsDBNull(reader.GetOrdinal("OfficeExtension")) ? null : reader.GetString(reader.GetOrdinal("OfficeExtension")),
                                reader.IsDBNull(reader.GetOrdinal("IRDNumber")) ? null : reader.GetString(reader.GetOrdinal("IRDNumber")),
                                reader.GetString(reader.GetOrdinal("Status")),
                                reader.IsDBNull(reader.GetOrdinal("ManagerID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ManagerID"))
                            );
                            staffList.Add(staff);
                        }
                    }
                }
            }

            return staffList;
        }

        /// <summary>
        /// Delete a staff member from the database
        /// </summary>
        /// <param name="staffID">Staff ID of the staff member that needs deleting</param>
        /// <returns></returns>
        public string DeleteStaffMember(int staffID)
        {
            string successMessage;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM staff WHERE StaffID = @StaffID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        successMessage = "Staff member deleted successfully.";
                    }
                    else
                    {
                        successMessage = "Failed to delete staff member.";
                    }
                }

                connection.Close();

                return successMessage;
            }
        }

        /// <summary>
        /// Add a person to the database
        /// </summary>
        /// <param name="newStaff">Object which contains all staff information to be added</param>
        /// <returns></returns>
        public string AddStaffMember(Staff newStaff)
        {
            string successMessage;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO staff
                              (StaffType, Title, FirstName, LastName, MiddleInitial,
                               HomePhone, CellPhone, OfficeExtension, IRDNumber, Status, ManagerID)
                              VALUES
                              (@StaffType, @Title, @FirstName, @LastName, @MiddleInitial,
                               @HomePhone, @CellPhone, @OfficeExtension, @IRDNumber, @Status, @ManagerID)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffType", newStaff.StaffType);
                    cmd.Parameters.AddWithValue("@Title", newStaff.Title);
                    cmd.Parameters.AddWithValue("@FirstName", newStaff.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", newStaff.LastName);
                    cmd.Parameters.AddWithValue("@MiddleInitial", (object)newStaff.MiddleInitial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HomePhone", newStaff.HomePhone);
                    cmd.Parameters.AddWithValue("@CellPhone", newStaff.CellPhone);
                    cmd.Parameters.AddWithValue("@OfficeExtension", newStaff.OfficeExtension);
                    cmd.Parameters.AddWithValue("@IRDNumber", newStaff.IRDNumber);
                    cmd.Parameters.AddWithValue("@Status", newStaff.Status);
                    cmd.Parameters.AddWithValue("@ManagerID", (object)newStaff.ManagerID ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        successMessage = ("Staff member added to the database successfully.");
                    }
                    else
                    {
                        successMessage = ("Failed to add staff member to the database.");
                    }
                }

                connection.Close();
                return successMessage;
            }
        }

        /// <summary>
        /// Update a staff member
        /// </summary>
        /// <param name="updatedStaff"></param>
        /// <returns></returns>
        public string UpdateStaffMember(Staff updatedStaff)
        {
            string successMessage;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"UPDATE staff
                              SET StaffType = @StaffType, Title = @Title, FirstName = @FirstName,
                                  LastName = @LastName, MiddleInitial = @MiddleInitial,
                                  HomePhone = @HomePhone, CellPhone = @CellPhone,
                                  OfficeExtension = @OfficeExtension, IRDNumber = @IRDNumber,
                                  Status = @Status, ManagerID = @ManagerID
                              WHERE StaffID = @StaffID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@StaffID", updatedStaff.StaffID); 
                    cmd.Parameters.AddWithValue("@StaffType", updatedStaff.StaffType);
                    cmd.Parameters.AddWithValue("@Title", updatedStaff.Title);
                    cmd.Parameters.AddWithValue("@FirstName", updatedStaff.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", updatedStaff.LastName);
                    cmd.Parameters.AddWithValue("@MiddleInitial", (object)updatedStaff.MiddleInitial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HomePhone", updatedStaff.HomePhone);
                    cmd.Parameters.AddWithValue("@CellPhone", updatedStaff.CellPhone);
                    cmd.Parameters.AddWithValue("@OfficeExtension", updatedStaff.OfficeExtension);
                    cmd.Parameters.AddWithValue("@IRDNumber", updatedStaff.IRDNumber);
                    cmd.Parameters.AddWithValue("@Status", updatedStaff.Status);
                    cmd.Parameters.AddWithValue("@ManagerID", (object)updatedStaff.ManagerID ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        successMessage = ("Staff member updated in the database successfully.");
                    }
                    else
                    {
                        successMessage = ("Failed to update staff member in the database.");
                    }
                }

                connection.Close();
                return successMessage;
            }
        }

    }
}
