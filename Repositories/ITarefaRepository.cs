using MacorattiC_EssencialAula1.Data;

namespace MacorattiC_EssencialAula1.Repositories
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasAsync();
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task<TarefaContainer> GetTarefasEContadorAsync();
        Task<int> SaveAsync(Tarefa tarefa);
        Task<int> UpdateTarefaStatusAsync(Tarefa tarefa);
        Task<int> DeleteAsync(int id);
    }
}
