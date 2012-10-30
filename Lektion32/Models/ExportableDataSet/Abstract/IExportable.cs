using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion32.Models.ExportableDataSet.Abstract
{
    public interface IExportableSet
    {
        int Count();
        byte[] ExportToPdf();
        string ExportToSQL();
        byte[] ExportToExcel();
        string ExportToText();
        byte[] ExportToChartImage();
        string ExportToCSV();
    }
}
