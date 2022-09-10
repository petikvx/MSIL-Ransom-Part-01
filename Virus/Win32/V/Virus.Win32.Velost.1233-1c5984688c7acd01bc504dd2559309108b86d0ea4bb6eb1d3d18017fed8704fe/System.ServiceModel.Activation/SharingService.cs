using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation;

internal abstract class SharingService
{
	public const bool CanHandlePowerEvent = false;

	public const bool AutoLog = false;

	public const bool CanStop = true;

	public const bool CanShutdown = true;

	private static object thisLock = new object();

	private Guid controlServiceGuid;

	private bool isPaused;

	private ServiceHostBase controlServiceHost;

	private SharedMemory sharedMemory;

	private string sharedMemoryName;

	private string serviceName;

	private TransportType transportType;

	public bool IsPaused => isPaused;

	private static object ThisLock => thisLock;

	protected SharingService(TransportType transportType, string serviceName, string sharedMemoryName)
	{
		this.serviceName = serviceName;
		this.transportType = transportType;
		this.sharedMemoryName = sharedMemoryName;
	}

	private static Binding CreateRegisterBinding(TransportType transportType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		NetNamedPipeBinding val = new NetNamedPipeBinding((NetNamedPipeSecurityMode)0);
		val.set_MaxReceivedMessageSize(10000L);
		CustomBinding val2 = new CustomBinding((Binding)(object)val);
		NamedPipeTransportBindingElement val3 = val2.get_Elements().Find<NamedPipeTransportBindingElement>();
		((ConnectionOrientedTransportBindingElement)val3).set_ExposeConnectionProperty(true);
		val3.set_AllowedUsers(ListenerConfig.GetAllowAccounts(transportType));
		((Binding)val2).set_ReceiveTimeout(TimeSpan.MaxValue);
		return (Binding)(object)val2;
	}

	public void OnContinue()
	{
		isPaused = false;
	}

	public void OnPause()
	{
		isPaused = true;
	}

	public void OnShutdown()
	{
		Shutdown();
	}

	public void Start()
	{
		isPaused = false;
		GrantPermissionToAllowedAccounts();
		StartControlService();
		CreateSharedMemory();
	}

	private void GrantPermissionToAllowedAccounts()
	{
		lock (ThisLock)
		{
			Utility.AddRightGrantedToAccounts(ListenerConfig.GetAllowAccounts(transportType), 1024, true);
			Utility.AddRightGrantedToAccounts(ListenerConfig.GetAllowAccounts(transportType), 8, false);
		}
	}

	private void StartControlService()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00d6: Expected O, but got Unknown
		controlServiceHost = null;
		Exception innerException = null;
		for (int i = 0; i < 5; i++)
		{
			controlServiceGuid = Guid.NewGuid();
			string text = controlServiceGuid.ToString();
			try
			{
				Type type = ((transportType != TransportType.Tcp) ? typeof(NamedPipeWorkerProcess) : typeof(TcpWorkerProcess));
				ServiceHost val = new ServiceHost(type, new Uri[1] { Utility.FormatListenerEndpoint(serviceName, text) });
				((ServiceHostBase)val).get_ServiceThrottle().set_MaxConcurrentSessions(int.MaxValue);
				((KeyedCollection<Type, IServiceBehavior>)(object)((ServiceHostBase)val).get_Description().get_Behaviors()).Remove(typeof(ServiceMetadataBehavior));
				val.AddServiceEndpoint(typeof(IConnectionRegister), CreateRegisterBinding(transportType), string.Empty);
				controlServiceHost = (ServiceHostBase)(object)val;
				((CommunicationObject)controlServiceHost).Open();
			}
			catch (CommunicationException val2)
			{
				CommunicationException val3 = val2;
				if (DiagnosticUtility.ShouldTraceWarning)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Warning, (TraceCode)589846, this, (Exception)(object)val3);
				}
				innerException = (Exception)(object)val3;
				controlServiceHost = null;
				continue;
			}
			break;
		}
		if (controlServiceHost == null)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ServiceStartErrorEndpoint", serviceName), innerException));
		}
	}

	private void CreateSharedMemory()
	{
		try
		{
			sharedMemory = SharedMemory.Create("Global\\" + sharedMemoryName, controlServiceGuid, ListenerConfig.GetAllowAccounts(transportType));
		}
		catch (Win32Exception ex)
		{
			DiagnosticUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)13, (EventLogEventId)(-1073479679), new string[1] { ex.ToString() });
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ServiceStartErrorPublish", serviceName), ex));
		}
	}

	public void OnStop()
	{
		Shutdown();
	}

	private void Shutdown()
	{
		try
		{
			if (sharedMemory != null)
			{
				sharedMemory.Dispose();
			}
			MessageQueue.CloseAll(transportType);
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.ShouldTraceError)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Error, (TraceCode)589844, this, exception);
			}
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
		}
		finally
		{
			if (controlServiceHost != null)
			{
				((CommunicationObject)controlServiceHost).Abort();
			}
		}
	}
}
