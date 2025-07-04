using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace crud_pra_impressionar_balta.Models;

public class Subscription
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o título da assinatura")]
    [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve conter pelo menos 5 caracteres")]
    [DisplayName("Título")]
    public string Title { get; set; } = string.Empty;
    
    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Início")]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }
    
    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno inválido")]
    public int StudentId { get; set; }
    
    public Student? Student { get; set; }
    
}