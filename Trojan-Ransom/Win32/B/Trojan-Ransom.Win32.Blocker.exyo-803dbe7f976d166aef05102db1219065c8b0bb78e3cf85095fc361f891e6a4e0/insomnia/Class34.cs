using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace insomnia;

internal class Class34 : IDisposable
{
	private const int Field19 = 1;

	private const int Field18 = 16;

	private const int Field17 = 131072;

	private static readonly IntPtr Field16 = new IntPtr(int.MinValue);

	private static readonly IntPtr Field15 = new IntPtr(-2147483647);

	private static readonly IntPtr Field14 = new IntPtr(-2147483646);

	private static readonly IntPtr Field13 = new IntPtr(-2147483645);

	private static readonly IntPtr Field12 = new IntPtr(-2147483644);

	private static readonly IntPtr Field11 = new IntPtr(-2147483643);

	private static readonly IntPtr Field10 = new IntPtr(-2147483642);

	private EventHandler Field9;

	private ErrorEventHandler Field8;

	private IntPtr Field7;

	private string Field6;

	private object Field5 = new object();

	private Thread Field4;

	private bool Field3;

	private ManualResetEvent Field2 = new ManualResetEvent(initialState: false);

	private Enum1 Field1 = Enum1.Field4 | Enum1.Field3 | Enum1.Field2 | Enum1.Field1;

	public Enum1 Property2
	{
		get
		{
			return Field1;
		}
		set
		{
			lock (Field5)
			{
				if (Property1)
				{
					throw new InvalidOperationException("Monitoring thread is already running");
				}
				Field1 = value;
			}
		}
	}

	public bool Property1 => Field4 != null;

	public event EventHandler Event_0
	{
		add
		{
			EventHandler eventHandler = Field9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Field9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = Field9;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Field9, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event ErrorEventHandler Event_1
	{
		add
		{
			ErrorEventHandler errorEventHandler = Field8;
			ErrorEventHandler errorEventHandler2;
			do
			{
				errorEventHandler2 = errorEventHandler;
				ErrorEventHandler value2 = (ErrorEventHandler)Delegate.Combine(errorEventHandler2, value);
				errorEventHandler = Interlocked.CompareExchange(ref Field8, value2, errorEventHandler2);
			}
			while ((object)errorEventHandler != errorEventHandler2);
		}
		remove
		{
			ErrorEventHandler errorEventHandler = Field8;
			ErrorEventHandler errorEventHandler2;
			do
			{
				errorEventHandler2 = errorEventHandler;
				ErrorEventHandler value2 = (ErrorEventHandler)Delegate.Remove(errorEventHandler2, value);
				errorEventHandler = Interlocked.CompareExchange(ref Field8, value2, errorEventHandler2);
			}
			while ((object)errorEventHandler != errorEventHandler2);
		}
	}

	public Class34(RegistryKey registryKey)
	{
		Method5(registryKey.Name);
	}

	public Class34(string name)
	{
		if (name == null || name.Length == 0)
		{
			throw new ArgumentNullException("name");
		}
		Method5(name);
	}

	public Class34(RegistryHive registryHive, string subKey)
	{
		Method6(registryHive, subKey);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegOpenKeyEx(IntPtr A_0, string A_1, uint A_2, int A_3, out IntPtr A_4);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegNotifyChangeKeyValue(IntPtr A_0, bool A_1, Enum1 A_2, IntPtr A_3, bool A_4);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegCloseKey(IntPtr A_0);

	protected virtual void Method8()
	{
		Field9?.Invoke(this, null);
	}

	protected virtual void Method7(Exception A_1)
	{
		Field8?.Invoke(this, new ErrorEventArgs(A_1));
	}

	public void Dispose()
	{
		Method3();
		Field3 = true;
		GC.SuppressFinalize(this);
	}

	private void Method6(RegistryHive A_1, string A_2)
	{
		switch (A_1)
		{
		default:
			throw new InvalidEnumArgumentException("hive", (int)A_1, typeof(RegistryHive));
		case RegistryHive.ClassesRoot:
			Field7 = Field16;
			break;
		case RegistryHive.CurrentUser:
			Field7 = Field15;
			break;
		case RegistryHive.LocalMachine:
			Field7 = Field14;
			break;
		case RegistryHive.Users:
			Field7 = Field13;
			break;
		case RegistryHive.PerformanceData:
			Field7 = Field12;
			break;
		case RegistryHive.CurrentConfig:
			Field7 = Field11;
			break;
		case (RegistryHive)(-2147483642):
			Field7 = Field10;
			break;
		}
		Field6 = A_2;
	}

	private void Method5(string A_1)
	{
		string[] array = A_1.Split(new char[1] { '\\' });
		switch (array[0])
		{
		case "HKEY_CLASSES_ROOT":
		case "HKCR":
			Field7 = Field16;
			break;
		case "HKEY_CURRENT_USER":
		case "HKCU":
			Field7 = Field15;
			break;
		case "HKEY_LOCAL_MACHINE":
		case "HKLM":
			Field7 = Field14;
			break;
		case "HKEY_USERS":
			Field7 = Field13;
			break;
		case "HKEY_CURRENT_CONFIG":
			Field7 = Field11;
			break;
		default:
			Field7 = IntPtr.Zero;
			throw new ArgumentException("The registry hive '" + array[0] + "' is not supported", "value");
		}
		Field6 = string.Join("\\", array, 1, array.Length - 1);
	}

	public void Method4()
	{
		if (Field3)
		{
			throw new ObjectDisposedException(null, "This instance is already disposed");
		}
		lock (Field5)
		{
			if (!Property1)
			{
				Field2.Reset();
				Field4 = new Thread(Method2);
				Field4.IsBackground = true;
				Field4.Start();
			}
		}
	}

	public void Method3()
	{
		if (Field3)
		{
			throw new ObjectDisposedException(null, "This instance is already disposed");
		}
		lock (Field5)
		{
			Thread field = Field4;
			if (field != null)
			{
				Field2.Set();
				field.Join();
			}
		}
	}

	private void Method2()
	{
		try
		{
			Method1();
		}
		catch (Exception a_)
		{
			Method7(a_);
		}
		Field4 = null;
	}

	private void Method1()
	{
		int num = RegOpenKeyEx(Field7, Field6, 0u, 131089, out var A_);
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		try
		{
			AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
			WaitHandle[] waitHandles = new WaitHandle[2] { autoResetEvent, Field2 };
			while (!Field2.WaitOne(0, exitContext: true))
			{
				num = RegNotifyChangeKeyValue(A_, A_1: true, Field1, autoResetEvent.Handle, A_4: true);
				if (num == 0)
				{
					if (WaitHandle.WaitAny(waitHandles) == 0)
					{
						Method8();
					}
					continue;
				}
				throw new Win32Exception(num);
			}
		}
		finally
		{
			if (A_ != IntPtr.Zero)
			{
				RegCloseKey(A_);
			}
		}
	}
}
