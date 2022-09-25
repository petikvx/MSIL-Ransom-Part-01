using System;
using System.IO;

namespace NitroRansomware;

internal class Logs
{
	private string save;

	private string filename;

	private string config;

	private int type;

	public Logs(string configType, int outType)
	{
		save = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		filename = "\\logs.txt";
		config = configType;
		type = outType;
	}

	private void Write(string append, string message)
	{
		if (type == 1)
		{
			using (StreamWriter streamWriter = File.AppendText(save + filename))
			{
				string text = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
				streamWriter.Write(text + message);
				streamWriter.Write("\n");
				return;
			}
		}
		if (type == 0)
		{
			string text2 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
			Console.Write(text2 + message);
			Console.Write("\n");
			return;
		}
		using (StreamWriter streamWriter2 = File.AppendText(save + filename))
		{
			string text3 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
			streamWriter2.Write(text3 + message);
			streamWriter2.Write("\n");
		}
		string text4 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), append);
		Console.Write(text4 + message);
		Console.Write("\n");
	}

	public void Debug(string message)
	{
		if (config == "DEBUG")
		{
			Write("DEBUG", message);
		}
	}

	public void Info(string message)
	{
		if (config == "DEBUG")
		{
			Write("INFO", message);
		}
		else if (config == "INFO")
		{
			Write("INFO", message);
		}
	}

	public void Warning(string message)
	{
		if (config != "ERROR")
		{
			Write("WARNING", message);
		}
	}

	public void Error(string message)
	{
		Write("ERROR", message);
	}
}
