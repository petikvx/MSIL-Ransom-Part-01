using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace XW;

public class OZ
{
	private static OZ BW0;

	private string qWl;

	private static OZ ue;

	[SpecialName]
	public static OZ bWc()
	{
		if (BW0 == null)
		{
			BW0 = new OZ();
		}
		return BW0;
	}

	public OZ()
	{
		G3.nJ(G3.By);
		qWl = "log.txt";
		base._002Ector();
	}

	public OZ(string string_0)
	{
		G3.nJ(G3.By);
		qWl = "log.txt";
		base._002Ector();
		qWl = string_0;
	}

	public void jWb(string string_0)
	{
		try
		{
			StreamWriter object_ = new StreamWriter(qWl, append: true);
			DateTime dateTime_ = XyV.nJ(XyV.Jy6);
			Ew.nJ(object_, FyK.nJ(CyF.nJ(ref dateTime_, CyF.PyN), ":", string_0, FyK.lyg), Ew.MyD);
			Pyq.nJ(object_, Pyq.Oyb);
		}
		catch (IOException)
		{
			ayW.nJ(string_0, ayW.jyU);
		}
	}

	internal static bool Fn()
	{
		return ue == null;
	}

	internal static OZ ic()
	{
		return ue;
	}
}
