using System.Net.Http;
using System.Threading.Tasks;

internal delegate Task<HttpResponseMessage> IPEType(object, string);
