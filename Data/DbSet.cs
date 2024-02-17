using Data.Entities;

namespace Data
{
    public class DbSet
    {
        public EmployeeEntity? Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmployeeEntity find)
        {
            throw new NotImplementedException();
        }

        public object Select(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeeEntity employeeEntity)
        {
            throw new NotImplementedException();
        }
    }
}