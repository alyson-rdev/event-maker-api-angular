using System.Threading.Tasks;
using EventMaker.Domain;

namespace EventMaker.Persistence
{
    public class EventMakerPersistence : iEventMakerPersistence
    {
        public void Add<t>(t entity) where t : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<t>(t entity) where t : class
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRange<t>(t[] entity) where t : class
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllEventosByNomeAsync(string Nome, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update<t>(t entity) where t : class
        {
            throw new System.NotImplementedException();
        }
    }
}