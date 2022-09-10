using System;

namespace HealthCheckAssetExt;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			if (args.Length > 2)
			{
				string strClassName = args[1].Replace("/", "");
				string strGuid = args[2].Replace("/", "");
				string strFileName = args[3].Replace("/", "");
				_ = args[0] == "/NetworkInterfaceType";
				if (args[0] == "/NetworkAdapters")
				{
					clsNetworking clsNetworking2 = new clsNetworking();
					clsNetworking2.addNetworkAdapters(strClassName, strGuid, strFileName);
				}
				else if (args[0] == "/HPProductInfo")
				{
					clsProductInfo clsProductInfo2 = new clsProductInfo();
					clsProductInfo2.addProductInfo(strClassName, strGuid, strFileName);
				}
				else if (args[0] == "/MemoryInfo")
				{
					clsMemory clsMemory2 = new clsMemory();
					clsMemory2.addMemoryInfo(strClassName, strGuid, strFileName);
				}
				else if (args[0] == "/SoftwareInfo")
				{
					clsPrograms clsPrograms2 = new clsPrograms();
					clsPrograms2.addProgramsInfo(strClassName, strGuid, strFileName);
				}
				else if (args[0] == "/AdminDetails")
				{
					clsSecurity clsSecurity2 = new clsSecurity();
					clsSecurity2.getAdminDetails(strClassName, strGuid, strFileName);
				}
				else if (args[0] == "/Printers")
				{
					clsPrinters clsPrinters2 = new clsPrinters();
					clsPrinters2.addPrintersInfo(strClassName, strGuid, strFileName);
				}
			}
		}
		catch
		{
		}
	}
}
