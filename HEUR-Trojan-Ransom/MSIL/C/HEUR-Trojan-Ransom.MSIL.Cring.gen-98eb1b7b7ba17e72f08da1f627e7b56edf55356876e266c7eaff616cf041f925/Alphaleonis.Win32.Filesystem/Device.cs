using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Alphaleonis.Win32.Network;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

public static class Device
{
	[SecurityCritical]
	public static IEnumerable<DeviceInfo> EnumerateDevices(DeviceGuid deviceGuid)
	{
		return EnumerateDevicesCore(null, deviceGuid, getAllProperties: true);
	}

	[SecurityCritical]
	public static IEnumerable<DeviceInfo> EnumerateDevices(string hostName, DeviceGuid deviceGuid)
	{
		return EnumerateDevicesCore(hostName, deviceGuid, getAllProperties: true);
	}

	[SecurityCritical]
	internal static IEnumerable<DeviceInfo> EnumerateDevicesCore(string hostName, DeviceGuid deviceGuid, bool getAllProperties)
	{
		if (Utils.IsNullOrWhiteSpace(hostName))
		{
			hostName = Environment.MachineName;
		}
		int lastError = NativeMethods.CM_Connect_MachineW(Host.GetUncName(hostName), out var safeMachineHandle);
		NativeMethods.IsValidHandle(safeMachineHandle, lastError);
		Guid classGuid = new Guid(Utils.GetEnumDescription(deviceGuid));
		using (safeMachineHandle)
		{
			using NativeMethods.SafeSetupDiClassDevsExHandle safeHandle = NativeMethods.SetupDiGetClassDevsEx(ref classGuid, IntPtr.Zero, IntPtr.Zero, NativeMethods.SetupDiGetClassDevsExFlags.Present | NativeMethods.SetupDiGetClassDevsExFlags.DeviceInterface, IntPtr.Zero, hostName, IntPtr.Zero);
			NativeMethods.IsValidHandle(safeHandle, Marshal.GetLastWin32Error());
			uint memberInterfaceIndex = 0u;
			uint interfaceStructSize = (uint)Marshal.SizeOf(typeof(NativeMethods.SP_DEVICE_INTERFACE_DATA));
			uint dataStructSize = (uint)Marshal.SizeOf(typeof(NativeMethods.SP_DEVINFO_DATA));
			while (true)
			{
				NativeMethods.SP_DEVICE_INTERFACE_DATA sP_DEVICE_INTERFACE_DATA = default(NativeMethods.SP_DEVICE_INTERFACE_DATA);
				sP_DEVICE_INTERFACE_DATA.cbSize = interfaceStructSize;
				NativeMethods.SP_DEVICE_INTERFACE_DATA deviceInterfaceData = sP_DEVICE_INTERFACE_DATA;
				bool num = NativeMethods.SetupDiEnumDeviceInterfaces(safeHandle, IntPtr.Zero, ref classGuid, memberInterfaceIndex++, ref deviceInterfaceData);
				lastError = Marshal.GetLastWin32Error();
				if (!num)
				{
					break;
				}
				NativeMethods.SP_DEVINFO_DATA sP_DEVINFO_DATA = default(NativeMethods.SP_DEVINFO_DATA);
				sP_DEVINFO_DATA.cbSize = dataStructSize;
				NativeMethods.SP_DEVINFO_DATA infoData = sP_DEVINFO_DATA;
				DeviceInfo deviceInfo = new DeviceInfo(hostName)
				{
					DevicePath = GetDeviceInterfaceDetail(safeHandle, ref deviceInterfaceData, ref infoData).DevicePath
				};
				if (getAllProperties)
				{
					deviceInfo.InstanceId = GetDeviceInstanceId(safeMachineHandle, hostName, infoData);
					SetDeviceProperties(safeHandle, deviceInfo, infoData);
				}
				else
				{
					SetMinimalDeviceProperties(safeHandle, deviceInfo, infoData);
				}
				yield return deviceInfo;
			}
			if (lastError != 0L && lastError != 259L)
			{
				NativeError.ThrowException(lastError, hostName);
			}
		}
	}

	[SecurityCritical]
	private static string GetDeviceInstanceId(SafeCmConnectMachineHandle safeMachineHandle, string hostName, NativeMethods.SP_DEVINFO_DATA diData)
	{
		int num = NativeMethods.CM_Get_Parent_Ex(out var _, diData.DevInst, 0u, safeMachineHandle);
		if (num != 0L)
		{
			NativeError.ThrowException(num, hostName);
		}
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(512);
		num = NativeMethods.CM_Get_Device_ID_ExW(diData.DevInst, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, 0u, safeMachineHandle);
		if (num != 0L)
		{
			NativeError.ThrowException(num, hostName);
		}
		return safeGlobalMemoryBufferHandle.PtrToStringUni();
	}

	[SecurityCritical]
	private static NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA GetDeviceInterfaceDetail(SafeHandle safeHandle, ref NativeMethods.SP_DEVICE_INTERFACE_DATA interfaceData, ref NativeMethods.SP_DEVINFO_DATA infoData)
	{
		NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA sP_DEVICE_INTERFACE_DETAIL_DATA = default(NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA);
		sP_DEVICE_INTERFACE_DETAIL_DATA.cbSize = ((IntPtr.Size == 4) ? 6u : 8u);
		NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData = sP_DEVICE_INTERFACE_DETAIL_DATA;
		bool num = NativeMethods.SetupDiGetDeviceInterfaceDetail(safeHandle, ref interfaceData, ref deviceInterfaceDetailData, (uint)Marshal.SizeOf((object)deviceInterfaceDetailData), IntPtr.Zero, ref infoData);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		return deviceInterfaceDetailData;
	}

	[SecurityCritical]
	private static string GetDeviceRegistryProperty(SafeHandle safeHandle, NativeMethods.SP_DEVINFO_DATA infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum property)
	{
		int num = 512;
		while (true)
		{
			using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(num);
			bool num2 = NativeMethods.SetupDiGetDeviceRegistryProperty(safeHandle, ref infoData, property, IntPtr.Zero, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, IntPtr.Zero);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (num2)
			{
				string text = safeGlobalMemoryBufferHandle.PtrToStringUni();
				return (!Utils.IsNullOrWhiteSpace(text)) ? text.Trim() : null;
			}
			if (lastWin32Error == 13L)
			{
				return null;
			}
			num = GetDoubledBufferSizeOrThrowException(lastWin32Error, safeGlobalMemoryBufferHandle, num, property.ToString());
		}
	}

	[SecurityCritical]
	private static void SetDeviceProperties(SafeHandle safeHandle, DeviceInfo deviceInfo, NativeMethods.SP_DEVINFO_DATA infoData)
	{
		SetMinimalDeviceProperties(safeHandle, deviceInfo, infoData);
		deviceInfo.CompatibleIds = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.CompatibleIds);
		deviceInfo.Driver = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.Driver);
		deviceInfo.EnumeratorName = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.EnumeratorName);
		deviceInfo.HardwareId = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.HardwareId);
		deviceInfo.LocationInformation = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.LocationInformation);
		deviceInfo.LocationPaths = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.LocationPaths);
		deviceInfo.Manufacturer = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.Manufacturer);
		deviceInfo.Service = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.Service);
	}

	[SecurityCritical]
	private static void SetMinimalDeviceProperties(SafeHandle safeHandle, DeviceInfo deviceInfo, NativeMethods.SP_DEVINFO_DATA infoData)
	{
		deviceInfo.BaseContainerId = new Guid(GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.BaseContainerId));
		deviceInfo.ClassGuid = new Guid(GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.ClassGuid));
		deviceInfo.DeviceClass = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.Class);
		deviceInfo.DeviceDescription = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.DeviceDescription);
		deviceInfo.FriendlyName = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.FriendlyName);
		deviceInfo.PhysicalDeviceObjectName = GetDeviceRegistryProperty(safeHandle, infoData, NativeMethods.SetupDiGetDeviceRegistryPropertyEnum.PhysicalDeviceObjectName);
	}

	[SecurityCritical]
	internal static int GetDoubledBufferSizeOrThrowException(int lastError, SafeHandle safeBuffer, int bufferSize, string pathForException)
	{
		if (safeBuffer != null && !safeBuffer.IsClosed)
		{
			safeBuffer.Close();
		}
		if (lastError != 122 && lastError != 234)
		{
			NativeMethods.IsValidHandle(safeBuffer, lastError, string.Format(CultureInfo.InvariantCulture, "Buffer size: {0}. Path: {1}", new object[2]
			{
				bufferSize.ToString(CultureInfo.InvariantCulture),
				pathForException
			}));
		}
		else
		{
			bufferSize *= 2;
		}
		return bufferSize;
	}

	[SecurityCritical]
	private static void InvokeIoControlUnknownSize<T>(SafeFileHandle handle, uint controlCode, T input, uint increment = 128u)
	{
		uint nInBufferSize = (uint)Marshal.SizeOf((object)input);
		uint num = increment;
		while (true)
		{
			byte[] lpOutBuffer = new byte[num];
			uint lpBytesReturned;
			bool num2 = NativeMethods.DeviceIoControl_2(handle, controlCode, input, nInBufferSize, lpOutBuffer, num, out lpBytesReturned, IntPtr.Zero);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (num2)
			{
				break;
			}
			uint num3 = (uint)lastWin32Error;
			if (num3 != 122 && num3 != 234)
			{
				if (lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error);
				}
			}
			else
			{
				num += increment;
			}
		}
	}

	[SecurityCritical]
	internal static void ToggleCompressionCore(KernelTransaction transaction, string path, bool compress, PathFormat pathFormat)
	{
		using SafeFileHandle handle = File.CreateFileCore(transaction, null, path, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.Modify, FileShare.None, checkPath: true, continueOnException: false, pathFormat);
		InvokeIoControlUnknownSize(handle, 639040u, compress ? 1 : 0);
	}

	internal static void CreateDirectoryJunction(SafeFileHandle safeHandle, string directoryPath)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(Path.NonInterpretedPathPrefix + Path.GetRegularPathCore(directoryPath, GetFullPathOptions.AddTrailingDirectorySeparator, allowEmpty: false));
		NativeMethods.ReparseDataBufferHeader reparseDataBufferHeader = default(NativeMethods.ReparseDataBufferHeader);
		reparseDataBufferHeader.ReparseTag = ReparsePointTag.MountPoint;
		reparseDataBufferHeader.ReparseDataLength = (ushort)(bytes.Length + 12);
		NativeMethods.ReparseDataBufferHeader reparseDataBufferHeader2 = reparseDataBufferHeader;
		NativeMethods.MountPointReparseBuffer mountPointReparseBuffer = default(NativeMethods.MountPointReparseBuffer);
		mountPointReparseBuffer.SubstituteNameOffset = 0;
		mountPointReparseBuffer.SubstituteNameLength = (ushort)bytes.Length;
		mountPointReparseBuffer.PrintNameOffset = (ushort)(bytes.Length + 2);
		mountPointReparseBuffer.PrintNameLength = 0;
		NativeMethods.MountPointReparseBuffer mountPointReparseBuffer2 = mountPointReparseBuffer;
		NativeMethods.REPARSE_DATA_BUFFER rEPARSE_DATA_BUFFER = default(NativeMethods.REPARSE_DATA_BUFFER);
		rEPARSE_DATA_BUFFER.ReparseTag = reparseDataBufferHeader2.ReparseTag;
		rEPARSE_DATA_BUFFER.ReparseDataLength = reparseDataBufferHeader2.ReparseDataLength;
		rEPARSE_DATA_BUFFER.SubstituteNameOffset = mountPointReparseBuffer2.SubstituteNameOffset;
		rEPARSE_DATA_BUFFER.SubstituteNameLength = mountPointReparseBuffer2.SubstituteNameLength;
		rEPARSE_DATA_BUFFER.PrintNameOffset = mountPointReparseBuffer2.PrintNameOffset;
		rEPARSE_DATA_BUFFER.PrintNameLength = mountPointReparseBuffer2.PrintNameLength;
		rEPARSE_DATA_BUFFER.PathBuffer = new byte[16368];
		NativeMethods.REPARSE_DATA_BUFFER rEPARSE_DATA_BUFFER2 = rEPARSE_DATA_BUFFER;
		bytes.CopyTo(rEPARSE_DATA_BUFFER2.PathBuffer, 0);
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf((object)rEPARSE_DATA_BUFFER2));
		safeGlobalMemoryBufferHandle.StructureToPtr(rEPARSE_DATA_BUFFER2, deleteOld: false);
		uint lpBytesReturned;
		bool num = NativeMethods.DeviceIoControl_1(safeHandle, 589988u, safeGlobalMemoryBufferHandle, (uint)(bytes.Length + 20), IntPtr.Zero, 0u, out lpBytesReturned, IntPtr.Zero);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, directoryPath);
		}
	}

	internal static void DeleteDirectoryJunction(SafeFileHandle safeHandle)
	{
		NativeMethods.REPARSE_DATA_BUFFER rEPARSE_DATA_BUFFER = default(NativeMethods.REPARSE_DATA_BUFFER);
		rEPARSE_DATA_BUFFER.ReparseTag = ReparsePointTag.MountPoint;
		rEPARSE_DATA_BUFFER.ReparseDataLength = 0;
		rEPARSE_DATA_BUFFER.PathBuffer = new byte[16368];
		NativeMethods.REPARSE_DATA_BUFFER rEPARSE_DATA_BUFFER2 = rEPARSE_DATA_BUFFER;
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf((object)rEPARSE_DATA_BUFFER2));
		safeGlobalMemoryBufferHandle.StructureToPtr(rEPARSE_DATA_BUFFER2, deleteOld: false);
		uint lpBytesReturned;
		bool num = NativeMethods.DeviceIoControl_1(safeHandle, 589996u, safeGlobalMemoryBufferHandle, 8u, IntPtr.Zero, 0u, out lpBytesReturned, IntPtr.Zero);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error);
		}
	}

	[SecurityCritical]
	internal static LinkTargetInfo GetLinkTargetInfo(SafeFileHandle safeHandle, string reparsePath)
	{
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = GetLinkTargetData(safeHandle, reparsePath);
		NativeMethods.ReparseDataBufferHeader reparseDataBufferHeader = safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.ReparseDataBufferHeader>(0);
		int num = (int)Marshal.OffsetOf(typeof(NativeMethods.ReparseDataBufferHeader), "data");
		int num2 = (int)(num + ((reparseDataBufferHeader.ReparseTag == ReparsePointTag.MountPoint) ? Marshal.OffsetOf(typeof(NativeMethods.MountPointReparseBuffer), "data") : Marshal.OffsetOf(typeof(NativeMethods.SymbolicLinkReparseBuffer), "data")).ToInt64());
		byte[] array = new byte[16384 - num2];
		switch (reparseDataBufferHeader.ReparseTag)
		{
		default:
			throw new UnrecognizedReparsePointException(reparsePath);
		case ReparsePointTag.SymLink:
		{
			NativeMethods.SymbolicLinkReparseBuffer symbolicLinkReparseBuffer = safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.SymbolicLinkReparseBuffer>(num);
			safeGlobalMemoryBufferHandle.CopyTo(num2, array);
			return new SymbolicLinkTargetInfo(Encoding.Unicode.GetString(array, symbolicLinkReparseBuffer.SubstituteNameOffset, symbolicLinkReparseBuffer.SubstituteNameLength), Encoding.Unicode.GetString(array, symbolicLinkReparseBuffer.PrintNameOffset, symbolicLinkReparseBuffer.PrintNameLength), symbolicLinkReparseBuffer.Flags);
		}
		case ReparsePointTag.MountPoint:
		{
			NativeMethods.MountPointReparseBuffer mountPointReparseBuffer = safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.MountPointReparseBuffer>(num);
			safeGlobalMemoryBufferHandle.CopyTo(num2, array);
			return new LinkTargetInfo(Encoding.Unicode.GetString(array, mountPointReparseBuffer.SubstituteNameOffset, mountPointReparseBuffer.SubstituteNameLength), Encoding.Unicode.GetString(array, mountPointReparseBuffer.PrintNameOffset, mountPointReparseBuffer.PrintNameLength));
		}
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing is controlled.")]
	[SecurityCritical]
	private static SafeGlobalMemoryBufferHandle GetLinkTargetData(SafeFileHandle safeHandle, string reparsePath)
	{
		SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(16384);
		while (true)
		{
			uint lpBytesReturned;
			bool num = NativeMethods.DeviceIoControl(safeHandle, 589992u, IntPtr.Zero, 0u, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity, out lpBytesReturned, IntPtr.Zero);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (num)
			{
				break;
			}
			uint num2 = (uint)lastWin32Error;
			if (num2 != 122 && num2 != 234)
			{
				if (lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error, reparsePath);
				}
			}
			else if (safeGlobalMemoryBufferHandle.Capacity < lpBytesReturned)
			{
				safeGlobalMemoryBufferHandle.Close();
			}
		}
		return safeGlobalMemoryBufferHandle;
	}
}
