using Dapper;
using MacorattiC_EssencialAula1.Data;

namespace MacorattiC_EssencialAula1.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        public DbSession _db;
        public TarefaRepository(DbSession dbSession)
        {
            _db = dbSession;
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"delete from tarefas where id = @id";
                    var resultado = await connection.ExecuteAsync(sql: command, param: new { id });
                    return resultado;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"select * from tarefas where id = @id";
                    var resultado = await connection.QueryFirstOrDefaultAsync<Tarefa>(sql: command, param: new { id });
                    return resultado;
                }
            }
            catch
            {
                throw;
            }

        }

        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"select * from tarefas";
                    var resultado = (await connection.QueryAsync<Tarefa>(sql: command)).ToList();
                    return resultado;
                }
            }
            catch
            {
                throw;
            }

        }

        public async Task<TarefaContainer> GetTarefasEContadorAsync()
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"select count(*) from tarefas;
                                select * from tarefas";
                    var reader = await connection.QueryMultipleAsync(sql: command);

                    return new TarefaContainer
                    {
                        Contador = (await reader.ReadAsync<int>()).FirstOrDefault(),
                        Tarefas = (await reader.ReadAsync<Tarefa>()).ToList(),
                    };

                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<int> SaveAsync(Tarefa tarefa)
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"insert into tarefas(descricao, iscompleta) values(@Descricao, @IsCompleta)";
                    var result = await connection.ExecuteAsync(sql: command, param: tarefa);
                    return result;
                }
            }
            catch { throw; }

        }

        public async Task<int> UpdateTarefaStatusAsync(Tarefa tarefa)
        {
            try
            {
                using (var connection = _db.Connection)
                {
                    var command = @"update tarefas set descricao=@Descricao, iscompleta=@IsCompleta where id = @Id";
                    var resultado = await connection.ExecuteAsync(sql: command, param: tarefa);
                    return resultado;
                }
            }
            catch { throw; }
        }
    }
}
