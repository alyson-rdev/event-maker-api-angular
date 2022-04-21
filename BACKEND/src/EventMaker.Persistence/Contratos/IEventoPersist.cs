using System.Threading.Tasks;
using EventMaker.Domain;

namespace EventMaker.Persistence.Contratos
{
    public interface IEventoPersist
    {
       
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes);



    }
}