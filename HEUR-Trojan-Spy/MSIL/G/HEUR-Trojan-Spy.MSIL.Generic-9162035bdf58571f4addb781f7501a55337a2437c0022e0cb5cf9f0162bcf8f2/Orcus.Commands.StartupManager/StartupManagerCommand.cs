using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Orcus.Plugins;
using Orcus.Shared.Commands.StartupManager;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.StartupManager;

public class StartupManagerCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I4, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		StartupManagerCommunication val = (StartupManagerCommunication)parameter[0];
		switch ((int)val)
		{
		case 0:
			((Command)this).ResponseBytes((byte)2, new Serializer(typeof(List<AutostartProgramInfo>)).Serialize((object)AutostartManager.GetAllAutostartPrograms()), connectionInfo);
			break;
		case 1:
		{
			AutostartManager.RemoveAutostartEntry((AutostartLocation)parameter[2], Encoding.UTF8.GetString(parameter, 3, parameter.Length - 3), parameter[1] == 1);
			byte[] array = new byte[parameter.Length];
			array[0] = 7;
			Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
			connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		case 3:
		{
			byte[] array;
			try
			{
				AutostartManager.ChangeAutostartEntry((AutostartLocation)parameter[1], Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2), isEnabled: true);
			}
			catch (Exception ex2)
			{
				if (!(ex2 is SecurityException) && !(ex2 is UnauthorizedAccessException))
				{
					throw;
				}
				array = new byte[parameter.Length];
				array[0] = 8;
				Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
				connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
				break;
			}
			array = new byte[parameter.Length];
			array[0] = 6;
			Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
			connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
			break;
		}
		case 4:
		{
			byte[] array;
			try
			{
				AutostartManager.ChangeAutostartEntry((AutostartLocation)parameter[1], Encoding.UTF8.GetString(parameter, 2, parameter.Length - 2), isEnabled: false);
			}
			catch (Exception ex)
			{
				if (!(ex is SecurityException) && !(ex is UnauthorizedAccessException))
				{
					throw;
				}
				array = new byte[parameter.Length];
				array[0] = 8;
				Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
				connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
				break;
			}
			array = new byte[parameter.Length];
			array[0] = 5;
			Array.Copy(parameter, 1, array, 1, parameter.Length - 1);
			connectionInfo.CommandResponse((Command)(object)this, array, (PackageCompression)0);
			break;
		}
		}
	}

	protected override uint GetId()
	{
		return 25u;
	}
}
