using System.IO;

namespace vc;

public class Kq
{
	private TI Mm;

	private RH uQ;

	private static Kq kH;

	public Kq(TI ti_0, Sn sn_0)
	{
		OZ.kN(OZ.Ou);
		base._002Ector();
		Mm = ti_0;
		uQ = new RH(sn_0);
	}

	public void S4(string[] string_0)
	{
		Sn object_ = new Sn();
		try
		{
			YW.kN(object_, YW.iN4);
		}
		catch (IOException)
		{
			Gl.kN(Mm, "[LuminousForts-AutoUpdate]Failure to read Configuration file", Gl.QNr);
		}
		while (true)
		{
			if (Wb.kN(uQ, Wb.CNS))
			{
				Wb.kN(uQ, Wb.YNw);
				if (ab() == null)
				{
					switch (0)
					{
					}
				}
			}
			dN3.kN(30, dN3.rNd);
		}
	}

	public void OM()
	{
		if (!Wb.kN(uQ, Wb.CNS))
		{
			YW.kN(uQ, YW.WNh);
		}
	}

	internal static bool cp()
	{
		return kH == null;
	}

	internal static Kq ab()
	{
		return kH;
	}
}
