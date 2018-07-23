using System.Threading.Tasks;
using LeakyAppClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeakyAppClient.Controllers
{
  [Route("api/data")]
  public class DataController : ControllerBase
  {
    public DataController(IDataServer dataServer)
    {

    }

    [HttpGet]
    public ActionResult<string> GetAsync()
    {
      return "Hello World";
    }
  }
}