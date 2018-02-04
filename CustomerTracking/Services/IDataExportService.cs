using CustomerTracking.NonRelationalEntities;
using CustomerTracking.ViewModels;

namespace CustomerTracking.Services
{
    public interface IDataExportService
    {
        ServiceResponse ExportData(CustomerViewModel customer);
        //test

    }
}
