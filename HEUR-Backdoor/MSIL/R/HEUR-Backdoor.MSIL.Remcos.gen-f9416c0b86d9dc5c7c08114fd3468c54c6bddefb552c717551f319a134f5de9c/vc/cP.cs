using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace vc;

public class cP
{
	private static cP X7;

	private string AE;

	private static cP Sv;

	[SpecialName]
	public static cP q0()
	{
		if (X7 == null)
		{
			X7 = new cP();
			if (BS() == null)
			{
				switch (0)
				{
				}
			}
		}
		return X7;
	}

	public cP()
	{
		OZ.kN(OZ.Ou);
		AE = "log.txt";
		base._002Ector();
	}

	public cP(string string_0)
	{
		OZ.kN(OZ.Ou);
		AE = "log.txt";
		base._002Ector();
		AE = string_0;
	}

	public void zX(string string_0)
	{
		try
		{
			StreamWriter object_ = new StreamWriter(AE, append: true);
			DateTime dateTime_ = CM.kN(CM.s2);
			Gl.kN(object_, Hh.kN(d7.kN(ref dateTime_, d7.q5), ":", string_0, Hh.hr), Gl.rt);
			YW.kN(object_, YW.Qa);
		}
		catch (IOException)
		{
			fP.kN(string_0, fP.Up);
		}
	}

	internal static bool ge()
	{
		return Sv == null;
	}

	internal static cP BS()
	{
		return Sv;
	}
}
