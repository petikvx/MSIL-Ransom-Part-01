using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using ZQSoft.ZQVier.DataService;
using ZQSoft.ZQVier.DataService.Class;
using ZQSoft.ZQVier.VierCore.Services;

namespace ZQErpService;

public class ZQErpServer : ServiceBase
{
	private TcpChannel tchChannel;

	private int serverPort = 8500;

	private IContainer components = null;

	public ZQErpServer()
	{
		InitializeComponent();
	}

	protected override void OnStart(string[] args)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		LoopWarning loopWarning = LoopWarning.GetLoopWarning();
		Thread thread = new Thread((ThreadStart)delegate
		{
			loopWarning.LoopCheck();
		});
		thread.Start();
		string text = Application.get_StartupPath() + "\\ErpConfig.xml";
		RemotingConfiguration.set_CustomErrorsMode((CustomErrorsModes)1);
		RemotingConfiguration.CustomErrorsEnabled(false);
		ErpManager.Initialize(text);
		ServiceManager.get_Services().AddService((IService)new EAIService());
		ServiceManager.get_Services().AddService((IService)new CommonClass());
		if (RemotingConfiguration.get_ApplicationName() != "ZQErpService")
		{
			RemotingConfiguration.set_ApplicationName("ZQErpService");
		}
		RemotingConfiguration.RegisterWellKnownServiceType(new WellKnownServiceTypeEntry(typeof(QueryDataServer), "ZQDataServer", (WellKnownObjectMode)2));
		IEnumerator<ERPInfo> enumerator = ErpManager.get_ErpCollection().Values.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Start();
		}
	}

	protected override void OnStop()
	{
		IEnumerator<ERPInfo> enumerator = ErpManager.get_ErpCollection().Values.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Dispose();
		}
		ErpManager.get_ErpCollection().Clear();
	}

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
		((ServiceBase)this).set_ServiceName("ZQErpServer");
	}
}
