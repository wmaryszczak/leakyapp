using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace LeakyAppClient.Services
{
  public class DataServer : IDataServer
  {
    private readonly DataServerOptions options;
    public DataServer(IOptions<DataServerOptions> options)
    {
      this.options = options.Value;
    }

    public List<string> GetData()
    {
      return new List<string> { "Hello world" };
    }
  }
}