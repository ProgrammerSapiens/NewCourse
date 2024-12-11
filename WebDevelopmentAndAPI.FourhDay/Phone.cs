namespace WebDevelopmentAndAPI.FourhDay
{
    public class Data
    {
        public string? Color { get; set; }
        public string? Capacity { get; set; }
        public double? Price { get; set; }
        public string? Generation { get; set; }
        public int? Year { get; set; }
        public string? CPUModel { get; set; }
        public string? HardDiskSize { get; set; }
        public string? CaseSize { get; set; }
        public string? Description { get; set; }
        public double? ScreenSize { get; set; }
    }
    public class Phone
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Data? Data { get; set; }
    }
}
