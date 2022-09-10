using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Security.AccessControl;
using System.ServiceProcess;

namespace ZQErpService;

[RunInstaller(true)]
public class ProjectInstaller : Installer
{
	private IContainer components = null;

	private ServiceProcessInstaller serviceProcessInstaller1;

	private ServiceInstaller serviceInstaller1;

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		serviceProcessInstaller1 = new ServiceProcessInstaller();
		serviceInstaller1 = new ServiceInstaller();
		serviceProcessInstaller1.set_Account((ServiceAccount)2);
		serviceProcessInstaller1.set_Password((string)null);
		serviceProcessInstaller1.set_Username((string)null);
		serviceInstaller1.set_Description("提供中启ERP应用服务");
		serviceInstaller1.set_ServiceName("ZQErpServer");
		serviceInstaller1.set_StartType((ServiceStartMode)2);
		((Installer)this).get_Installers().AddRange((Installer[])(object)new Installer[2]
		{
			(Installer)serviceProcessInstaller1,
			(Installer)serviceInstaller1
		});
	}

	public ProjectInstaller()
	{
		InitializeComponent();
	}

	protected override void OnAfterInstall(IDictionary savedState)
	{
		((Installer)this).OnAfterInstall(savedState);
		setSecurityRights(savedState);
	}

	private void setSecurityRights(IDictionary savedState)
	{
		Console.WriteLine("设置服务对文件访问权限,请等待.....");
		try
		{
			DirectoryInfo directory = new FileInfo(((Installer)this).get_Context().get_Parameters()["assemblypath"]).Directory;
			DirectorySecurity accessControl = directory.GetAccessControl();
			accessControl.AddAccessRule(new FileSystemAccessRule("LOCAL SERVICE", FileSystemRights.Modify, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			directory.SetAccessControl(accessControl);
		}
		catch (Exception)
		{
		}
	}
}
