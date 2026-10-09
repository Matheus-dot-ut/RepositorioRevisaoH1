using System.ComponentModel.DataAnnotations;

public class Cadastro
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
    [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
    public string Nome { get; set; }


    [Required(ErrorMessage = "O cpf e obrigatorio")]
    [MaxLength(11, ErrorMessage = "O cpf deve ter no máximo 11 caracteres")]
    public string Cpf { get; set; }


    [Required(ErrorMessage = "O código é obrigatório")]
    [MaxLength(50, ErrorMessage = "O título do eleitor deve ter no máximo 50 caracteres")]
    public string TituloEleitor { get; set; }


    [Required(ErrorMessage = "A UF é obrigatória, sendo no estilo MG,SP,RJ")]
    [MaxLength(2, ErrorMessage = "A descrição deve ter no máximo 2 caracteres, estando como MG,RJ")]
    [UfValidation(ErrorMessage ="O UF deve ter somente 2 caracateres")]
    public string UF { get; set; }

    [Required(ErrorMessage = "O eleitor não foi encontrado e que,por isso, o resultado não pode ser registrado.")]
    [Range(1, 2, ErrorMessage = "O numero do turno pode ser 1 ou 2")]
    [MaxLength(1, ErrorMessage = "O numero de turno deve ter no somente 1 numero")]
    public int NumeroTurno { get; set; }

    [Required(ErrorMessage = "A Descricao de Justificativa e obrigatoria")]
    [MaxLength(500, ErrorMessage = "O numero de caracteres não pode ser maior que 500.")]
    public string DescricaoJustificativa { get; set; }



}