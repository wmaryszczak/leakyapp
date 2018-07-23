using System.Collections.Generic;

namespace LeakyAppClient.Services
{
  public interface IDataServer
  {
    List<string> GetData();
  }
}