using System;
using System.IO;

internal class CancelAsync
{
	private string DefineDefaultConstructor;

	private string ProcessToken;

	private string GenerateRandom;

	private int ContentType_Mask;

	public CancelAsync(string string_0, int int_0)
	{
		DefineDefaultConstructor = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		ProcessToken = "\\logs.txt";
		GenerateRandom = string_0;
		ContentType_Mask = int_0;
	}

	private void FindEventCheckBaseType(string string_0, string string_1)
	{
		if (ContentType_Mask == 1)
		{
			using (StreamWriter streamWriter = File.AppendText(DefineDefaultConstructor + ProcessToken))
			{
				string text = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), string_0);
				streamWriter.Write(text + string_1);
				streamWriter.Write("\n");
				return;
			}
		}
		if (ContentType_Mask == 0)
		{
			string text2 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), string_0);
			Console.Write(text2 + string_1);
			Console.Write("\n");
			return;
		}
		using (StreamWriter streamWriter2 = File.AppendText(DefineDefaultConstructor + ProcessToken))
		{
			string text3 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), string_0);
			streamWriter2.Write(text3 + string_1);
			streamWriter2.Write("\n");
		}
		string text4 = string.Format("{0} {1} - ", DateTime.Now.ToString("[hh:mm:ss]"), string_0);
		Console.Write(text4 + string_1);
		Console.Write("\n");
	}

	public void Cancel(string string_0)
	{
		if (GenerateRandom == "DEBUG")
		{
			FindEventCheckBaseType("DEBUG", string_0);
		}
	}

	public void GetEmptyCAHolder(string string_0)
	{
		if (GenerateRandom == "DEBUG")
		{
			FindEventCheckBaseType("INFO", string_0);
		}
		else if (GenerateRandom == "INFO")
		{
			FindEventCheckBaseType("INFO", string_0);
		}
	}

	public void GetIsAmbiguousTime(string string_0)
	{
		if (GenerateRandom != "ERROR")
		{
			FindEventCheckBaseType("WARNING", string_0);
		}
	}

	public void Conv_Ovf_I_Un(string string_0)
	{
		FindEventCheckBaseType("ERROR", string_0);
	}
}
