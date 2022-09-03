using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace ns0;

public class GClass2 : IDisposable
{
	private const int int_0 = 1;

	private const int int_1 = 16;

	private const int int_2 = 131072;

	private static readonly IntPtr intptr_0 = new IntPtr(int.MinValue);

	private static readonly IntPtr intptr_1 = new IntPtr(-2147483647);

	private static readonly IntPtr intptr_2 = new IntPtr(-2147483646);

	private static readonly IntPtr intptr_3 = new IntPtr(-2147483645);

	private static readonly IntPtr intptr_4 = new IntPtr(-2147483644);

	private static readonly IntPtr intptr_5 = new IntPtr(-2147483643);

	private static readonly IntPtr intptr_6 = new IntPtr(-2147483642);

	private EventHandler eventHandler_0;

	private ErrorEventHandler errorEventHandler_0;

	private IntPtr intptr_7;

	private string string_0;

	private object object_0 = new object();

	private Thread thread_0;

	private bool bool_0;

	private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: false);

	private GEnum0 genum0_0 = GEnum0.flag_0 | GEnum0.flag_1 | GEnum0.flag_2 | GEnum0.flag_3;

	public GEnum0 GEnum0_0
	{
		get
		{
			return genum0_0;
		}
		set
		{
			lock (object_0)
			{
				if (Boolean_0)
				{
					throw new InvalidOperationException("Monitoring thread is already running");
				}
				genum0_0 = value;
			}
		}
	}

	public bool Boolean_0 => thread_0 != null;

	public event EventHandler RegChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event ErrorEventHandler Error
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			errorEventHandler_0 = (ErrorEventHandler)Delegate.Combine(errorEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			errorEventHandler_0 = (ErrorEventHandler)Delegate.Remove(errorEventHandler_0, value);
		}
	}

	public GClass2(RegistryKey registryKey)
	{
		method_1(registryKey.Name);
	}

	public GClass2(string name)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (name == null || name.Length == 0)
		{
			throw new ArgumentNullException("name");
		}
		method_1(name);
	}

	public GClass2(RegistryHive registryHive, string subKey)
	{
		method_0(registryHive, subKey);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegOpenKeyEx(IntPtr intptr_8, string string_1, uint uint_0, int int_3, out IntPtr intptr_9);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegNotifyChangeKeyValue(IntPtr intptr_8, bool bool_1, GEnum0 genum0_1, IntPtr intptr_9, bool bool_2);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegCloseKey(IntPtr intptr_8);

	protected virtual void OnRegChanged()
	{
		eventHandler_0?.Invoke(this, null);
	}

	protected virtual void OnError(Exception exception_0)
	{
	}

	public void Dispose()
	{
		method_3();
		bool_0 = true;
		GC.SuppressFinalize(this);
	}

	private void method_0(RegistryHive registryHive_0, string string_1)
	{
		switch (registryHive_0)
		{
		default:
			throw new InvalidEnumArgumentException("hive", (int)registryHive_0, typeof(RegistryHive));
		case RegistryHive.ClassesRoot:
			intptr_7 = intptr_0;
			break;
		case RegistryHive.CurrentUser:
			intptr_7 = intptr_1;
			break;
		case RegistryHive.LocalMachine:
			intptr_7 = intptr_2;
			break;
		case RegistryHive.Users:
			intptr_7 = intptr_3;
			break;
		case RegistryHive.PerformanceData:
			intptr_7 = intptr_4;
			break;
		case RegistryHive.CurrentConfig:
			intptr_7 = intptr_5;
			break;
		case (RegistryHive)(-2147483642):
			intptr_7 = intptr_6;
			break;
		}
		string_0 = string_1;
	}

	private void method_1(string string_1)
	{
		string[] array = string_1.Split(new char[1] { '\\' });
		switch (array[0])
		{
		case "HKEY_CLASSES_ROOT":
		case "HKCR":
			intptr_7 = intptr_0;
			break;
		case "HKEY_CURRENT_USER":
		case "HKCU":
			intptr_7 = intptr_1;
			break;
		case "HKEY_LOCAL_MACHINE":
		case "HKLM":
			intptr_7 = intptr_2;
			break;
		case "HKEY_USERS":
			intptr_7 = intptr_3;
			break;
		case "HKEY_CURRENT_CONFIG":
			intptr_7 = intptr_5;
			break;
		default:
			intptr_7 = IntPtr.Zero;
			throw new ArgumentException("The registry hive '" + array[0] + "' is not supported", "value");
		}
		string_0 = string.Join("\\", array, 1, array.Length - 1);
	}

	public void method_2()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException(null, "This instance is already disposed");
		}
		lock (object_0)
		{
			if (!Boolean_0)
			{
				manualResetEvent_0.Reset();
				thread_0 = new Thread(method_4);
				thread_0.IsBackground = true;
				thread_0.Start();
			}
		}
	}

	public void method_3()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException(null, "This instance is already disposed");
		}
		lock (object_0)
		{
			Thread thread = thread_0;
			if (thread != null)
			{
				manualResetEvent_0.Set();
				thread.Join();
			}
		}
	}

	private void method_4()
	{
		try
		{
			method_5();
		}
		catch (Exception exception_)
		{
			OnError(exception_);
		}
		thread_0 = null;
	}

	private void method_5()
	{
		int num = RegOpenKeyEx(intptr_7, string_0, 0u, 131089, out var intptr_);
		if (num != 0)
		{
			throw new Win32Exception(num);
		}
		try
		{
			AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
			WaitHandle[] waitHandles = new WaitHandle[2] { autoResetEvent, manualResetEvent_0 };
			while (true)
			{
				if (!manualResetEvent_0.WaitOne(0, exitContext: true))
				{
					num = RegNotifyChangeKeyValue(intptr_, bool_1: true, genum0_0, autoResetEvent.SafeWaitHandle.DangerousGetHandle(), bool_2: true);
					if (num != 0)
					{
						break;
					}
					if (WaitHandle.WaitAny(waitHandles) == 0)
					{
						OnRegChanged();
					}
					continue;
				}
				return;
			}
			throw new Win32Exception(num);
		}
		finally
		{
			if (intptr_ != IntPtr.Zero)
			{
				RegCloseKey(intptr_);
			}
		}
	}
}
