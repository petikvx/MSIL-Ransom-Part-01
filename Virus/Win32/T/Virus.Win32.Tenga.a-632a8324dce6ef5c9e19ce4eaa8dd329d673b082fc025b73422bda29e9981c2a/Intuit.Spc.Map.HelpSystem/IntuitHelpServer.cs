using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Intuit.Spc.Map.HelpSystem.HelpUtilities;
using Intuit.Spc.Map.HelpSystem.HelpUtilities.CrashReporting;
using Microsoft.Win32;

namespace Intuit.Spc.Map.HelpSystem;

public class IntuitHelpServer : Form
{
	private Container components;

	public static Guid IID_IUnknown = new Guid("{00000000-0000-0000-C000-000000000046}");

	public static Guid IID_IDispatch = new Guid("{00020400-0000-0000-C000-000000000046}");

	protected static uint m_uiMainThreadId;

	protected static int m_iObjsInUse;

	protected static int m_iServerLocks;

	public static HelpCrashReporting m_CrashReporting;

	private static Mutex sInstanceMutex = null;

	public static uint MainThreadId => m_uiMainThreadId;

	public static int ObjectsCount
	{
		get
		{
			lock (typeof(IntuitHelpServer))
			{
				return m_iObjsInUse;
			}
		}
	}

	public static int ServerLockCount
	{
		get
		{
			lock (typeof(IntuitHelpServer))
			{
				return m_iServerLocks;
			}
		}
	}

	public IntuitHelpServer()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(292, 266));
		((Control)this).set_Name("IntuitHelpServer");
		((Control)this).set_Text("IntuitHelpServer");
	}

	[DllImport("ole32.dll")]
	private static extern int CoInitializeEx(IntPtr pvReserved, uint dwCoInit);

	[DllImport("ole32.dll")]
	private static extern void CoUninitialize();

	[DllImport("user32.dll")]
	private static extern bool PostThreadMessage(uint idThread, uint Msg, UIntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll")]
	private static extern uint GetCurrentThreadId();

	[DllImport("user32.dll")]
	private static extern bool GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

	[DllImport("user32.dll")]
	private static extern bool TranslateMessage([In] ref MSG lpMsg);

	[DllImport("user32.dll")]
	private static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

	public static int InterlockedIncrementObjectsCount()
	{
		return Interlocked.Increment(ref m_iObjsInUse);
	}

	public static int InterlockedDecrementObjectsCount()
	{
		return Interlocked.Decrement(ref m_iObjsInUse);
	}

	public static int InterlockedIncrementServerLockCount()
	{
		return Interlocked.Increment(ref m_iServerLocks);
	}

	public static int InterlockedDecrementServerLockCount()
	{
		return Interlocked.Decrement(ref m_iServerLocks);
	}

	public static void AttemptToTerminateServer()
	{
		lock (typeof(IntuitHelpServer))
		{
			int objectsCount = ObjectsCount;
			int serverLockCount = ServerLockCount;
			StringBuilder stringBuilder = new StringBuilder("");
			stringBuilder.AppendFormat("m_iObjsInUse : {0}. m_iServerLocks : {1}", objectsCount, serverLockCount);
			if (objectsCount <= 0 && serverLockCount <= 0)
			{
				PostThreadMessage(wParam: new UIntPtr(0u), lParam: new IntPtr(0), idThread: MainThreadId, Msg: 18u);
			}
		}
	}

	protected static bool ProcessArguments(string[] args)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		if (args.Length > 0)
		{
			RegistryKey registryKey = null;
			RegistryKey registryKey2 = null;
			switch (args[0].ToLower())
			{
			case "-embedding":
				return true;
			case "-regserver":
			case "/regserver":
				try
				{
					Console.WriteLine("Registering Classes for IntuitHelp");
					registryKey = Registry.ClassesRoot.CreateSubKey("CLSID\\" + Marshal.GenerateGuidForType(typeof(HelpSystem)).ToString("B"));
					if (registryKey != null)
					{
						registryKey2 = registryKey.CreateSubKey("LocalServer32");
						registryKey2?.SetValue(null, Application.get_ExecutablePath());
					}
				}
				catch (Exception ex2)
				{
					UserMessage.ShowErrorBox("Error while registering the server:\n" + ex2.ToString());
				}
				finally
				{
					registryKey?.Close();
					registryKey2?.Close();
				}
				return false;
			case "-unregserver":
			case "/unregserver":
				try
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("CLSID\\" + Marshal.GenerateGuidForType(typeof(HelpSystem)).ToString("B"), writable: true);
					if (registryKey != null && registryKey.OpenSubKey("LocalServer32") != null)
					{
						registryKey.DeleteSubKeyTree("LocalServer32");
					}
				}
				catch (Exception ex)
				{
					UserMessage.ShowErrorBox("Error while unregistering the server:\n" + ex.ToString());
				}
				finally
				{
					registryKey?.Close();
					registryKey2?.Close();
				}
				return false;
			case "-debug":
			case "/debug":
				return true;
			default:
				UserMessage.ShowErrorBox("Unknown argument: " + args[0] + "\nValid are: -debug, -regserver, -unregserver and -embedding");
				return false;
			}
		}
		UserMessage.ShowWarningBox("The program you are trying to open is the QuickBooks Help program. You cannot use it outside of QuickBooks.\n\nIf you want to use QuickBooks Help, open QuickBooks, and then click Help.");
		return false;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Application.add_ThreadException((ThreadExceptionEventHandler)Application_UIThreadException);
		Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
		AppDomain.CurrentDomain.UnhandledException += Application_UnhandledThreadException;
		string text = "QB Help";
		string text2 = "19.0";
		string text3 = "R11";
		m_CrashReporting = new HelpCrashReporting(text, text, text2, text3);
		Version version = new Version(Application.get_ProductVersion());
		string name = "Intuit, Inc. QuickBooks Next Generation Help. Major version " + version.Major;
		sInstanceMutex = new Mutex(initiallyOwned: false, name, out var createdNew);
		if (createdNew && ProcessArguments(args))
		{
			m_iObjsInUse = 0;
			m_iServerLocks = 0;
			m_uiMainThreadId = GetCurrentThreadId();
			IntuitHelpClassFactory intuitHelpClassFactory = new IntuitHelpClassFactory();
			intuitHelpClassFactory.ClassContext = 4u;
			intuitHelpClassFactory.ClassId = Marshal.GenerateGuidForType(typeof(HelpSystem));
			intuitHelpClassFactory.Flags = 5u;
			intuitHelpClassFactory.RegisterClassObject();
			ClassFactoryBase.ResumeClassObjects();
			GarbageCollection garbageCollection = new GarbageCollection(1000);
			Thread thread = new Thread(garbageCollection.GCWatch);
			thread.Name = "Garbage Collection Thread";
			thread.Start();
			Application.Run();
			intuitHelpClassFactory.RevokeClassObject();
			garbageCollection.StopThread();
			garbageCollection.WaitForThreadToStop();
		}
	}

	private void IntuitHelpServer_Load(object sender, EventArgs e)
	{
	}

	private static void Application_UIThreadException(object sender, ThreadExceptionEventArgs e)
	{
		m_CrashReporting.SendUnhandledExceptionReport(e.Exception);
		Environment.Exit(0);
	}

	private static void Application_UnhandledThreadException(object sender, UnhandledExceptionEventArgs e)
	{
		m_CrashReporting.SendUnhandledExceptionReport((Exception)e.ExceptionObject);
		Environment.Exit(0);
	}
}
