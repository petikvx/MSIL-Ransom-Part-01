using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace vc;

public class If
{
	private int HG;

	private Sn z1;

	private Process Ko;

	internal static If b9;

	public If(Sn sn_0)
	{
		OZ.kN(OZ.Ou);
		HG = 0;
		Ko = null;
		base._002Ector();
		z1 = sn_0;
	}

	public bool FS()
	{
		Ko = new Process();
		vA.kN(zF.kN(Ko, zF.We), bool_0: true, vA.Cg);
		Gl.kN(zF.kN(Ko, zF.We), Xv.kN(z1, Xv.rT), Gl.uO);
		string[] array = aI.kN(Xv.kN(z1, Xv.PC), new char[1] { ' ' }, aI.TE);
		Gl.kN(zF.kN(Ko, zF.We), array[0], Gl.g1);
		string string_ = "";
		bool result = default(bool);
		int num2 = default(int);
		while (true)
		{
			for (int i = 1; i < array.Length; i++)
			{
				string_ = r6.kN(string_, array[i], r6.yL);
			}
			Gl.kN(zF.kN(Ko, zF.We), string_, Gl.DB);
			HG = wk.kN(Ko, wk.YX);
			int num = 2;
			if (NV() != null)
			{
				goto IL_0123;
			}
			goto IL_015a;
			IL_015a:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					YW.kN(Ko, YW.pV);
					result = wk.kN(Ko, wk.xm) == 0;
					num = 1;
					if (NV() == null)
					{
						continue;
					}
					goto case 1;
				case 3:
					goto end_IL_015a;
				case 1:
					return result;
				}
				Wb.kN(Ko, Wb.rj);
				num = 0;
				if (NV() == null)
				{
					continue;
				}
				goto IL_0123;
				continue;
				end_IL_015a:
				break;
			}
			continue;
			IL_0123:
			num = num2;
			goto IL_015a;
		}
	}

	public void uy()
	{
		if (Ko != null)
		{
			YW.kN(Ko, YW.Ns);
		}
		Process[] array = Ky.kN(Ky.HH);
		int num = 1;
		if (NV() != null)
		{
			goto IL_0080;
		}
		goto IL_0084;
		IL_0080:
		int num2 = default(int);
		num = num2;
		goto IL_0084;
		IL_0084:
		int num3 = default(int);
		do
		{
			IL_0084_2:
			Process object_;
			switch (num)
			{
			case 1:
				num3 = 0;
				num = 0;
				if (NV() != null)
				{
					goto IL_0084_2;
				}
				goto default;
			default:
				while (num3 < array.Length)
				{
					object_ = array[num3];
					if (wk.kN(object_, wk.YX) != HG)
					{
						num3++;
						continue;
					}
					goto IL_0097;
				}
				break;
			case 2:
				{
					Ko = null;
					return;
				}
				IL_0097:
				YW.kN(object_, YW.Ns);
				goto case 2;
			}
			num = 2;
		}
		while (NV() == null);
		goto IL_0080;
	}

	[SpecialName]
	public bool Wv()
	{
		return Ko == null || Wb.kN(Ko, Wb.oG);
	}

	internal static bool GD()
	{
		return b9 == null;
	}

	internal static If NV()
	{
		return b9;
	}
}
