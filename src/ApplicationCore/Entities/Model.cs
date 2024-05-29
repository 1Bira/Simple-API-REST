namespace ApplicationCore.Entities.Unoffitial;

public class Candidato
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? NumeroTelemovel { get; set; }
};

public class Candidatura
{
    public int Id { get; set; }
    public DateTime DataCandidatura { get; set; }

    public Candidato? CandidatoCandidatura { get; set; }
    public Vaga? VagaCandidatura { get; set; }
}

public class Entrevista
{
    public int Id { get; set; }
    public string? Local { get; set; }
    public string? Status { get; set; }
}

public class CV
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public List<string>? Experiencias { get; set; }
    public List<string>? Skill { get; set; }
}