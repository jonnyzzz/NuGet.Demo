using System.Collections.Generic;
using System.Linq;

namespace jsample.api.core
{
  public class ApiImpl : IApi
  {
    private IEnumerable<IApiService> myServices = new IApiService[0];

    public ApiImpl()
    {
      myServices = new[] {this};
    }

    public void RegisterService(params IApiService[] s)
    {
      myServices = myServices.Union(s).ToArray();
    }

    public string Version { get { return "42";  } }

    public IEnumerable<IApiService> GetAllServices()
    {
      return myServices.ToArray();
    }
  }

}