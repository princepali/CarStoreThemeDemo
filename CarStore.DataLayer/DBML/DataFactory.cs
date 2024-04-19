using CarStore.DataLayer.DBML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace Car_store_theme.Data
{
    public class DataFactory : IDataFactory
    {
        static MappingSource _sharedMappingSource = new AttributeMappingSource();
        string _connectionString;

        public DataFactoryDataContext GetDataFactoryDataContext()
        {

            _connectionString = ConfigurationManager.ConnectionStrings["carStoreDBConnectionString"].ConnectionString;
            return new DataFactoryDataContext(_connectionString, _sharedMappingSource);


        }
    }
}