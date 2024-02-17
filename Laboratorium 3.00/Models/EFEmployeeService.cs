using Data;
using Data.Entities;
using Laboratorium_3._00.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorium_3._00.Models
{
    public class EFContactService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Employee employee)
        {
            var e = _context.Add(EmployeeMapper.ToEntity(employee));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            EmployeeEntity? find = _context.Employees.Find(id);
            if (find != null)
            {
                _context.Employees.Remove(find);
                _context.SaveChanges();
                bool v = true;
            }
        }

        public List<Employee> FindAll() => _context.Employees.Select(EmployeeMapper.FromEntity).ToList();

        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS8766 // Допустимость значений NULL для ссылочных типов в типе возвращаемого значения не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        public Employee? FindById(int id)
#pragma warning restore CS8766 // Допустимость значений NULL для ссылочных типов в типе возвращаемого значения не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        {
            return EmployeeMapper.FromEntity(_context.Employees.Find(id));
        }

        public void Update(Employee contact)
        {
            _context.Employees.Update(EmployeeMapper.ToEntity(contact));
            _context.SaveChanges();
        }
    }
}
