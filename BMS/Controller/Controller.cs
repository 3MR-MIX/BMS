using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public string Get(int id, string customerDtos1) {



            return null;
        }
        [HttpDelete]
        public string Delete(int id) {

            return null;
        }
        [HttpPost]
        public string Post(int id, string customerDtos1) {
            
            return null;
        }
        
    }
}
