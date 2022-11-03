using Microsoft.AspNetCore.Mvc;
using MyApi.FilterAttribute;

namespace MyApi.Controllers
{
    [JbExceptionFilterAttribute]
    [JbActionFilterAttribute]
    public class JbBaseController:Controller
    {
    }
}
