using DVLD_Data;
using System.Data;

namespace DVLD_Business
{

    public enum GendorEnum : short
    {
        Male=0,Female=1
    }

    public class PersonsBusiness
    {

        public static DataTable getAllPersons()
        {

            return PersonsData.get();

        }

        public static bool isPersonExistByNationalNumber(string NationalNo) 
        { 
            
            return PersonsData.isPersonExistByNationalNumber(NationalNo);

        }

        public static int addPerson(PersonModel newPerson) {


            byte gendor = (byte)((newPerson.PersonGendor == GendorEnum.Male) ? 1 : 0);
            return PersonsData.addPerson(newPerson.NationalId , newPerson.FirstName , newPerson.SecondName
                ,newPerson.ThirdName , newPerson.LastName , newPerson.DateOfBirth , gendor
                ,newPerson.Address  , newPerson.PhoneNumber , newPerson.Email , newPerson.NationalityCountryId , newPerson.ImagePath ) ;

        }
            
            
    }


    public class PersonModel { 
        
        public short PersonId { set; get; }
        public string NationalId { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public GendorEnum PersonGendor { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ImagePath { set; get; }
        public int NationalityCountryId { set; get; }

        public PersonModel(string nationalId  ,string firstName, string secondName , string thirdName ,
            string lastName , DateTime dateOfBirth , GendorEnum gendor , string phoneNumber ,
            string email , string imagePath ,string address , int nationalityCountryId) { 
            
            PersonId = -1;
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
    }
}
