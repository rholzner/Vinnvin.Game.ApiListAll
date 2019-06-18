namespace Vinnvin.GameApi.listAll.Contracts
{
    public interface IDbSettings
    {
        string DbName { get; }
        string Collection { get; }
        string ConnectionString { get; }
    }
}
