namespace ApplicationCore.Entities;

public class Vaga
{
    public int Id { get; set; }
    public string? TItulo { get; set; }
    public string? Descricao { get; set; }
    public string? Requisitos { get; set; }
    public DateTime DataCriacao { get; set; }

    public Empresa? EmpresaVaga { get; set; }
}