using CourseUdemy.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace CourseUdemy.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class UserCont : ControllerBase
    {
       
        private readonly UserDbContext dataDbContext;

        public UserCont ( UserDbContext dataDbContext )
        {
            this.dataDbContext = dataDbContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers ( )
        {
            return Ok (dataDbContext.users.ToList ()); 
        }
        [HttpGet("{id}")]

        public ActionResult<User> GetOne (int id )
        {
            return  dataDbContext.users.Find (id);
        }
    }
}
