using System.Collections.Specialized;
using System.Net;

namespace Argos_2;

internal class http
{
	public static byte[] Post(string url, NameValueCollection pairs)
	{
		using WebClient webClient = new WebClient();
		return webClient.UploadValues(url, pairs);
	}
}
