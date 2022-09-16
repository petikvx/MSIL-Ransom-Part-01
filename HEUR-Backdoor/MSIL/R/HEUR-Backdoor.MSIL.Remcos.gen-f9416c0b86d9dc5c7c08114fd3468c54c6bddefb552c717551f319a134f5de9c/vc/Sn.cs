using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace vc;

public class Sn
{
	private string Kg;

	private Dictionary<string, string> kZ;

	private static Sn cC;

	public Sn()
	{
		OZ.kN(OZ.Ou);
		Kg = "config.txt";
		base._002Ector();
		kZ = new Dictionary<string, string>();
	}

	public void vc()
	{
		int num = 5;
		int num3 = default(int);
		string[] array2 = default(string[]);
		bool flag = default(bool);
		while (true)
		{
			StreamReader object_ = new StreamReader(Kg);
			while (true)
			{
				string object_2 = Xv.kN(object_, Xv.J8);
				YW.kN(object_, YW.RK);
				string[] array = aI.kN(object_2, new char[1] { '\n' }, aI.TE);
				int num2 = 0;
				if (!YT())
				{
					num2 = num;
				}
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (num3 < array.Length)
						{
							string object_3 = array[num3];
							array2 = n0.kN(object_3, I4.kN(":", I4.ho), 2, StringSplitOptions.None, n0.dc);
							if (kZ.ContainsKey(array2[0]))
							{
								goto IL_008c;
							}
							flag = array2.Length >= 2;
							num2 = 2;
							if (n4() == null)
							{
								continue;
							}
							goto case 1;
						}
						kZ["svn_path"] = Xv.kN(this, Xv.Yw);
						kZ["game_folder"] = Xv.kN(this, Xv.Y3);
						kZ["hlds_workdir"] = Xv.kN(this, Xv.Vd);
						return;
					case 1:
						if (array2.Length == 1)
						{
							kZ.Add(Xv.kN(array2[0], Xv.zS), "");
						}
						goto IL_008c;
					case 2:
						if (flag)
						{
							kZ.Add(Xv.kN(array2[0], Xv.zS), Xv.kN(array2[1], Xv.zS));
							goto IL_008c;
						}
						goto case 1;
					default:
						num3 = 0;
						num2 = 3;
						if (n4() == null)
						{
							continue;
						}
						goto case 1;
					case 4:
						break;
					case 5:
						goto end_IL_0100;
						IL_008c:
						num3++;
						goto case 3;
					}
					break;
				}
				continue;
				end_IL_0100:
				break;
			}
		}
	}

	public void Sn()
	{
		StreamWriter object_ = new StreamWriter(Kg);
		foreach (KeyValuePair<string, string> item in kZ)
		{
			Gl.kN(object_, Hh.kN(item.Key, ":", item.Value, Hh.hr), Gl.rt);
		}
		YW.kN(object_, YW.Qa);
	}

	private static string cP(string string_0)
	{
		string text = w9.kN(w9.kN(string_0, '\\', Path.DirectorySeparatorChar, w9.gU), '/', Path.DirectorySeparatorChar, w9.gU);
		string object_ = text;
		char char_ = Path.DirectorySeparatorChar;
		if (!UR.kN(object_, zx.kN(ref char_, zx.Ff), UR.hq))
		{
			string string_ = text;
			char_ = Path.DirectorySeparatorChar;
			text = r6.kN(string_, zx.kN(ref char_, zx.Ff), r6.yL);
		}
		return text;
	}

	[SpecialName]
	public string If()
	{
		return bD.kN(kZ["svn_path"], bD.xi);
	}

	[SpecialName]
	public string RH()
	{
		return bD.kN(kZ["game_folder"], bD.xi);
	}

	[SpecialName]
	public string gV()
	{
		return kZ["hlds_command"];
	}

	[SpecialName]
	public string fL()
	{
		return bD.kN(kZ["hlds_workdir"], bD.xi);
	}

	[SpecialName]
	public int jh()
	{
		return tQ.kN(kZ["update_interval"], tQ.ln);
	}

	[SpecialName]
	public Dictionary<string, string> nT()
	{
		return kZ;
	}

	[SpecialName]
	public void AD(Dictionary<string, string> dictionary_0)
	{
		kZ = dictionary_0;
	}

	internal static bool YT()
	{
		return cC == null;
	}

	internal static Sn n4()
	{
		return cC;
	}
}
