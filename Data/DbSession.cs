using Microsoft.Data.Sqlite;
using System.Data;

namespace MacorattiC_EssencialAula1.Data
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }
        public DbSession(IConfiguration configuration)
        {
            Connection = new SqliteConnection(configuration.GetConnectionString("DefaultConnection"));
            Connection.Open();

            var command = Connection.CreateCommand();

            command.CommandText = @"
            create table if not exists tarefas(
                Id integer primary key autoincrement,
                Descricao text not null,
                IsCompleta integer not null default 0
            );";
            command.ExecuteNonQuery();
        }
        public void Dispose() => Connection?.Dispose();
    }
}
