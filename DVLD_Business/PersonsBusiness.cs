using DVLD_Data;
using System.Data;

namespace DVLD_Business
{
    public class PersonsBusiness
    {

        public static DataTable getAllPersons()
        {

            return PersonsData.get();

        }
    }
}
