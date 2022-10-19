using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using IObjects;
using BLL.Models;
using IObjects.Repository;

namespace BLL.DataManager
{
    public class EmpManager : IDataRepository<Employee>
    {
        readonly Empcontext _EmpContext;
        public EmpManager(Empcontext context)
        {
            _EmpContext = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return (IEnumerable<Employee>)_EmpContext.Employee.ToList();
        }
        public Employee Get(int id)
        {
            return (Employee)_EmpContext.Employee.FirstOrDefault(x => x.EmpId == id);
        }
        public void Add(Employee entity)
        {
            _EmpContext.Employee.Add(entity);
            _EmpContext.SaveChanges();
        }

        
        public void Update(Employee employee, Employee entity)
        {
            employee.EmpName = entity.EmpName;
            employee.Empgender = entity.Empgender;
            employee.EmpDob = entity.EmpDob;
            employee.EmpEmail = entity.EmpEmail;
            employee.EmpDep = entity.EmpDep;
        }
        public void Delete(Employee employee)
        {
            _EmpContext.Employee.Remove(employee);
            _EmpContext.SaveChanges();
        }
    }
}
