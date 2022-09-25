using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

internal class Class3
{
	private static Class2 class2_0;

	public static bool smethod_0(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		HttpClient val = new HttpClient();
		try
		{
			string text = string.Format(Class11.smethod_0("\uf1d7\uf1cb\uf1cb\uf1cf\uf1cc\uf185\uf190\uf190\uf1db\uf1d6\uf1cc\uf1dc\uf1d0\uf1cd\uf1db\uf191\uf1dc\uf1d0\uf1d2\uf190\uf1de\uf1cf\uf1d6\uf190\uf1c9\uf187\uf190\uf1da\uf1d1\uf1cb\uf1d6\uf1cb\uf1d3\uf1da\uf1d2\uf1da\uf1d1\uf1cb\uf1cc\uf190\uf1d8\uf1d6\uf1d9\uf1cb\uf192\uf1dc\uf1d0\uf1db\uf1da\uf1cc\uf190\uf1c4\uf18f\uf1c2\uf180\uf1c8\uf1d6\uf1cb\uf1d7\uf1e0\uf1de\uf1cf\uf1cf\uf1d3\uf1d6\uf1dc\uf1de\uf1cb\uf1d6\uf1d0\uf1d1\uf182\uf1cb\uf1cd\uf1ca\uf1da\uf199\uf1c8\uf1d6\uf1cb\uf1d7\uf1e0\uf1cc\uf1ca\uf1dd\uf1cc\uf1dc\uf1cd\uf1d6\uf1cf\uf1cb\uf1d6\uf1d0\uf1d1\uf1e0\uf1cf\uf1d3\uf1de\uf1d1\uf182\uf1cb\uf1cd\uf1ca\uf1da", 61871), string_0);
			class2_0.method_1(text);
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

	static Class3()
	{
		if (DateTime.Now > new DateTime(637619016382724050L))
		{
			throw new Exception();
		}
		class2_0 = new Class2(Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340), 0);
	}
}
