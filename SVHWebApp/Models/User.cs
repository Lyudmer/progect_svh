
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SVHWebApp.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public virtual int Id { get; set; }
        
      
        [Required(ErrorMessage = "Необходимо указать ФИО")]
        public required string FullName { get; set; }
        [Required(ErrorMessage = "Адрес элетронной почты")]
        [DataType(DataType.EmailAddress)]
        
        public string Email { get; set; }
        [Required(ErrorMessage = "Логин")]
       
        public string Loggin { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Пароль")]
        
        public string Password { get; set; }

    }
}
