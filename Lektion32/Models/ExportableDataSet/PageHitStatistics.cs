using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion32.Models.ExportableDataSet.Abstract;

namespace Lektion32.Models.ExportableDataSet
{
    public class PageHitStatisticsSet : IExportableSet
    {
        private List<object> _pageHitStatistics = new List<object>();

        public int Count() { return _pageHitStatistics.Count; }

        public byte[] ExportToPdf()
        {
            byte[] generatedPDF = new byte[200000];

            // Code to generate PDF here

            return generatedPDF;
        }
        public byte[] ExportToChartImage() 
        {
            byte[] generatedImage = new byte[200000];

            // Code to generate Image here

            return generatedImage;
        }

        public string ExportToSQL() { throw new NotImplementedException(); }
        public byte[] ExportToExcel() { throw new NotImplementedException(); }
        public string ExportToText() { throw new NotImplementedException(); }
        public string ExportToCSV() { throw new NotImplementedException(); }
    }
}