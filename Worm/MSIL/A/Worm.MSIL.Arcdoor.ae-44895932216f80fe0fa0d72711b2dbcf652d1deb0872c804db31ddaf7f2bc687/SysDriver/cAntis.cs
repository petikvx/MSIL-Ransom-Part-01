using System;
using System.Diagnostics;
using System.Threading;

namespace SysDriver;

internal class cAntis
{
	public void checkAntis()
	{
		if (cMain.ConfigClass.bAntiDebugger)
		{
			try
			{
				if (Debugger.IsAttached)
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiSandboxie)
		{
			try
			{
				foreach (string module in Process.GetCurrentProcess().Modules)
				{
					if (module.Contains("sbiedll.dll"))
					{
						Terminate();
						return;
					}
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiEmulator)
		{
			try
			{
				long ticks = DateTime.Now.Ticks;
				Thread.Sleep(10);
				if (DateTime.Now.Ticks - ticks < 10L)
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiNetstat)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("NETSTAT"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiFilemon)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("FILEMON"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiProcessmon)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("PROCMON"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiRegmon)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("REGMON"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiCain)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("CAIN"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiNetworkmon)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("NETMON"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiTCPView)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("TCPVIEW"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiWireshark)
		{
			try
			{
				if (cMain.FunctionClass.checkProcess("WIRESHARK"))
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiParallelsDesktop)
		{
			try
			{
				if (cMain.SystemInfoClass.getGraphicDevice() == "Parallels Video Adapter")
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiVMWare)
		{
			try
			{
				if (cMain.SystemInfoClass.getGraphicDevice() == "VMware SVGA II")
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (cMain.ConfigClass.bAntiVirtualBox)
		{
			try
			{
				if (cMain.SystemInfoClass.getGraphicDevice() == "VirtualBox Graphics Adapter")
				{
					Terminate();
					return;
				}
			}
			catch
			{
			}
		}
		if (!cMain.ConfigClass.bAntiVirtualPC)
		{
			return;
		}
		try
		{
			string[] array = new string[2] { "VM Additions S3 Trio32/64", "S3 Trio32/64" };
			int num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					if (cMain.SystemInfoClass.getGraphicDevice() == array[num])
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			Terminate();
		}
		catch
		{
		}
	}

	private void Terminate()
	{
		Environment.Exit(0);
	}
}
