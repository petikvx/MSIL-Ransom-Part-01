using System.IO;
using System.ServiceProcess;

namespace XW;

public class Tq : ServiceBase
{
	private lA DF;

	private static Tq Qw;

	public Tq()
	{
		G3.nJ(G3.By);
		DF = null;
		((ServiceBase)this)._002Ector();
	}

	protected override void OnStart(string[] args)
	{
		Gp gp = new Gp();
		DF = new lA(gp);
		try
		{
			Su.nJ(gp, Su.GP);
		}
		catch (IOException)
		{
			Ew.nJ(St.nJ(this, St.Op), "[CimexUtility-AutoUpdate]Failure to read Configuration file", Ew.ih);
		}
		int num2 = default(int);
		while (true)
		{
			int num;
			if (WM.nJ(DF, WM.RI))
			{
				WM.nJ(DF, WM.kf);
				num = 1;
				if (HZ() == null)
				{
					goto IL_0057;
				}
			}
			goto IL_003f;
			IL_0057:
			switch (num)
			{
			case 1:
				break;
			default:
				continue;
			}
			goto IL_003f;
			IL_003f:
			L7.nJ(30, L7.sk);
			num = 0;
			if (HZ() != null)
			{
				num = num2;
			}
			goto IL_0057;
		}
	}

	protected override void OnStop()
	{
		bool flag = DF != null && !WM.nJ(DF, WM.RI);
		if (HZ() != null)
		{
			switch (0)
			{
			}
		}
		if (flag)
		{
			Su.nJ(DF, Su.Od);
		}
	}

	internal static bool fY()
	{
		return Qw == null;
	}

	internal static Tq HZ()
	{
		return Qw;
	}
}
