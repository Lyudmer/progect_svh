using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVHDB.Entities
{
    [Table("documents")]
    public class Document
    {
        [Key, Column("docid")]
        public int Id { get; set; }
         
        [Column("pid")]
        public int Pid { get; set; }

        [Column("createdate")]
        public DateTime CreateDate { get; set; }

        [Column("modifydate")]
        public DateTime ModifyDate { get; set; }

        [Column("number"), MaxLength(100)]
        public string? Number { get; set; }

        [Column("modecode"), MaxLength(5)]
        public string? ModeCode { get; set; }

        [Column("sizedoc")]
        
        public int SizeDoc { get; set; }

        [Key, Column("idmd5"), MaxLength(32)]
        
        public string Idmd5 { get; set; }

        [Key, Column("idsha256"), MaxLength(64)]
        
        public string IdSha256 { get; set; }
        [Required]
        public DocBody DocBody { get; set; }
        [Required]
        public  Package Packages { get; set; }

        
    }
}
