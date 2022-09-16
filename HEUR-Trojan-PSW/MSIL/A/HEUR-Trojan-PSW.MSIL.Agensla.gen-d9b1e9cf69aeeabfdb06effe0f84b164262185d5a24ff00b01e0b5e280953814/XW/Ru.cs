using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace XW;

public class Ru
{
	private int sWM;

	private Gp iWK;

	private Process IWT;

	internal static Ru UR;

	public Ru(Gp gp_0)
	{
		G3.nJ(G3.By);
		sWM = 0;
		IWT = null;
		base._002Ector();
		iWK = gp_0;
	}

	public bool vWd()
	{
		IWT = new Process();
		JJO.nJ(pyj.nJ(IWT, pyj.Ly8), bool_0: true, JJO.jyT);
		Ew.nJ(pyj.nJ(IWT, pyj.Ly8), Xi.nJ(iWK, Xi.Hy5), Ew.byl);
		int num3 = default(int);
		bool result = default(bool);
		while (true)
		{
			string[] array = GyZ.nJ(Xi.nJ(iWK, Xi.NyC), new char[1] { ' ' }, GyZ.fyB);
			Ew.nJ(pyj.nJ(IWT, pyj.Ly8), array[0], Ew.wyL);
			string string_ = "";
			int num = 1;
			while (true)
			{
				bool flag = num < array.Length;
				while (!flag)
				{
					Ew.nJ(pyj.nJ(IWT, pyj.Ly8), string_, Ew.zy2);
					sWM = IJa.nJ(IWT, IJa.myS);
					int num2 = 1;
					if (Ov() != null)
					{
						num2 = num3;
					}
					switch (num2)
					{
					case 3:
						continue;
					case 2:
						break;
					case 1:
						WM.nJ(IWT, WM.myz);
						Pyq.nJ(IWT, Pyq.hXO);
						return IJa.nJ(IWT, IJa.cXJ) == 0;
					default:
						return result;
					}
					goto end_IL_00cf;
				}
				string_ = Lyn.nJ(string_, array[num], Lyn.cyo);
				num++;
				continue;
				end_IL_00cf:
				break;
			}
		}
	}

	public void FWV()
	{
		if (IWT != null)
		{
			Pyq.nJ(IWT, Pyq.AX3);
		}
		Process[] array = iXy.nJ(iXy.IXX);
		int num = 0;
		if (!Er())
		{
			goto IL_0083;
		}
		goto IL_009b;
		IL_0083:
		int num2 = default(int);
		num = num2;
		goto IL_009b;
		IL_009b:
		int i = default(int);
		do
		{
			IL_009b_2:
			switch (num)
			{
			case 1:
				break;
			default:
				i = 0;
				num = 0;
				if (!Er())
				{
					goto IL_009b_2;
				}
				break;
			case 2:
				return;
			}
			for (; i < array.Length; i++)
			{
				Process object_ = array[i];
				if (IJa.nJ(object_, IJa.myS) == sWM)
				{
					Pyq.nJ(object_, Pyq.AX3);
					break;
				}
			}
			IWT = null;
			num = 2;
		}
		while (Er());
		goto IL_0083;
	}

	[SpecialName]
	public bool fWR()
	{
		return IWT == null || WM.nJ(IWT, WM.WXc);
	}

	internal static bool Er()
	{
		return UR == null;
	}

	internal static Ru Ov()
	{
		return UR;
	}
}
