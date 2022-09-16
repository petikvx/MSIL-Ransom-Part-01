using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace vc;

public class RH
{
	private Process o3;

	private Sn Nj;

	internal static RH aU;

	public RH(Sn sn_0)
	{
		OZ.kN(OZ.Ou);
		o3 = null;
		base._002Ector();
		Nj = sn_0;
	}

	public bool SN()
	{
		string text = default(string);
		bool result = default(bool);
		while (true)
		{
			o3 = new Process();
			while (true)
			{
				vA.kN(zF.kN(o3, zF.We), bool_0: true, vA.Cg);
				while (true)
				{
					Gl.kN(zF.kN(o3, zF.We), Xv.kN(Nj, Xv.gY), Gl.uO);
					Gl.kN(zF.kN(o3, zF.We), r6.kN(Xv.kN(Nj, Xv.tz), "svn", r6.yL), Gl.g1);
					Gl.kN(zF.kN(o3, zF.We), "update", Gl.DB);
					vA.kN(zF.kN(o3, zF.We), bool_0: false, vA.Cg);
					vA.kN(zF.kN(o3, zF.We), bool_0: true, vA.WNJ);
					Wb.kN(o3, Wb.rj);
					StringBuilder object_ = new StringBuilder();
					StreamReader object_2 = VNN.kN(o3, VNN.KNZ);
					while (true)
					{
						bool flag = !Wb.kN(object_2, Wb.tN8);
						int num = 4;
						if (b2())
						{
							while (true)
							{
								switch (num)
								{
								case 4:
									if (flag)
									{
										goto IL_004d;
									}
									text = Xv.kN(object_, Xv.NNW);
									num = 0;
									if (!b2())
									{
										continue;
									}
									goto case 1;
								case 3:
									break;
								case 5:
									goto end_IL_008c;
								case 6:
									goto end_IL_0173;
								case 1:
									Gl.kN(HNK.kN(HNK.qNI), "-------SVN OUTPUT-----", Gl.kNE);
									goto IL_01bd;
								case 2:
									goto IL_01bd;
								default:
									return result;
								}
								break;
							}
							break;
						}
						goto IL_01bd;
						IL_004d:
						string string_ = Xv.kN(object_2, Xv.J8);
						TNu.kN(object_, string_, TNu.zNv);
						continue;
						IL_01bd:
						Gl.kN(HNK.kN(HNK.qNI), text, Gl.kNE);
						bool flag2 = false;
						if (aI.kN(text, new char[1] { '\n' }, aI.TE).Length > 2)
						{
							flag2 = true;
						}
						YW.kN(o3, YW.pV);
						return flag2 && wk.kN(o3, wk.xm) == 0;
					}
					continue;
					end_IL_008c:
					break;
				}
				continue;
				end_IL_0173:
				break;
			}
		}
	}

	public void cu()
	{
		if (o3 != null)
		{
			YW.kN(o3, YW.Ns);
		}
		o3 = null;
	}

	[SpecialName]
	public bool Jl()
	{
		return o3 == null || Wb.kN(o3, Wb.oG);
	}

	internal static bool b2()
	{
		return aU == null;
	}

	internal static RH Iy()
	{
		return aU;
	}
}
