using DocuSign.eSign.Model;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SVHWebApp.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public virtual int Id { get; set; }
        
        [Display(FullName="Введите ФИО")]
        [Required(ErrorMessage = "Необходимо указать ФИО")]
        public required string FullName { get; set; }
        [Required(ErrorMessage = "Адрес элетронной почты")]
        [DataType(DataType.EmailAddress)]
        [Display(Email = "Адрес элетронной почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Логин")]
        [Display(Loggin = "Логин")]
        public string Loggin { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Пароль")]
        [Display(Password = "Пароль")]
        public string Password { get; set; }

    }
}
