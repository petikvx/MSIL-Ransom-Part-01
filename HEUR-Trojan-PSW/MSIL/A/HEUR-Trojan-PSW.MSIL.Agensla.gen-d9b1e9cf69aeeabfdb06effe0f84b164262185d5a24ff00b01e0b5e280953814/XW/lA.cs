using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace XW;

public class lA
{
	private Process tLi;

	private Gp iLa;

	private static lA tt;

	public lA(Gp gp_0)
	{
		G3.nJ(G3.By);
		tLi = null;
		base._002Ector();
		iLa = gp_0;
	}

	public bool VWz()
	{
		int num = 2;
		bool flag = default(bool);
		StreamReader object_ = default(StreamReader);
		StringBuilder object_2 = default(StringBuilder);
		string text = default(string);
		bool flag2 = default(bool);
		bool result = default(bool);
		while (true)
		{
			tLi = new Process();
			int num2 = 1;
			if (DK() != null)
			{
				goto IL_002f;
			}
			goto IL_016d;
			IL_016d:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
					goto IL_0038;
				default:
					if (flag)
					{
						string string_ = Xi.nJ(object_, Xi.jyQ);
						MXh.nJ(object_2, string_, MXh.cXM);
						break;
					}
					text = Xi.nJ(object_2, Xi.l0);
					Ew.nJ(dXf.nJ(dXf.hX7), "-------SVN OUTPUT-----", Ew.JXk);
					Ew.nJ(dXf.nJ(dXf.hX7), text, Ew.JXk);
					flag2 = false;
					num = 5;
					goto case 5;
				case 2:
					goto end_IL_016d;
				case 5:
					if (GyZ.nJ(text, new char[1] { '\n' }, GyZ.fyB).Length > 2)
					{
						flag2 = true;
					}
					Pyq.nJ(tLi, Pyq.hXO);
					goto case 6;
				case 6:
					return flag2 && IJa.nJ(tLi, IJa.cXJ) == 0;
				case 4:
					return result;
				}
				flag = !WM.nJ(object_, WM.eXI);
				num2 = 0;
				if (DK() == null)
				{
					continue;
				}
				goto IL_002f;
				IL_0038:
				JJO.nJ(pyj.nJ(tLi, pyj.Ly8), bool_0: true, JJO.jyT);
				Ew.nJ(pyj.nJ(tLi, pyj.Ly8), Xi.nJ(iLa, Xi.yXu), Ew.byl);
				Ew.nJ(pyj.nJ(tLi, pyj.Ly8), Lyn.nJ(Xi.nJ(iLa, Xi.XXP), "svn", Lyn.cyo), Ew.wyL);
				Ew.nJ(pyj.nJ(tLi, pyj.Ly8), "update", Ew.zy2);
				JJO.nJ(pyj.nJ(tLi, pyj.Ly8), bool_0: false, JJO.jyT);
				JJO.nJ(pyj.nJ(tLi, pyj.Ly8), bool_0: true, JJO.yXt);
				WM.nJ(tLi, WM.myz);
				object_2 = new StringBuilder();
				object_ = bXp.nJ(tLi, bXp.fXw);
				num2 = 3;
				if (To())
				{
					continue;
				}
				goto IL_002f;
				continue;
				end_IL_016d:
				break;
			}
			continue;
			IL_002f:
			num2 = num;
			goto IL_016d;
		}
	}

	public void XL3()
	{
		if (tLi != null)
		{
			Pyq.nJ(tLi, Pyq.AX3);
		}
		tLi = null;
	}

	[SpecialName]
	public bool ELW()
	{
		bool result = tLi == null || WM.nJ(tLi, WM.WXc);
		if (!To())
		{
			switch (0)
			{
			}
		}
		return result;
	}

	internal static bool To()
	{
		return tt == null;
	}

	internal static lA DK()
	{
		return tt;
	}
}
