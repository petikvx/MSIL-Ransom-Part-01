using System;
using System.ServiceProcess;

public class SystemServices
{
	public static bool SystemServiceOpen(string serviceName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		try
		{
			ServiceController val = new ServiceController(serviceName);
			try
			{
				if ((int)val.get_Status() != 4)
				{
					val.Start();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool SystemServiceClose(string serviceName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		try
		{
			ServiceController val = new ServiceController(serviceName);
			try
			{
				if ((int)val.get_Status() == 4)
				{
					val.Stop();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool SystemServiceReStart(string serviceName)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		try
		{
			ServiceController val = new ServiceController(serviceName);
			try
			{
				if ((int)val.get_Status() == 4)
				{
					val.Continue();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return true;
		}
		catch
		{
			return false;
		}
	}
}
