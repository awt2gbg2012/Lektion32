using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion32.Models.ExportableDataSet.Abstract;

namespace Lektion32.Models.ExportableDataSet
{
    public class UserStatisticsSet : IExportableSet
    {
        private List<object> _userStatistics = new List<object>();

        public int Count() { return _userStatistics.Count; }

        public byte[] ExportToExcel()
        {
            byte[] generatedExcel = new byte[200000];

            // Code to generate Excel here

            return generatedExcel;
        }

        public byte[] ExportToPdf() { throw new NotImplementedException(); }
        public string ExportToSQL() { throw new NotImplementedException(); }
        public string ExportToText() { throw new NotImplementedException(); }
        public byte[] ExportToChartImage() { throw new NotImplementedException(); }
        public string ExportToCSV() { throw new NotImplementedException(); }
    }
}