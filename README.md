# Clínica Vida+ — Atividade IV

Implementação do laboratório de estruturas de controle e coleções em C# com ASP.NET Core MVC e LINQ.

## Requisitos da atividade atendidos

- `Models/Especialidade.cs` e `Models/Medico.cs` no namespace `ClinicaVida.Web.Models`.
- `Models/ClinicaEmMemoria.cs` com 4 especialidades e 6 médicos.
- `MedicosController` com `Index` usando `Where` para filtro e `OrderBy` para ordem alfabética.
- `MedicosController` com `Details` e retorno `404` quando o médico não existe.
- Views `Index` e `Details` tipadas com `@model`.
- Tela de especialidades com contagem por especialidade usando `Dictionary<int,int>`.
- Filtro funcionando por query string: `/Medicos?especialidade=1`.
- `/Medicos/Details/999` retorna 404.

## Como executar

No terminal, entre na pasta `ClinicaVida.Web` e execute:

```bash
dotnet restore
dotnet run
```

Depois teste:

- `/Medicos`
- `/Medicos?especialidade=1`
- `/Medicos/Details/999`
- `/Especialidades`

## Branch da atividade

No repositório Git, crie a branch:

```bash
git checkout -b feature/medicos-em-memoria
git add .
git commit -m "feat: adiciona medicos em memoria com LINQ"
git push -u origin feature/medicos-em-memoria
```
