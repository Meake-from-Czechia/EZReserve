namespace EZReserve
{
    public interface IExportable
    {
        public int Export(string path, List<ExportDto> data);
    }
}