using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDAL
{
    public class CarsDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CarsCollectionBrand { get; set; } = null!;

        public CarsDatabaseSettings(IConfigurationRoot configurationRoot)
        {
            ConnectionString = configurationRoot.GetSection("CarsInheritDatabase")["ConnectionString"];
            DatabaseName = configurationRoot.GetSection("CarsInheritDatabase")["DatabaseName"];
            CarsCollectionBrand = configurationRoot.GetSection("CarsInheritDatabase")["CarsCollectionBrand"];
        }
    }
}
