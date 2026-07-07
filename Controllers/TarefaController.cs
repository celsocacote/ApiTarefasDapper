using MacorattiC_EssencialAula1.Data;
using MacorattiC_EssencialAula1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MacorattiC_EssencialAula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaController(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        [HttpGet]
        [Route("tarefas")]
        public async Task<IActionResult> GetTarefasAsync()
        {
            try
            {
                var resultado = await _tarefaRepository.GetTarefasAsync();
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpGet]
        [Route("tarefa")]
        public async Task<IActionResult> GetTarefaByIdAsync(int id)
        {
            try
            {
                var resultado = await _tarefaRepository.GetTarefaByIdAsync(id);
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpGet]
        [Route("tarefasContador")]
        public async Task<IActionResult> GetTarefasContadorAsync()
        {
            try
            {
                var resultado = await _tarefaRepository.GetTarefasEContadorAsync();
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpPost]
        [Route("incluirTarefa")]
        public async Task<IActionResult> SaveTarefaAsync(Tarefa tarefa)
        {
            try
            {
                var resultado = await _tarefaRepository.SaveAsync(tarefa);
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpPut]
        [Route("atualizarTarefa")]
        public async Task<IActionResult> UpdateTarefaStatusAsync(Tarefa tarefa)
        {
            try
            {
                var resultado = await _tarefaRepository.UpdateTarefaStatusAsync(tarefa);
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

        [HttpDelete]
        [Route("excluirTarefa")]
        public async Task<IActionResult> DeleteTarefaAsync(int id)
        {
            try
            {
                var resultado = await _tarefaRepository.DeleteAsync(id);
                return Ok(resultado);
            }
            catch
            {
                return StatusCode(500);
            }

        }

    }
}
