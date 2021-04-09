namespace JsonToCSV.Models
{
    public class ForExport // สามารถเพิ่มตัวแปรที่ต้องการ
    {
        public string _id { get; set; }
        public string Status { get; set; }

        public string REG { get; set; }
        public string CWT { get; set; }
        public string AMP { get; set; }
        public string TAM { get; set; }
        public int? RicePlant { get; set; }
    }
}