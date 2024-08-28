using DVLD_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class CountryBusiness
    {


        public static DataTable getAllCountries()
        {

            return CountryData.get();

        }

    }
}
