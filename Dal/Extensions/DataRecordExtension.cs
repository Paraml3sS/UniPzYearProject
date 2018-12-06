using System;
using System.Data;

namespace Dal.Extensions
{
    public static class DataRecordExtension
    {
        public static bool HasColumn(this IDataRecord dataReader , string columnName)
        {
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                if (dataReader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
