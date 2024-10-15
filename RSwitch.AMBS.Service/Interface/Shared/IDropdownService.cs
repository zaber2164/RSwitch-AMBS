using System.Data;

namespace RSwitch.AMBS.Service.Interface.Shared
{
    public interface IDropdownService
    {
        Task<DataTable> GetDropdownData(string tableName, string columnName);
    }
}
