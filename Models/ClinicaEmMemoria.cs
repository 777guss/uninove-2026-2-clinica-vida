namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static readonly List<Especialidade> Especialidades = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Prevenção, diagnóstico e tratamento das doenças do coração." },
        new Especialidade { Id = 2, Nome = "Dermatologia", Descricao = "Cuidados, diagnóstico e tratamento da pele, cabelos e unhas." },
        new Especialidade { Id = 3, Nome = "Ortopedia", Descricao = "Diagnóstico e tratamento de problemas do sistema musculoesquelético." },
        new Especialidade { Id = 4, Nome = "Pediatria", Descricao = "Acompanhamento da saúde de crianças e adolescentes." }
    };

    public static readonly List<Medico> Medicos = new()
    {
        new Medico { Id = 1, Nome = "Ana Beatriz Souza", Crm = "CRM-SP 112233", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Bruno Almeida", Crm = "CRM-SP 223344", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Carlos Eduardo Lima", Crm = "CRM-SP 334455", EspecialidadeId = 3 },
        new Medico { Id = 4, Nome = "Fernanda Costa", Crm = "CRM-SP 445566", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Marcos Oliveira", Crm = "CRM-SP 556677", EspecialidadeId = 1 },
        new Medico { Id = 6, Nome = "Renata Martins", Crm = "CRM-SP 667788", EspecialidadeId = 3 }
    };

    static ClinicaEmMemoria()
    {
        foreach (var medico in Medicos)
        {
            medico.Especialidade = Especialidades.First(e => e.Id == medico.EspecialidadeId);
        }
    }
}
