using System;
using System.IO;
using System.Runtime.CompilerServices;
using A6yJVNZuoAn9NC1LAS;

namespace AESxWin.Helpers;

public static class Log
{
	public static object _locker = new object();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteLog(string path, string text)
	{
		//Discarded unreachable code: IL_0005, IL_0071
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			lock (_locker)
			{
				_ = 0;
				int num;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 2;
				}
				else
				{
					num = 3;
					if (1 == 0)
					{
						return;
					}
				}
				switch (num)
				{
				case 0:
				case 2:
					File.AppendAllText(path, string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2248), DateTime.Now.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2252)), text + Environment.NewLine));
					break;
				case 3:
					break;
				}
			}
		}
		catch
		{
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
