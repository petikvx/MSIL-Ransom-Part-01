using System;
using System.Globalization;
using Microsoft.DebugEngineHost;

namespace BD9409C89;

internal class DB7064EFF
{
	private static bool F63C967F1;

	private static bool C2BB7D708;

	private static DateTime B2694B353;

	private static HostLogger DFAF0E97B;

	public static DB7064EFF B8F20CD6F(HostConfigurationStore D3B19FB84)
	{
		DB7064EFF dB7064EFF = new DB7064EFF();
		if (!F63C967F1)
		{
			F63C967F1 = true;
			B2694B353 = DateTime.Now;
			if (DFAF0E97B == null)
			{
				DFAF0E97B = D3B19FB84.GetLogger("EnableKofeDebugDB7064EFF", "Microsoft.KofeDebug.log");
				if (DFAF0E97B != null)
				{
					C2BB7D708 = true;
				}
			}
			dB7064EFF.CD51BAE3D("Initialized log at: " + B2694B353);
		}
		return dB7064EFF;
	}

	public void CD51BAE3D(string D751B7713, params object[] A09858A7C)
	{
		if (C2BB7D708)
		{
			string text = string.Format(CultureInfo.CurrentCulture, D751B7713, A09858A7C);
			string text2 = string.Format(CultureInfo.CurrentCulture, "({0}) {1}", new object[2]
			{
				(int)(DateTime.Now - B2694B353).TotalMilliseconds,
				text
			});
			HostLogger dFAF0E97B = DFAF0E97B;
			if (dFAF0E97B != null)
			{
				dFAF0E97B.WriteLine(text2);
			}
			HostLogger dFAF0E97B2 = DFAF0E97B;
			if (dFAF0E97B2 != null)
			{
				dFAF0E97B2.Flush();
			}
		}
	}
}
