namespace QuarterlySales.Models
{
    public interface IUnitOfWork
    {
        Repository<Employee> Employees { get; }
        Repository<Sales> Sales { get; }

        void Save();
    }
}
