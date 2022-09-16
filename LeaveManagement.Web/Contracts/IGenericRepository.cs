namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> GetAsync(int id);
        Task<List<T>> GetAllSync();
        Task<int> GetCountAsync();


    }
}
