using CarStore.DataLayer.DBML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store_theme.Data
{
    public interface IDataFactory
    {
        DataFactoryDataContext GetDataFactoryDataContext();
    }
}
