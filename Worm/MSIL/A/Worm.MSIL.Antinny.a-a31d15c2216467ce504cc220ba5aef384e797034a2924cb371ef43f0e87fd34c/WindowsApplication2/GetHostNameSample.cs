using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication2;

[StandardModule]
internal sealed class GetHostNameSample
{
	public static string dnsname;

	public static string username;

	public static string cline;

	public static string wpash;

	public static long tcnt;

	public static long fnmmax;

	public static string[] fnm = new string[100000];

	public static long drv;

	[STAThread]
	public static void Main(string[] args)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		dnsname = SystemInformation.get_UserName();
		drv = 99L;
		tcnt = 0L;
		for (int i = 0; i < args.Length; i = checked(i + 1))
		{
			string text = (cline = args[i]);
		}
		Form1 form = new Form1();
		((Form)form).ShowDialog();
	}

	private static bool ExistsPrevInstance()
	{
		Process[] array = null;
		bool flag = false;
		try
		{
			array = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
			return array.Length > 1;
		}
		catch (InvalidOperationException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			_ = ex;
			flag = false;
			ProjectData.ClearProjectError();
			return flag;
		}
	}
}
