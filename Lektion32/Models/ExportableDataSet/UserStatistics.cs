using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion32.Models.ExportableDataSet.Abstract;

namespace Lektion32.Models.ExportableDataSet
{
    public class UserStatisticsSet : IStatisticsSet, IExcelExportable
    {
        private List<object> _userStatistics = new List<object>();

        public int Count() { return _userStatistics.Count; }

        public byte[] ExportToExcel()
        {
            byte[] generatedExcel = new byte[200000];

            // Code to generate Excel here

            return generatedExcel;
        }
    }
}