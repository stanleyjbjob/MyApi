using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MyApi.FilterAttribute;
using MyApi.Dal;
using MyApi.Repositiry;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : JbBaseController
    {
        IUnitOfWork _unitOfWork;
        readonly IMemoryCache _memoryCache;
        public EmployeeController(IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            _unitOfWork = unitOfWork;
            _memoryCache = memoryCache;
        }
        [HttpGet]
        public List<Employee> GetAll()
        {
            throw new Exception("測試錯誤控制");
            string key = $"Employee_GetAll";
            return _memoryCache.GetOrCreate(key, entry =>
            {
                entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(2));
                return _unitOfWork.Repository<Employee>().Reads().ToList();
            });

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
