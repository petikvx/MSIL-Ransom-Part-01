using System;
using System.Runtime.InteropServices;

namespace eSettings.Model.Library;

public class INT15
{
	[DllImport("INT15.dll")]
	public static extern IntPtr GetBootSequence();

	[DllImport("INT15.dll")]
	public static extern bool SetBootSequenceNB(byte[] sequence, int length);

	[DllImport("INT15.dll")]
	public static extern bool SetBootSequenceDT(int preset);

	[DllImport("INT15.dll")]
	public static extern bool IsBIOSPasswordExist(BIOSUserLevel userlevel);

	[DllImport("INT15.dll")]
	public static extern bool SetBIOSPassword(BIOSUserLevel userlevel, char[] password);

	[DllImport("INT15.dll")]
	public static extern bool RemoveBIOSPassword(BIOSUserLevel userlevel);

	[DllImport("INT15.dll")]
	public static extern bool CheckBIOSPassword(BIOSUserLevel userlevel, char[] password);

	[DllImport("INT15.dll")]
	public static extern bool GetFastBoot();

	[DllImport("INT15.dll")]
	public static extern bool SetFastBoot(bool state);

	[DllImport("INT15.dll")]
	public static extern IntPtr GetAssetTag();

	[DllImport("INT15.dll")]
	public static extern bool SetAssetTag(char[] asset);

	[DllImport("INT15.dll")]
	public static extern IntPtr GetSerialPortStatus(int portNumber);

	[DllImport("INT15.dll")]
	public static extern IntPtr GetParallelPortStatus();

	[DllImport("INT15.dll")]
	public static extern IntPtr GetCPUInfo();

	[DllImport("INT15.dll")]
	public static extern bool GetD2DBIOS();

	[DllImport("INT15.dll")]
	public static extern int GetOBRState();

	[DllImport("INT15.dll")]
	public static extern bool ClearOBRState();
}
