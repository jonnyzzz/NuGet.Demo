using System.IO;
using Newtonsoft.Json;
using jsample.api.core;

namespace jsample.services.core
{
  public class JSonService : IApiService
  {
    public void ReadText(string text)
    {
      JsonReader r = new JsonTextReader(new StringReader(text));
      r.Close();
    }
  }
}