using System.ComponentModel.DataAnnotations;

namespace IKTpe25TARProgemine1.Models
{
    public class FileRecord
    {
        [Key]
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}