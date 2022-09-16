using System.IO;
using System.ServiceProcess;

namespace vc;

public class a6 : ServiceBase
{
	private RH uA;

	internal static a6 DG;

	public a6()
	{
		OZ.kN(OZ.Ou);
		uA = null;
		((ServiceBase)this)._002Ector();
	}

	protected override void OnStart(string[] args)
	{
		Sn sn = new Sn();
		uA = new RH(sn);
		int num = 1;
		if (fM() != null)
		{
			goto IL_0023;
		}
		goto IL_0032;
		IL_0023:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0071;
		}
		goto IL_0032;
		IL_0032:
		try
		{
			YW.kN(sn, YW.iN4);
		}
		catch (IOException)
		{
			Gl.kN(oNo.kN(this, oNo.NN0), "[LuminousForts-AutoUpdate]Failure to read Configuration file", Gl.ONc);
		}
		goto IL_005e;
		IL_0071:
		if (Wb.kN(uA, Wb.CNS))
		{
			Wb.kN(uA, Wb.YNw);
		}
		dN3.kN(30, dN3.rNd);
		goto IL_005e;
		IL_005e:
		num = 0;
		if (fM() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0023;
	}

	protected override void OnStop()
	{
		if (uA == null || Wb.kN(uA, Wb.CNS))
		{
			return;
		}
		if (!oI())
		{
			switch (0)
			{
			}
		}
		YW.kN(uA, YW.WNh);
	}

	internal static bool oI()
	{
		return DG == null;
	}

	internal static a6 fM()
	{
		return DG;
	}
}
