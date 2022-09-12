using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using cH8IXcwQY4Peh2qpAn;
using e1RlCAZENhFg7ngPa8;
using vJiGl01UUJfXfNWas3;

namespace WindowsFormsApp1;

public static class Program
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	public static void Main()
	{
		//Discarded unreachable code: IL_0002, IL_0078
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eMDWoGOlbdrHOQfM3j();
		int num;
		if (lLFeZchRPryoPyIYkV())
		{
			num = 1;
			if (!lLFeZchRPryoPyIYkV())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0085;
		IL_0085:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				goto IL_0044;
			case 0:
			case 1:
				Application.EnableVisualStyles();
				num = 3;
				continue;
			case 2:
			case 4:
				goto IL_006e;
			default:
				num = 5;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_0044:
		Application.SetCompatibleTextRenderingDefault(false);
		xrUtBVoaXtCT6B0w6a.VsLnwSZzbMGHV();
		goto IL_006e;
		IL_006e:
		eGuiSFMLAeSD46WskY.UQqv8A1zYX74w();
		goto IL_002e;
		IL_002e:
		Application.Run((Form)(object)new Form1());
		num = 6;
		if (1 == 0)
		{
			goto IL_0044;
		}
		goto IL_0085;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lLFeZchRPryoPyIYkV()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eMDWoGOlbdrHOQfM3j()
	{
		return true;
	}

	static Program()
	{
		DyyVDbaRvM1YfIq9il.vEB6drODu();
	}
}
