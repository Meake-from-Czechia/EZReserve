namespace EZReserve
{
    public class CsvExporter : IExportable
    {
        public int Export(string path, List<ExportDto> data)
        {
            try
            {
                using var writer = new StreamWriter(path);
                foreach (ExportDto exportable in data)
                {
                    writer.WriteLine(exportable.GetCsvLine());
                }
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