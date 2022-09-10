using System.Threading;
using ATI.ACE.LOG.Foundation;
using ATI.ACE.LOG.Foundation.Implementation.Private;

namespace ATI.ACE.LOG.EXE;

public class LogServer : MBRO, ILog
{
	public delegate void AppDomainRegisterHandler(IServices s);

	public delegate void AppDomainUnregisterHandler(string s);

	public delegate void LogUpdateEventHandler(LogEventArgs e);

	public delegate void CccComponentsHandler(CCC myCCC);

	public event LogUpdateEventHandler LogUpdate;

	public event AppDomainRegisterHandler AppDomainRegister;

	public event AppDomainUnregisterHandler AppDomainUnregister;

	public event CccComponentsHandler CccComponents;

	public void SendLogMessage(SLog message)
	{
		ParameterizedThreadStart start = SendLogMessageByThread;
		Thread thread = new Thread(start);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = "SendLogMessage";
		thread.Start(new LogEventArgs(message));
	}

	private void SendLogMessageByThread(object o)
	{
		this.LogUpdate(o as LogEventArgs);
	}

	public void Client_Register(IServices s)
	{
		ParameterizedThreadStart start = Client_RegisterByThread;
		Thread thread = new Thread(start);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = "Client_Register";
		thread.Start(s);
	}

	private void Client_RegisterByThread(object o)
	{
		this.AppDomainRegister((IServices)((o is IServices) ? o : null));
	}

	public void Client_Unregister(string s)
	{
		ParameterizedThreadStart start = Client_UnregisterByThread;
		Thread thread = new Thread(start);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = "Client_Unregister";
		thread.Start(s);
	}

	private void Client_UnregisterByThread(object o)
	{
		this.AppDomainUnregister(o as string);
	}

	public void SendComponents(CCC myCCC)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		ParameterizedThreadStart start = SendComponentsByThread;
		Thread thread = new Thread(start);
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Name = "SendComponents";
		thread.Start(myCCC);
	}

	private void SendComponentsByThread(object o)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		this.CccComponents((CCC)o);
	}
}
