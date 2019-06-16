using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationUsefulHours.Helpers
{
    public class CreateExcel
    {
        public static void ExportarExcel<T>(IEnumerable<T> data, string name, string rutaArchivo)
        {
            using (var package = new ExcelPackage())
            {
                var workbook = package.Workbook;
                var workSheet = workbook.Worksheets.Add("Datos");
                workSheet.Cells[1, 1].LoadFromCollection(data, true);
                string nombreArchivo = GenerateNameFile(name);
                package.SaveAs(new System.IO.FileInfo(string.Format("{0}{1}", rutaArchivo, nombreArchivo)));
            }
        }

        public static void ExportarExcel(DataTable dt, string name, string rutaArchivo)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Datos");
                ws.Cells["A1"].LoadFromDataTable(dt, true);
                string nombreArchivo = GenerateNameFile(name);
                package.SaveAs(new System.IO.FileInfo(string.Format("{0}{1}", rutaArchivo, nombreArchivo)));
            }
        }

        private static string GenerateNameFile(string name)
        {
            return string.Format("{0}_{1}.{2}", name, DateTime.Now.ToString("yyyyMMddhhmmss").ToString(), "xlsx");
        }
    }
}