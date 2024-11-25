using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace EZReserve
{
    public class ExcelExporter : IExportable
    {
        public int Export(string fileName, List<ExportDto> exportables)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using var package = new ExcelPackage(new FileInfo(fileName));
                var worksheet = package.Workbook.Worksheets.Add("Report");
                worksheet.Cells["A1"].LoadFromCollection(exportables, c =>
                    {
                        c.PrintHeaders = true;
                    });
                worksheet.Cells[2, 7, worksheet.Dimension.End.Row, 8].Style.Numberformat.Format = "dd.MM.yyyy HH:mm";
                var headerCells = worksheet.Cells["A1:H1"];
                headerCells.Style.Font.Bold = true;
                headerCells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                headerCells.Style.Fill.BackgroundColor.SetColor(Color.Black);
                headerCells.Style.Font.Color.SetColor(Color.White);
                package.Save();
                worksheet.Cells.AutoFitColumns();
                return 0;
            }
            catch (Exception e)
            {
                File.WriteAllLines("error.log", new string[] { e.Message, e.StackTrace });
                return 1;
            }

        }
    }
}