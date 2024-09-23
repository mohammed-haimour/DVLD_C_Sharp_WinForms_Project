using DVLD_Data;
using DVLD_Presentation.Global;
using System.Data;

namespace DVLD_Business
{

    public enum GendorEnum : short
    {
        Male=0,Female=1
    }

    public class PersonsBusiness
    {
        public static PersonModel? getPersonById(int personId) {
            DataTable? result = PersonsData.getPersonById(personId);
            if (result != null)
            {
                return new PersonModel(result.Rows[0]);
            }
            else
            {
                return null;
            }

        }

        public static DataTable getAll()
        {

            return PersonsData.getAll();

        }

        public static int deletePersonByPersonId(int personId) { 
            
            return PersonsData.deletePersonById(personId);
            
        }

        public static bool isPersonExistByNationalNumber(string NationalNo) 
        { 
            
            return PersonsData.isPersonExistByNationalNumber(NationalNo);

        }

        public static int save(PersonModel person , CrudOprations crudOpration) {
            byte gendor = (byte)((person.PersonGendor == GendorEnum.Male) ? 0 : 1);

            if (crudOpration == CrudOprations.create)
            {
                return PersonsData.addPerson(person.NationalId, person.FirstName, person.SecondName
                    , person.ThirdName, person.LastName, person.DateOfBirth, gendor
                    , person.Address, person.PhoneNumber, person.Email, person.NationalityCountryId, person.ImagePath);
            }
            else if (crudOpration == CrudOprations.update)
            {

                return PersonsData.updatePersonById(person.PersonId, person.FirstName, person.SecondName
                    , person.ThirdName, person.LastName, person.DateOfBirth, gendor
                    , person.Address, person.PhoneNumber, person.Email, person.NationalityCountryId, person.ImagePath);
            }
            else {
                return -1;
            }
        }
            
            
    }


    public class PersonModel { 
        
        public short PersonId { set; get; }
        public string NationalId { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string? ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public GendorEnum PersonGendor { set; get; }
        public string PhoneNumber { set; get; }
        public string ?Email { get; set; }
        public string Address { get; set; }
        public string ? ImagePath { set; get; }
        public int NationalityCountryId { set; get; }

        public PersonModel(short personId,string nationalId  ,string firstName, string secondName , string ? thirdName ,
            string lastName , DateTime dateOfBirth , GendorEnum gendor , string phoneNumber ,
            string? email , string ? imagePath ,string address , int nationalityCountryId) { 
            
            PersonId = personId;
            NationalId = nationalId;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PersonGendor = gendor;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            ImagePath = imagePath;
            NationalityCountryId = nationalityCountryId;
            
        }



        public PersonModel(DataRow row)
        {
            // Assuming column names match the property names
            PersonId = Convert.ToInt16(row["PersonID"]);
            NationalId = row["NationalNo"].ToString()!;
            FirstName = row["FirstName"].ToString()!;
            SecondName = row["SecondName"].ToString()!;
            ThirdName = row["ThirdName"] != DBNull.Value ? row["ThirdName"].ToString() : null;
            LastName = row["LastName"].ToString()!;
            DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            PersonGendor = (GendorEnum)Convert.ToInt16(row["Gendor"]);
            PhoneNumber = row["Phone"].ToString()!;
            Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : null;
            Address = row["Address"].ToString()!;
            ImagePath = row["ImagePath"] != DBNull.Value ? row["ImagePath"].ToString() : null;
            NationalityCountryId = Convert.ToInt32(row["NationalityCountryID"]);
        }
    }
}
