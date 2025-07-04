using System.ComponentModel.DataAnnotations;

namespace crud_pra_impressionar_balta.Models;

public class Student
{
    [Key]
    [Display(Name = "Id")]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome não deve ser maior que 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter pelo menos caracteres")]
    [Display(Name = "Nome Completo")]
    public string Name { get; set; } =  string.Empty;
    
    [Required(ErrorMessage = "Informe o email")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [Display(Name = "E-mail")]
    public string Email { get; set; } = string.Empty;
    
    public List<Subscription> Subscriptions { get; set; } = new();
}