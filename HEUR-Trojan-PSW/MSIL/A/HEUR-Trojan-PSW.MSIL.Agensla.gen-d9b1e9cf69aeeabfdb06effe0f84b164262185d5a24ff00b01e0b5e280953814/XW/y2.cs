using System.IO;

namespace XW;

public class y2
{
	private Qe St;

	private lA yD;

	private static y2 I6;

	public y2(Qe qe_0, Gp gp_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		St = qe_0;
		yD = new lA(gp_0);
	}

	public void y2(string[] string_0)
	{
		Gp object_ = new Gp();
		try
		{
			Su.nJ(object_, Su.GP);
		}
		catch (IOException)
		{
			Ew.nJ(St, "[CimexUtility-AutoUpdate]Failure to read Configuration file", Ew.MQ);
		}
		int num2 = default(int);
		while (true)
		{
			if (WM.nJ(yD, WM.RI))
			{
				WM.nJ(yD, WM.kf);
				int num = 0;
				if (xQ() != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
			L7.nJ(30, L7.sk);
		}
	}

	public void ES()
	{
		if (!WM.nJ(yD, WM.RI))
		{
			Su.nJ(yD, Su.Od);
		}
	}

	internal static bool wX()
	{
		return I6 == null;
	}

	internal static y2 xQ()
	{
		return I6;
	}
}
