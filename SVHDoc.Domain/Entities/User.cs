using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SVHDB.Entities
{
    [Table("users")]
    public class User
    {

        [Key, Column("userid")]
        public int Id { get; set; }

        [Column("login"), MaxLength(50)]
        public string Login { get; set; }

        [Column("password"), MaxLength(100)]
        public string Password { get; set; }

        [Column("fullname"), MaxLength(200)]
        public string FullName { get; set; }

        [Column("email"), MaxLength(100)]
        public string Email { get; set; }

        [Column("createdate")]
        public DateTime CreateDate { get; set; }

        [Column("modifydate")]
        public DateTime ModifyDate { get; set; }
        public ICollection<Package> Packages { get; set; }
       
    }
}
