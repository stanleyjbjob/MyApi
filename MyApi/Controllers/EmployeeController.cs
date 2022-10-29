using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Dal;
using MyApi.Repositiry;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public List<Employee> GetAll()
        {
            return _unitOfWork.Repository<Employee>().Reads().ToList();
        }
        [HttpPost]
        public bool Create(CreateEmployeeDto create)
        {
            _unitOfWork.Repository<Employee>().Create(new Employee
            {
                Address = create.Address,
                BirthDate = create.BirthDate,
                Code = create.Code,
                CreateTime = DateTime.Now,
                CreatorId = Guid.NewGuid(),
                DataGroup = create.DataGroup,
                IsDelete = false,
                Name = create.Name,
            });
            _unitOfWork.Save();
            return true;
        }
    }
}
