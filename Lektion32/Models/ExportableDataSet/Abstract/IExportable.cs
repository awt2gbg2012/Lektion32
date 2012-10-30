using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion32.Models.ExportableDataSet.Abstract
{
    public interface IStatisticsSet
    {
        int Count();
    }

    public interface IPDFExportable
    {
        byte[] ExportToPdf();
    }

    public interface IExcelExportable
    {
        byte[] ExportToExcel();
    }

    public interface IChartImageExportable
    {
        byte[] ExportToChartImage();
    }
}
