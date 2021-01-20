using System.Threading.Tasks;

namespace Playground.Data
{
    public interface IPlaygroundDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
