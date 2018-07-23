using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LeakyAppClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace LeakyAppClient.Controllers
{
  [Route("api/data")]
  public class DataController : ControllerBase
  {
    private IDataServer dataServer;

    public DataController(IDataServer dataServer)
    {
      this.dataServer = dataServer;
    }

    [HttpGet]
    [Produces("application/json")]
    public ActionResult<List<string>> GetAsync()
    {
      return this.dataServer.GetData();
    }
  }
}