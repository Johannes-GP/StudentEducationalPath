using TrayectoriaEducativaGraficas.Models;

namespace TrayectoriaEducativaGraficas.Services
{
    public interface IObtenerEvaluacionRIMAService
    {
        Task<RimaEvaluacion> ObtenerEvaluacionRIMA();
    }
}
