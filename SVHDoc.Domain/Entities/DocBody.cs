using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SVHDB.Entities
{
    public class DocBody
    {
        [Key, Column("DocId")]
        [Required]
        public int Id { get; set; }

        [Key,Column("IdMd5"), MaxLength(32)]
        [Required]
        public string Idmd5 { get; set; }

        [Key,Column("IdSha256"), MaxLength(64)]
        [Required]
        public string IdSha256 { get; set; }

        [Column("Body")]
        [Required]
        public string Body { get; set; }
    }
}
