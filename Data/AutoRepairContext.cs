// Entity Framework support removed. This placeholder exists to avoid compile errors
// if other code referenced AutoRepairContext. Use the repository classes in Data.Repositories
// (ServiceRepository, PartRepository) that perform direct SQL via Database.CreateConnection().

namespace AutoRepair.Data
{
    /// <summary>
    /// EF DbContext was removed. This placeholder should not be used for data access.
    /// </summary>
    public class AutoRepairContext
    {
    }
}
