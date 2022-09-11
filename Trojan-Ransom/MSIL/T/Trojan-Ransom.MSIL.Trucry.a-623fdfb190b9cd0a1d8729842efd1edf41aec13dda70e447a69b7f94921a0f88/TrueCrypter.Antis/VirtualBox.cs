using System.IO;

namespace TrueCrypter.Antis;

public class VirtualBox
{
	public bool IsRunning()
	{
		if (File.Exists("C:\\Windows\\System32\\VBoxControl.exe"))
		{
			return true;
		}
		return false;
	}
}
