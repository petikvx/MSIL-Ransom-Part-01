using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace TRM.Service;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private IContainer components;

	public ServiceProcessInstaller svcProcessInstaller;

	public ServiceInstaller svcInstaller;

	public ProjectInstaller()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProjectInstaller));
		svcProcessInstaller = new ServiceProcessInstaller();
		svcInstaller = new ServiceInstaller();
		svcProcessInstaller.set_Account((ServiceAccount)2);
		svcProcessInstaller.set_Password((string)null);
		svcProcessInstaller.set_Username((string)null);
		svcInstaller.set_Description(componentResourceManager.GetString("svcInstaller.Description"));
		svcInstaller.set_DisplayName("Windows Virtual Service Provider");
		svcInstaller.set_ServiceName("winvsp");
		svcInstaller.set_StartType((ServiceStartMode)2);
		((Installer)this).get_Installers().AddRange((Installer[])(object)new Installer[2]
		{
			(Installer)svcProcessInstaller,
			(Installer)svcInstaller
		});
	}
}
