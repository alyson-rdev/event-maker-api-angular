using System.Threading.Tasks;
using EventMaker.Domain;

namespace EventMaker.Persistence
{
    public interface iEventMakerPersistence
    {
        void Add<t>(t entity) where t : class;
        void Update<t>(t entity) where t : class;
        void Delete<t>(t entity) where t : class;
        void DeleteRange<t>(t[] entity) where t : class;
        Task<bool> SaveChangesAsync();

        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes);


         Task<Palestrante[]> GetAllEventosByNomeAsync(string Nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);


    }
}