using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace XW;

public class Gp
{
	private string CWn;

	private Dictionary<string, string> mWX;

	internal static Gp tS;

	public Gp()
	{
		G3.nJ(G3.By);
		CWn = "config.txt";
		base._002Ector();
		mWX = new Dictionary<string, string>();
	}

	public void rWB()
	{
		StreamReader object_ = new StreamReader(CWn);
		string object_2 = Xi.nJ(object_, Xi.jyQ);
		Pyq.nJ(object_, Pyq.fy9);
		string[] array = GyZ.nJ(object_2, new char[1] { '\n' }, GyZ.fyB);
		int num = 0;
		int num2 = 1;
		if (!Um())
		{
			int num3 = default(int);
			num2 = num3;
		}
		string[] array2 = default(string[]);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (num < array.Length)
				{
					string object_3 = array[num];
					array2 = Kyi.nJ(object_3, oyx.nJ(":", oyx.xyR), 2, StringSplitOptions.None, Kyi.zy0);
					if (mWX.ContainsKey(array2[0]))
					{
						goto IL_00ca;
					}
					flag = array2.Length >= 2;
					goto case 2;
				}
				num2 = 0;
				if (z4() == null)
				{
					continue;
				}
				goto default;
			case 2:
				if (!flag)
				{
					if (array2.Length == 1)
					{
						mWX.Add(Xi.nJ(array2[0], Xi.Vym), "");
					}
				}
				else
				{
					mWX.Add(Xi.nJ(array2[0], Xi.Vym), Xi.nJ(array2[1], Xi.Vym));
				}
				goto IL_00ca;
			default:
				mWX["svn_path"] = Xi.nJ(this, Xi.oy1);
				break;
			case 3:
				break;
				IL_00ca:
				num++;
				goto case 1;
			}
			break;
		}
		mWX["game_folder"] = Xi.nJ(this, Xi.UyY);
		mWX["hlds_workdir"] = Xi.nJ(this, Xi.Uyr);
	}

	public void SWo()
	{
		StreamWriter object_ = new StreamWriter(CWn);
		foreach (KeyValuePair<string, string> item in mWX)
		{
			Ew.nJ(object_, FyK.nJ(item.Key, ":", item.Value, FyK.lyg), Ew.MyD);
		}
		Pyq.nJ(object_, Pyq.Oyb);
	}

	private static string qW6(string string_0)
	{
		string text = Sy4.nJ(Sy4.nJ(string_0, '\\', Path.DirectorySeparatorChar, Sy4.VyG), '/', Path.DirectorySeparatorChar, Sy4.VyG);
		string object_ = text;
		char char_ = Path.DirectorySeparatorChar;
		if (!yyv.nJ(object_, zya.nJ(ref char_, zya.jyA), yyv.pyH))
		{
			string string_ = text;
			char_ = Path.DirectorySeparatorChar;
			text = Lyn.nJ(string_, zya.nJ(ref char_, zya.jyA), Lyn.cyo);
		}
		string text2 = text;
		int num = 0;
		if (!Um())
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => text2, 
		};
	}

	[SpecialName]
	public string lWP()
	{
		return P3y.nJ(mWX["svn_path"], P3y.Pye);
	}

	[SpecialName]
	public string IWN()
	{
		return P3y.nJ(mWX["game_folder"], P3y.Pye);
	}

	[SpecialName]
	public string RWE()
	{
		return mWX["hlds_command"];
	}

	[SpecialName]
	public string FWk()
	{
		return P3y.nJ(mWX["hlds_workdir"], P3y.Pye);
	}

	[SpecialName]
	public int uWr()
	{
		return xyE.nJ(mWX["update_interval"], xyE.bys);
	}

	[SpecialName]
	public Dictionary<string, string> yWx()
	{
		return mWX;
	}

	[SpecialName]
	public void zWY(Dictionary<string, string> dictionary_0)
	{
		mWX = dictionary_0;
	}

	internal static bool Um()
	{
		return tS == null;
	}

	internal static Gp z4()
	{
		return tS;
	}
}
