using System;
using System.Windows.Forms;

public static class GClass0
{
	private static GClass0 MapItem;

	[STAThread]
	public static void Main()
	{
		while (true)
		{
			Console.WriteLine(Application.get_ExecutablePath());
			while (true)
			{
				int num = 1;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_d3e3b107f8904fb69ad941560b17473e == 0)
				{
					goto IL_0015;
				}
				goto IL_002e;
				IL_002e:
				switch (num)
				{
				case 1:
				case 7:
					break;
				default:
					goto IL_0015;
				case 5:
					continue;
				case 6:
					goto end_IL_0055;
				case 2:
				case 3:
					return;
				}
				goto IL_0003;
				IL_0003:
				Manager.LogoutFacade();
				num = 0;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_3c87806b12d7438cba956510142600ea == 0)
				{
					goto IL_0015;
				}
				goto IL_002e;
				IL_0015:
				Console.WriteLine(Application.get_StartupPath());
				num = 2;
				if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_774b9210d98142ebb4413559daae5a44 == 0)
				{
					goto IL_0003;
				}
				goto IL_002e;
				continue;
				end_IL_0055:
				break;
			}
		}
	}

	internal static bool CancelItem()
	{
		return MapItem == null;
	}

	internal static GClass0 ConnectItem()
	{
		return MapItem;
	}
}
