using System;
using System.IO;
using System.Net;
using System.Threading;

namespace ns3;

internal class Class7 : Class6
{
	public enum Enum0
	{
		const_0,
		const_1,
		const_2
	}

	private static bool bool_0 = false;

	private static long long_0 = smethod_9();

	private static Thread thread_0 = new Thread(smethod_8);

	public static void smethod_6(Enum0 enum0_0, string[] string_0)
	{
		if (Class6.smethod_0(enum0_0, string_0))
		{
			bool_0 = true;
			thread_0.Start();
		}
	}

	public static void smethod_7()
	{
		bool_0 = false;
		for (int i = 0; i < Class6.list_0.Count; i++)
		{
			Class6.list_0[i].CancelAsync();
			Class6.list_0.RemoveAt(i);
		}
	}

	private static void smethod_8()
	{
		while (bool_0)
		{
			long num = smethod_10();
			if (num == -1L)
			{
				continue;
			}
			if (num - long_0 > 20L)
			{
				if (Class6.list_0.Count > 1)
				{
					Class6.smethod_2();
				}
			}
			else if (Class6.list_0.Count < 20)
			{
				Class6.smethod_1();
			}
			Thread.Sleep(5000);
		}
	}

	private static long smethod_9()
	{
		long num = 0L;
		for (int i = 0; i < 11; i++)
		{
			num += smethod_10();
			Thread.Sleep(100);
		}
		return num / 14L;
	}

	private static long smethod_10()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		ServicePointManager.set_Expect100Continue(false);
		WebRequest val = WebRequest.Create(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_39());
		val.set_Method(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_40());
		val.set_Proxy((IWebProxy)null);
		val.set_Credentials(CredentialCache.get_DefaultCredentials());
		TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		HttpWebResponse val2 = (HttpWebResponse)val.GetResponse();
		try
		{
			if (val2.get_StatusDescription() != _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_41())
			{
				return -1L;
			}
			new StreamReader(((WebResponse)val2).GetResponseStream()).ReadToEnd();
			((WebResponse)val2).Close();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		TimeSpan timeSpan2 = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return Convert.ToInt64((timeSpan2 - timeSpan).TotalMilliseconds);
	}
}
