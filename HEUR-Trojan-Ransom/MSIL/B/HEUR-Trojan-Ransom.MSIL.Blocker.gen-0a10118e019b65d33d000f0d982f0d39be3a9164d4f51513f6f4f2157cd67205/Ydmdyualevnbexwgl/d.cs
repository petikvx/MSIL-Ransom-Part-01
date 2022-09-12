using System;
using System.Net;
using System.Windows.Forms;

namespace Ydmdyualevnbexwgl;

public static class d
{
	internal static d DisableException;

	[STAThread]
	public static void a(string[] args)
	{
		while (true)
		{
			if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_501dbc0dddf84f97b03eecde4224c0fa == 0)
			{
				switch (0)
				{
				case 3:
					break;
				case 2:
					goto IL_002e;
				case 1:
				case 4:
					goto IL_003c;
				default:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_002e;
			IL_003c:
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			}
			catch
			{
			}
			break;
			IL_002e:
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			goto IL_003c;
			continue;
			end_IL_0001:
			break;
		}
		Application.Run((Form)(object)new c());
	}

	internal static bool OrderException()
	{
		return DisableException == null;
	}

	internal static d ConnectException()
	{
		return DisableException;
	}
}
