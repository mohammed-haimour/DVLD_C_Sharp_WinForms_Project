using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace DVLD_Data
{
    public class PersonsData
    {

        public static DataTable? getPersonById(int PersonID)
        {
            DataTable dt = new DataTable();

            string query = "SELECT * From People Where PersonID = @PersonID ;";  

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                    }
                    catch (Exception ex)
                    {  
                       Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return (dt.Rows.Count == 0) ? null : dt ;
        }

        public static DataTable getAll()
        {
            DataTable dt = new DataTable();


            string query = "SELECT  *  From People";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

             
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
 
                  
                }
            }
            return dt;
        }


        public static int addPerson(string NationalNo, string FirstName, string SecondName, string ?ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string ?Email, int NationalityCountryID, string ?ImagePath)
        {
            int insertedID = -1;

            string query = "INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName == null ? DBNull.Value : ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email == null ? DBNull.Value : Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath == null ? DBNull.Value : ImagePath);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            insertedID = ID;
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return insertedID;
        }


        public static bool isPersonExistByNationalNumber(string NationalNo)
        {
            bool isFound = false;


            string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isFound = true;
                        }


                    }
                    catch (Exception ex)
                    { 
                       Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isFound;
        }


        public static int deletePersonById(int PersonID)
        {
            string query = "DELETE FROM People  WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        //return "Cannot delete this record as it is referenced by other records. Please delete the related records first.";
                        return -2;
                    }
                    catch (Exception ex)
                    {
                        //return $"An error occurred: {ex.Message}";
                        return -1;
                    }
                }
            }
            return 1;
        }

        public static int updatePersonById(int PersonID, string FirstName, string SecondName, string? ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string? Email, int NationalityCountryID, string? ImagePath)
        {
            int affectedPersonId = -1;

            // Modify the query to return the updated PersonID
            string query = @"
        UPDATE People 
        SET FirstName = @FirstName, 
            SecondName = @SecondName, 
            ThirdName = @ThirdName, 
            LastName = @LastName, 
            DateOfBirth = @DateOfBirth, 
            Gendor = @Gendor, 
            Address = @Address, 
            Phone = @Phone, 
            Email = @Email, 
            NationalityCountryID = @NationalityCountryID, 
            ImagePath = @ImagePath   
        OUTPUT inserted.PersonID
        WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName == null ? DBNull.Value : ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email == null ? DBNull.Value : Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", ImagePath == null ? DBNull.Value : ImagePath);

                    connection.Open();

                    // Execute the query and retrieve the affected PersonID
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        affectedPersonId = Convert.ToInt32(result);
                    }
                }
            }
            return affectedPersonId;
        }

    }
}
