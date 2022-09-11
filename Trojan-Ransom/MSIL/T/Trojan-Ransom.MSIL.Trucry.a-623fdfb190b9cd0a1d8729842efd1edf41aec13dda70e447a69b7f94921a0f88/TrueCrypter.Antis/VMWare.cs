using System;
using System.IO;

namespace TrueCrypter.Antis;

public class VMWare
{
	public bool IsRunning()
	{
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\vmGuestLib.dll") || File.Exists(Environment.GetEnvironmentVariable("windir") + "\\vmbusres.dll"))
		{
			return true;
		}
		return false;
	}
}
