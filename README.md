# API de Tarefas com Dapper

Minha primeira API REST em C#/.NET 8 feita durante os estudos do curso C# Essencial do Macoratti.

## 🎯 Objetivo
Aprender os fundamentos de ASP.NET Core Minimal API, Dapper e SQL Server criando um CRUD de tarefas.

## 🛠️ Tech Stack
- .NET 6
- ASP.NET Core Minimal API
- Dapper
- SQLite

## 🚀 Como rodar o projeto
1. Clone o repositório
2. Crie um banco no SQLite chamado `tarefas`
3. Rode o script `scripts/tabela_tarefas.sql` para criar a tabela
4. Ajuste a `ConnectionString` no `appsettings.json`
5. Execute: `dotnet run`

## 📚 O que aprendi
- Criar endpoints GET, POST, PUT, DELETE
- Conectar C# com SQL Server usando Dapper
- Injeção de dependência nativa do .NET
- Estrutura de projeto API

## 📈 Roadmap de evolução
- [ ] Migrar de Dapper para Entity Framework Core
- [ ] Adicionar FluentValidation
- [ ] Implementar Autenticação JWT
- [ ] Criar testes com xUnit
- [ ] Dockerizar a aplicação

---
Estudando backend .NET do zero ao Pleno em 6 meses.
