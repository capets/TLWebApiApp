using TLWebApi.Models;

namespace TLWebApi.Interfaces.Repositories
{
    public interface IAutoTypeRepository
    {
        void Add(AutoType autoType);
        AutoType GetAutoType(int id);
        IEnumerable<AutoType> GetAutoTypes();
        void Remove(int id);
        void Remove(AutoType autoType);
        void Update(AutoType autoType);
    }
}