using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventMaker.Domain;
using EventMaker.Persistence.Contextos;
using EventMaker.Persistence.Contratos;

namespace EventMaker.Persistence
{
    public class PalestrantePersist : IPalestrantePersist
    {
        private readonly EventMakerContext _context;
        public PalestrantePersist(EventMakerContext context)
        {
            _context = context;
        }

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

        public Task<Palestrante[]> GetAllEventosByNomeAsync(string Nome, bool includeEventos)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(p => p.RedesSociais);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(p => p.RedesSociais);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                         .Where(p => p.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(p => p.RedesSociais);

            if (includeEventos)
            {
                query = query
                    .Include(p => p.PalestrantesEventos)
                    .ThenInclude(pe => pe.Evento);
            }

            query = query.AsNoTracking().OrderBy(p => p.Id)
                         .Where(p => p.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
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