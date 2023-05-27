namespace SportsLeague.API.Core
{
    public interface IUnitOfwork
    {
        Task CompleteAsync();
    }
}
