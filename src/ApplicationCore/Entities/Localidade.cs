namespace ApplicationCore.Entities;

public class Localidade
{
    public int Id { get; set; }
    public string? Endereco { get; set; }
    public string? Cidade { get; set; }
    public string? Pais { get; set; }
    public string? CodigoPostal { get; set; }
}