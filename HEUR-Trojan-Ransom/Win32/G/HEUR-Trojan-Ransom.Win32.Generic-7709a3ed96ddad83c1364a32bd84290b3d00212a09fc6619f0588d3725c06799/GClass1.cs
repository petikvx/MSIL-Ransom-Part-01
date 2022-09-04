using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

[ComVisible(true)]
public sealed class GClass1 : IDisposable
{
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

	private bool bool_0 = false;

	private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: false);

	private GEnum0 genum0_0 = (GEnum0)15;

	public GClass1(RegistryKey registryKey_0)
	{
		method_7(registryKey_0.Name);
	}

	public GClass1(string string_1)
	{
		if (string_1 == null || string_1.Length == 0)
		{
			throw new ArgumentNullException("name");
		}
		method_7(string_1);
	}

	public GClass1(RegistryHive registryHive_0, string string_1)
	{
		method_6(registryHive_0, string_1);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegOpenKeyEx(IntPtr intptr_8, string string_1, uint uint_0, int int_0, out IntPtr intptr_9);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegNotifyChangeKeyValue(IntPtr intptr_8, bool bool_1, GEnum0 genum0_1, IntPtr intptr_9, bool bool_2);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegCloseKey(IntPtr intptr_8);

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(EventHandler eventHandler_1)
	{
		eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(EventHandler eventHandler_1)
	{
		eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, eventHandler_1);
	}

	protected virtual void vmethod_0()
	{
		eventHandler_0?.Invoke(this, null);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(ErrorEventHandler errorEventHandler_1)
	{
		errorEventHandler_0 = (ErrorEventHandler)Delegate.Combine(errorEventHandler_0, errorEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(ErrorEventHandler errorEventHandler_1)
	{
		errorEventHandler_0 = (ErrorEventHandler)Delegate.Remove(errorEventHandler_0, errorEventHandler_1);
	}

	protected virtual void vmethod_1(Exception exception_0)
	{
		errorEventHandler_0?.Invoke(this, new ErrorEventArgs(exception_0));
	}

	public void Dispose()
	{
		method_10();
		bool_0 = true;
		GC.SuppressFinalize(this);
	}

	public GEnum0 method_4()
	{
		return genum0_0;
	}

	public void method_5(GEnum0 genum0_1)
	{
		lock (object_0)
		{
			if (method_8())
			{
				throw new InvalidOperationException("Monitoring thread is already running");
			}
			genum0_0 = genum0_1;
		}
	}

	private void method_6(RegistryHive registryHive_0, string string_1)
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

	private void method_7(string string_1)
	{
		string[] array = string_1.Split(new char[1] { '\\' });
		switch (array[0])
		{
		case "HKEY_CURRENT_CONFIG":
			intptr_7 = intptr_5;
			break;
		case "HKEY_USERS":
			intptr_7 = intptr_3;
			break;
		case "HKEY_LOCAL_MACHINE":
		case "HKLM":
			intptr_7 = intptr_2;
			break;
		case "HKEY_CURRENT_USER":
		case "HKCU":
			intptr_7 = intptr_1;
			break;
		case "HKEY_CLASSES_ROOT":
		case "HKCR":
			intptr_7 = intptr_0;
			break;
		default:
			intptr_7 = IntPtr.Zero;
			throw new ArgumentException("The registry hive '" + array[0] + "' is not supported", "value");
		}
		string_0 = string.Join("\\", array, 1, array.Length - 1);
	}

	public bool method_8()
	{
		return thread_0 != null;
	}

	public void method_9()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException(null, "This instance is already disposed");
		}
		lock (object_0)
		{
			if (!method_8())
			{
				manualResetEvent_0.Reset();
				thread_0 = new Thread(method_11);
				thread_0.IsBackground = true;
				thread_0.Start();
			}
		}
	}

	public void method_10()
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

	private void method_11()
	{
		try
		{
			method_12();
		}
		catch (Exception exception_)
		{
			vmethod_1(exception_);
		}
		thread_0 = null;
	}

	private void method_12()
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
					num = RegNotifyChangeKeyValue(intptr_, bool_1: true, genum0_0, autoResetEvent.Handle, bool_2: true);
					if (num != 0)
					{
						break;
					}
					if (WaitHandle.WaitAny(waitHandles) == 0)
					{
						vmethod_0();
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
