using System.Collections.Generic;

namespace jsample.api.core
{
  public interface IApi : IApiService
  {
    string Version { get; }

    IEnumerable<IApiService> GetAllServices();
  }
}