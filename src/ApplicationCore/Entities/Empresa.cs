namespace ApplicationCore.Entities;
public class Empresa
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    public virtual List<Vaga>? Vagas { get; set; }
}