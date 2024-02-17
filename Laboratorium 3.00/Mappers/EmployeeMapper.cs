using Laboratorium_3._00.Models;
using Data.Entities;

namespace Laboratorium_3._00.Mappers
{
    public class EmployeeMapper
    {
        public static Employee FromEntity(EmployeeEntity entity)
        {
            return new Employee()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Position = entity.Position,
                Department = entity.Department,
            };
        }

        public static EmployeeEntity ToEntity(Employee model)
        {
            return new EmployeeEntity()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Position = model.Position,
                Department = model.Department,
            };
        }

        internal static object FromEntity(object e)
        {
            throw new NotImplementedException();
        }

      
    }
}
