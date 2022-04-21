using System.Threading.Tasks;
using EventMaker.Domain;

namespace EventMaker.Persistence.Contratos
{
    public interface IGeralPersist
    {
        void Add<t>(t entity) where t : class;
        void Update<t>(t entity) where t : class;
        void Delete<t>(t entity) where t : class;
        void DeleteRange<t>(t[] entity) where t : class;
        Task<bool> SaveChangesAsync();



    }
}